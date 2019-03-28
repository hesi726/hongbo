using hongbao.CollectionExtension;
using hongbao.EntityExtension;
using hongbao.SystemExtension;
using hongbao.Vue.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static hongbao.SystemExtension.AssemblyExtension;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// 限制条件的属性;
    /// </summary>
    public interface ILimitAttribute
    {
        /// <summary>
        /// 单个权限;
        /// </summary>
        string privilege { get; set; }
        /// <summary>
        /// 限制的用户类型：
        /// </summary>
        int userType { get; set; }
        /// <summary>
        /// 需要任意一个权限时即显示此组件;
        /// 此为权限字符串;
        /// </summary>
        string[] anyPrivilege { get; set; }

        /// <summary>
        /// 需要所有权限时即显示此组件;
        /// 此为权限字符串;
        /// </summary>
        string[] allPrivilege { get; set; }

        /// <summary>
        /// 限制的请求类型 ，
        /// 当不为null时，此定义只对给定 limitType 产生 EntityTypeVueDefine 时才有效；
        /// 例如， MachineOrBoardQueryResponse 
        /// 对于 MachineOrBoardQueryParameter_Machine 和 MachineOrBoardQueryParameter_Machine
        /// 会产生不同的结果;
        /// </summary>
        [JsonIgnore]
        Type limitRequestEntityType { get; set; }

        /// <summary>
        /// 是否允许编辑;
        /// </summary>
        bool allowEdit { get; set; }

        /// <summary>
        /// 允许编辑时所需要的权限;
        /// </summary>
        string allowEditPrivilege { get; set; }
    }


    /// <summary>
    /// 在实体列表中,通过 checkbox 选择实体(可以选择多个实体) 后能够进行的操作定义;
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Class, AllowMultiple = true)]
    public class AbstractEntitysOperateDefineAttribute : Attribute, ILimitAttribute
    {
        #region 类定义的属性      
        /// <summary>
        /// 操作类型;使用Id进行标记;
        /// </summary>
        public int entityOperateId { get; protected set; }

        /// <summary>
        /// 说明文字
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// 详细说明
        /// </summary>
        public string detail { get; set; }

        /// <summary>
        /// 过滤的用户类型;
        /// </summary>
        [JsonIgnore]
        public int userType { get; set; }
        /// <summary>
        /// 单个权限;
        /// </summary>
        [JsonIgnore]
        public string privilege { get; set; }

        /// <summary>
        /// 需要任意一个权限时即显示此组件;
        /// 此为权限字符串;
        /// </summary>
        [JsonIgnore]
        public string[] anyPrivilege { get; set; }

        /// <summary>
        /// 需要所有权限时即显示此组件;
        /// 此为权限字符串;
        /// </summary>
        [JsonIgnore]
        public string[] allPrivilege { get; set; }

        /// <summary>
        /// 限制类型，当不为null时，此定义只对给定 limitType 产生 EntityTypeVueDefine 时才有效；
        /// 例如， MachineOrBoardQueryResponse 
        /// 对于 MachineOrBoardQueryParameter_Machine 和 MachineOrBoardQueryParameter_Machine
        /// 会产生不同的结果;
        /// </summary>
        [JsonIgnore]
        public Type limitRequestEntityType { get; set; }

        /// <summary>
        /// 是否允许编辑,本类中总是 false;
        /// </summary>
        public bool allowEdit { get; set; }

        /// <summary>
        /// 允许编辑时候所需要的权限;
        /// </summary>
        [JsonIgnore]
        public string allowEditPrivilege { get; set; }

        /// <summary>
        /// Id字段，默认为 Xid;
        /// </summary>
        [NotNull]
        public string idField { get; set; }

        /// <summary>
        /// 操作路径，默认下等于 ClassName + "." + MethodName + "." + label + "." + operatePathAppenx 
        /// 对于相同的 limitType, 必须唯一;
        /// </summary>
        [NotNull]
        public string operatePath { get; private set; }

        /// <summary>
        /// 因为一个方法可以绑定有多个参数, 所以增加此参数以保证 operatePath 的唯一性;
        /// </summary>
        [JsonIgnore]
        public string operatePathAppenx { get; set; }

        /// <summary>
        /// 操作时将传向客户端，并且可能会有客户端向服务器传递的参数;
        /// </summary>
        public object operateParameter { get; set; }
        #endregion

        static IDictionary<string, Dictionary<string, AssemblyClassMethodAndAttribute<AbstractEntitysOperateDefineAttribute>>> map = 
                            new Dictionary<string, Dictionary<string, AssemblyClassMethodAndAttribute<AbstractEntitysOperateDefineAttribute>>>();

        /// <summary>
        /// 清理
        /// </summary>
        public static void Clear()
        {
            map.Clear();
        }
        /// <summary>
        /// 测试方法，获取 Map中项目的数量;
        /// </summary>
        /// <returns></returns>
        public static int GetMapCount()
        {
            return map.Count();
        }

        /// <summary>
        /// 扫描程序集查找所有标记 AbstractEntitysOperateDefineAttribute 属性的方法, 注册此方法为异步消息处理方法；
        /// 
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="methodDelegateType">方法所需要兼容的委托类型,如果为null,则表示不需要；</param>
        public static void RegisterAssembly(Assembly assembly, 
            Type methodDelegateType = null)
        {
            List<AssemblyClassMethodAndAttribute<AbstractEntitysOperateDefineAttribute>> notifyAttriList =
                EnumMethodWithAttribute<AbstractEntitysOperateDefineAttribute>(assembly)
                .Where(a =>
                {
                    if (methodDelegateType == null) return true;
                    if (DelegateUtil.HasCompatiableMethodParameter(methodDelegateType, a.Method))
                    {
                        return true;
                    }
                    return false;
                }).ToList();
            notifyAttriList.ForEach((a) =>
                {
                    //if (a.Attribute.operatePathAppenx == null)
                    //{
                    //    a.Attribute.operatePathAppenx = a.Attribute.label;
                    //}
                    a.Attribute.operatePath = string.Format("{0}.{1}.{2}.{3}", a.Type.Name, a.Method.Name, a.Attribute.label, a.Attribute.operatePathAppenx); //改变 operatePath 为 ClassName.MethodName
                   
                });
            notifyAttriList.GroupBy(a => a.Attribute.limitRequestEntityType.Name).Any((entityTypeNameGroup) =>
             {
                 var innerMap = DictionaryUtil.FindOrInsert(map, entityTypeNameGroup.Key, 
                     new Dictionary<string, AssemblyClassMethodAndAttribute<AbstractEntitysOperateDefineAttribute>>());
                 var pairGroup = entityTypeNameGroup.ToDictionary((pair) => pair.Attribute.operatePath, pair => pair)
                     .ToArray();
                 innerMap.AddRange(pairGroup);
                 return false;
             });
        }

        /// <summary>
        /// 根据实体类 和 操作路径 获取 AssemblyClassMethodAndAttribute&lt;AbstractEntitysOperateDefineAttribute&gt;
        /// 的实例;
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="operatePath"></param>
        /// <returns></returns>
        public static AssemblyClassMethodAndAttribute<AbstractEntitysOperateDefineAttribute> GetOperateDefine(
             Type entityType,
             string operatePath)
        {
            Dictionary<string, AssemblyClassMethodAndAttribute<AbstractEntitysOperateDefineAttribute>>
              innerMap;
            if (map.TryGetValue(entityType.Name, out innerMap))
            {
                AssemblyClassMethodAndAttribute<AbstractEntitysOperateDefineAttribute> result = null;
                if (innerMap.TryGetValue(operatePath, out result))
                {
                    return result;
                }
            }
            return null;
        }
        /// <summary>
        /// 根据给定 entityType 获取 
        /// a. 此类上定义的 AbstractEntitysOperateDefineAttribute 标注；
        /// b. 使用 Register 扫描到的程序集上所有的 标记了 RegisterEntityOperateAttribute 的方法，并且
        ///    RegisterEntityOperateAttribute 标注的 limitType= 给定 entityType;
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<AbstractEntitysOperateDefineAttribute> GetOperateDefineList(
             Type entityType,
             Func<ILimitAttribute, bool> filterFunc)
        {
            var list = entityType.GetCustomAttributes<AbstractEntitysOperateDefineAttribute>()
                    .Where(c => filterFunc(c))
                    .ToList();
            Dictionary<string, AssemblyClassMethodAndAttribute<AbstractEntitysOperateDefineAttribute>>
               innerMap;
            if (map.TryGetValue(entityType.Name, out innerMap))
            {
                list.AddRange(innerMap.Values.Where(value => filterFunc(value.Attribute)).Select(a=> a.Attribute));
            }
            return list;
        }
    }


    /// <summary>
    /// 定义在类上的标注，
    /// 表示此类可以进行 entityOperateId 对应的处理
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class RegisterEntityOperateTypeAttribute : AbstractEntitysOperateDefineAttribute
    {
        /// <summary>
        /// 按照指定的方法操作类型;
        /// </summary>
        /// <param name="entityOperateId">用于表示将对实体进行什么样的操作：</param>
        public RegisterEntityOperateTypeAttribute(int entityOperateId)
        {
            this.entityOperateId = entityOperateId;
            this.idField = "Xid";
        }

    }

    /// <summary>
    /// 实体操作方法的委托类型,所有实体操作方法的委托类型均应该和此委托有相同的输入参数和输出参数
    /// 或者能够强制转换的输入或者输出参数;
    /// </summary>
    /// <param name="ids">传入待操作id数组</param>
    /// <param name="inputParameter">可能需要用户传入的参数(从客户端传入，貌似只能是字符串)</param>
    /// <param name="attribute"> AbstractEntityOperateDefineAttribute 实例 </param>
    /// <param name="context">数据上下文;</param>
    /// <returns></returns>
    public delegate object EntityOperateDelegate<TDbContext>(string[] ids, AbstractEntitysOperateDefineAttribute attribute, string inputParameter, TDbContext context)
                where TDbContext : DbContext;

    /// <summary>
    /// 定义在方法上的标注，表示此方法适应于某一个实体，
    /// 说明，所有有此标注的方法必须具有和 <seealso cref="EntityOperateDelegate&lt;TDbContext&gt;">EntityOperateDelegate&lt;TDbContext&gt;</seealso>"/>相同的接口
    /// EntityOperateDelegate&lt;TDbContext&gt;委托: 具有如下参数:
    /// string[]  ids -- 待操作的实体Ids 或者其他行义的字符串数组;<br/>
    /// <see cref="AbstractEntitysOperateDefineAttribute"/>attribute, AbstractEntitysOperateDefineAttribute 标注类的实例;<br/>
    /// string inputParameter - 用户输入的其他参数<br/>
    /// TDbContext context  -- DbContext的泛型类<br/>
    /// 必须使用 AbstractEntitysOperateDefineAttribute.Register 注册程序集;
    /// 并且此方法应该接收2个参数，
    /// 此标注将设置 operatePath=MethodClassName.MethodName
    /// 第一个参数为 ids,
    /// 第二个参数为 DbContext(可能为null)
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class RegisterEntityOperateAttribute : AbstractEntitysOperateDefineAttribute
    {       
        /// <summary>
        /// RegisterEntityOperateAttribute
        /// </summary>
        /// <param name="limitRequestEntityType">
        /// 本标注所关联的实体类型
        /// 需要使用到此参数来标记此方法如何应该操作那个实体类,以避免非授权用户使用此参数去操作另外一个实体类
        /// </param>
        public RegisterEntityOperateAttribute(Type limitRequestEntityType):base()
        {
            this.limitRequestEntityType = limitRequestEntityType;
            this.idField = "Xid";
        }

       
    }
}
