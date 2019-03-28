
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using hongbao.CollectionExtension;
using hongbao.EntityExtension;
using hongbao.SystemExtension;
using hongbo.EntityExtension;
using static hongbao.SystemExtension.AssemblyExtension;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif
namespace hongbao.AsyncMessage
{
    /// <summary>
    /// 异步消息的处理类
    /// </summary>
    public class AsyncMessageHandle<TDbContext>
        where TDbContext : DbContext, new()
    {
        private string tableName;
        Action<string> handleLog;
        Action<string> errorLog;

        string querySql;
        string queryMessageHandleDefineSql;
        string deleteSql;
        string incrHandleSql;
        /// <summary>
        /// 构造函数, 表名称;
        /// </summary>
        /// <param name="asyncMessageTableType">异步消息数据表的类名称，根据此类名称解析表名称</param>
        /// <param name="asyncMessageHandleDefineTablType">异步消息处理定义表的类名称，根据此类名称解析表名称</param>
        /// <param name="handleLog">处理日志</param>
        /// <param name="errorLog">错误日志</param>
        public AsyncMessageHandle(
            Type asyncMessageTableType,
            Type asyncMessageHandleDefineTablType,
            Action<string> handleLog,
            Action<string> errorLog): this(asyncMessageTableType.Name, asyncMessageHandleDefineTablType.Name, handleLog, errorLog)
        {

        }
        /// <summary>
        /// 构造函数, 表名称;
        /// </summary>
        /// <param name="asyncMessageTableName">异步消息数据表的表名称</param>
        /// <param name="asyncMessageHandleDefineTablName">异步消息处理定义表的表名称</param>
        /// <param name="handleLog">处理日志</param>
        /// <param name="errorLog">错误日志</param>
        public AsyncMessageHandle(
            string asyncMessageTableName, 
            string asyncMessageHandleDefineTablName,              
            Action<string> handleLog,
            Action<string> errorLog)
        {
            this.tableName = asyncMessageTableName;
            this.handleLog = handleLog;
            this.errorLog = errorLog;
            this.querySql = "select * from " + asyncMessageTableName + " where HandleTimes<10";
            this.queryMessageHandleDefineSql = "select * from " + asyncMessageHandleDefineTablName;
            this.deleteSql = "delete from " + asyncMessageTableName + " where id={0}";
            this.incrHandleSql = "update " + asyncMessageTableName + " set HandleTimes=HandleTimes+1, CreateDateTime=getdate() where id={0}";
        }


        /// <summary>
        /// 
        /// </summary>
        Dictionary<int, AsyncMessageHandleMethod> map =  new Dictionary<int, AsyncMessageHandleMethod>();

        DateTime lastDatetime = DateTime.Parse("2001-01-01");

        /// <summary>
        /// 扫描程序集查找所有标记 RegisterAsyncMessageHandleAttribute 属性的方法, 注册此方法为异步消息处理方法
        /// </summary>
        /// <param name="assembly"></param>
        public void Setup(Assembly assembly)
        {
            if (assembly == null)
            {
                assembly = DefaultAssembly;
            }
            if (assembly != null)
            {
                var notifyAttriList = EnumMethodWithAttribute(assembly, typeof(RegisterAsyncMessageHandleAttribute));
                foreach (var notify in notifyAttriList)
                {                    
                    Register(notify);
                }
            }
        }
        private Assembly defaultAssembly;

        private Assembly DefaultAssembly
        {
            get
            {
                if (DefaultAssemblyName == null) return null;
                if (defaultAssembly == null)
                {
                    defaultAssembly = Assembly.Load(DefaultAssemblyName);
                }
                return defaultAssembly;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handleDefineList"></param>
        public void Setup<T>(List<T> handleDefineList)
            where T: AbstractAsyncMessageHandleDefine
        {
            if (handleDefineList != null)
            {
                foreach (var defineGroup in handleDefineList.GroupBy(a=> a.AssemblyName))
                {
                    Assembly assembly = null;
                    if (defineGroup.Key == null) assembly = DefaultAssembly;
                    else assembly = Assembly.Load(defineGroup.Key);
                    if (assembly == null) continue;

                    foreach (var define in defineGroup)
                    {
                        var type = assembly.GetType(define.ClassName);
                        if (type == null)
                        {
                            this.errorLog?.Invoke(string.Format("无法找到类:{0}", define.ClassName));
                            return;
                        }
                        var method = type.GetMethods().Where(a =>
                        {
                            if (a.Name != define.MethodName) return false;
                            var par = a.GetParameters();
                            if (ArrayUtil.IsNullOrEmpty(par)) return false;
                            if (par.Length > 1) return false;
                            if (!par[0].ParameterType.Name.EndsWith(define.ParameterType)) return false;
                            return true;
                        }).FirstOrDefault();
                        if (method == null)
                        {
                            this.errorLog?.Invoke(string.Format("无法找到类 {0} 处理方法:{1}", define.ClassName, define.MethodName));
                            return;
                        }
                        // var parType = method.GetParameters()[0].ParameterType;
                        var attribute = new RegisterAsyncMessageHandleAttribute(define.MessageType, null, define.IsThreadSafe);
                        AssemblyClassMethodAndAttribute definex = new AssemblyClassMethodAndAttribute
                        {
                            Assembly = assembly,
                            Type = type,
                            Method = method,
                            Attribute = attribute
                        };
                        Register(definex);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="define"></param>
        private void Register(AssemblyClassMethodAndAttribute define)
        {
            var attribute = define.Attribute as RegisterAsyncMessageHandleAttribute;
            var type = attribute.MessageType;
            if (attribute.MessageContentType == null)
            {
                attribute.MessageContentType = define.Method.GetParameters()[0].ParameterType;
            }
            map[type] = new AsyncMessageHandleMethod(define);
        }

        /// <summary>
        /// 注册的消息处理的数量
        /// </summary>
        public int MapCount { get { return this.map.Count; } }

        /// <summary>
        /// 默认的程序集名称，当未定义从哪一个程序集加载类时，从默认程序集加载类;
        /// </summary>
        public string DefaultAssemblyName { get;  set; }

        /// <summary>
        /// 根据处理表 处理所有的异步消息,
        /// 每5秒执行一次查询;
        /// </summary>
        public void StartHandle()
        {
            try
            {
                int loopCount = 0;
                while (true)
                {
                    Handle(loopCount++);
                    Thread.Sleep(5000);
                }
            }
            catch(Exception exp)
            {
                this.errorLog?.Invoke(string.Format(@"异常 {0} 类型消息处理的
{1}", exp.Message, exp.StackTrace));
            }
        }

        /// <summary>
        /// 处理消息
        /// </summary>
        /// <param name="loopCount"></param>
        /// <returns></returns>
        public void Handle(int loopCount = 0)
        {
            if (loopCount == 0) Setup((Assembly) null);
            List<AbstractAsyncMessage> messageList = null;
            using (var context = new TDbContext())
            {
                messageList = context.Database.SqlQuery<AbstractAsyncMessage>(this.querySql).ToList();
                var asyncMessageHandleDefineList = context.Database.SqlQuery<AbstractAsyncMessageHandleDefine>(queryMessageHandleDefineSql).ToList();
                Setup(asyncMessageHandleDefineList);
            };               
            this.handleLog?.Invoke(string.Format("第{0}处理异步消息处理,查询到待处理消息:{1}", loopCount, messageList.Count));
            foreach (var message in messageList)
            {
                try
                {
                    AsyncMessageHandleMethod handle = GetHandle(message.MessageType);
                    if (handle == null)
                    {
                        this.errorLog?.Invoke(string.Format("未定义 {0} 类型消息处理的函数", message.MessageType.ToString()));
                        continue;
                    }
                    if (handle.Handle(message))
                    {
                        this.handleLog?.Invoke(string.Format("已经处理消息:{0}-{1}", message.Id, message.MessageContent));
                        DeleteAsyncMessage(message); //删除某一个异步消息
                    }
                    else
                    {
                        IncrementAsyncMessageHandleTimes(message);
                    }
                }
                catch (Exception e)
                {
                    this.errorLog?.Invoke(string.Format("{0}\n{1}\n{2}", e.Message,e.StackTrace, message));
                    IncrementAsyncMessageHandleTimes(message);
                }
            }
        }

        /// <summary>
        /// 获取消息的处理方法
        /// </summary>
        /// <param name="messageType"></param>
        /// <returns></returns>
        public AsyncMessageHandleMethod GetHandle(int messageType)
        {
            AsyncMessageHandleMethod handle = null;
            this.map.TryGetValue(messageType, out handle);
            return handle;
        }

        /// <summary>
        /// 删除此异步消息
        /// </summary>
        public void DeleteAsyncMessage(AbstractAsyncMessage msg)
        {
            DbContextExtension.ActionContext<TDbContext>(context =>
            {
                context.Database.ExecuteSqlCommand(this.deleteSql, msg.Id);
            }, null, null);
        }

        /// <summary>
        /// 增加错误处理错误;
        /// </summary>
        public void IncrementAsyncMessageHandleTimes(AbstractAsyncMessage msg)
        {
            DbContextExtension.ActionContext<TDbContext>(context =>
            {
                context.Database.ExecuteSqlCommand(this.incrHandleSql, msg.Id);
            }, null, null);
        }
    }
}
