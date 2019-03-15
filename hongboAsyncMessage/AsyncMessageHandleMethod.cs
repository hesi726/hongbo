using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static hongbao.SystemExtension.AssemblyExtension;

namespace hongbao.AsyncMessage
{
    /// <summary>
    /// 
    /// </summary>
    public class AsyncMessageHandleMethod
    {
        /// <summary>
        /// 
        /// </summary>
        private Type messageContentType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="define"></param>
        public AsyncMessageHandleMethod(AssemblyClassMethodAndAttribute define)
        {
            this.MessageHandleMethod = define;
            var attribute = define.Attribute as RegisterAsyncMessageHandleAttribute;
            var parameterType = attribute.MessageContentType;
            var genericObjectType = typeof(AsyncMessageContentWrapper<>);
            messageContentType = genericObjectType.MakeGenericType(parameterType);
        }
        
        /// <summary>
        /// 
        /// </summary>
        private AssemblyClassMethodAndAttribute MessageHandleMethod { get; set; }

        /// <summary>
        /// 转换异步消息为异步消息处理方法的参数类型;
        /// </summary>
        /// <returns></returns>
        private object ConvertMessageToType(AbstractAsyncMessage message)
        {
            dynamic result = JsonConvert.DeserializeObject(message.MessageContent, messageContentType);
            return result.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public bool Handle(AbstractAsyncMessage message)
        {
            var parameter = ConvertMessageToType(message);
            /* if (this.isThreadSafe) //启动任务执行，不过谨慎使用，因为可能会一下子运行1000多个任务;
             { 
                 //启动线程执行;
                 Task.Factory.StartNew(() =>
                 {
                     var constructor = MessageHandleMethod.Type.GetConstructor(Type.EmptyTypes); //获取空构造函数
                     var instance = constructor.Invoke(null);
                     MessageHandleMethod.Method.Invoke(instance, parameter);
                 });
             }
             else */
            var result = this.MessageHandleMethod.Invoke(new object[] { parameter });
            if (result == null) return false;
            return (bool)result;
        }
    }
}
