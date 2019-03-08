using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Reflection
{
    /// <summary>
    /// Type的工具类
    /// </summary>
    public static class TypeUtil
    {
        /// <summary>
        /// 查询第一个带有给定标注的属性;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="judgeFunc"></param>
        /// <returns></returns>
        public static (PropertyInfo Property,  T Attr) GetFirstPropertyWithAttribute<T>(Type type, Func<T,bool> judgeFunc = null)
            where T: Attribute
        {
            return GetPropertysWithAttribute<T>(type, judgeFunc).FirstOrDefault();
        }

        /// <summary>
        /// 查询带有给定标注的属性;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="judgeFunc"></param>
        /// <returns></returns>
        public static List<(PropertyInfo Property, T Attr)> GetPropertysWithAttribute<T>(Type type, Func<T, bool> judgeFunc = null)
            where T : Attribute
        {
            if (judgeFunc == null) judgeFunc = (t) => true;
            return type.GetProperties().Select(a => new { a, attr = GetCustomerAttribute<T>(a) })
                .Where(a => a.attr != null && judgeFunc(a.attr))
                .Select(a => (a.a, a.attr)).ToList();
        }

        /// <summary>
        /// 获取自定义的标注;一个很讨厌的问题是 无法根据标注类获取到该标注是定义在哪个类或者属性上;
        /// 所以我们自定义了一个方法，如果标注是TAttr 是 CommonAttribute 的子类，则给标注的实例的 OwnerType 赋值；
        /// </summary>
        /// <typeparam name="TAttr"></typeparam>
        /// <param name="property"></param>
        /// <returns></returns>
        public static TAttr GetCustomerAttribute<TAttr>(PropertyInfo property)
            where TAttr : Attribute
        {          
            var result = property.GetCustomAttribute<TAttr>();
            return result;
        }

        /// <summary>
        /// 返回与指定类型的代理对象关联的 POCO 实体的实体类型
        /// </summary>
        /// <param name="maybeProxyType">可能是实体的代理类型或者实体类型</param>
        /// <returns></returns>
        public static Type GetPocoType(Type maybeProxyType)
        {
            var result = maybeProxyType;
            var typeNs = maybeProxyType.Namespace;
            var typeName = maybeProxyType.Name;
            if (typeNs == "System.Data.Entity.DynamicProxies") //代理类型
            {
                result = maybeProxyType.BaseType;  // 返回与指定类型的代理对象关联的 POCO 实体的实体类型
            }
            return result;
        }

        ///// <summary>
        ///// 获取自定义的标注;
        ///// </summary>
        ///// <typeparam name="TAttr"></typeparam>
        ///// <param name="property"></param>
        ///// <returns></returns>
        //public static IEnumerable<TAttr> GetCustomAttributes<TAttr>(PropertyInfo property)
        //    where TAttr : Attribute
        //{
        //    bool isCommonAttribute = typeof(CommonAttribute).IsAssignableFrom(typeof(TAttr));
        //    if (!isCommonAttribute)
        //        return property.GetCustomAttributes<TAttr>();
        //    return property.GetCustomAttributes<TAttr>().Select(b =>
        //    {
        //        (b as CommonAttribute).SetOwnerProperty(property);
        //        return b;
        //    });
        //}

        ///// <summary>
        ///// 获取自定义的标注;一个很讨厌的问题是 无法根据标注类获取到该标注是定义在哪个类或者属性上;
        ///// 所以我们自定义了一个方法，如果标注是TAttr 是 CommonAttribute 的子类，则给标注的实例的 OwnerType 赋值；
        ///// </summary>
        ///// <typeparam name="TAttr"></typeparam>
        ///// <param name="type"></param>
        ///// <returns></returns>
        //public static TAttr GetCustomerAttribute<TAttr>(Type type)
        //    where TAttr : Attribute
        //{
        //    bool isCommonAttribute = typeof(CommonAttribute).IsAssignableFrom(typeof(TAttr));
        //    var result = type.GetCustomAttribute<TAttr>();
        //    if (isCommonAttribute)
        //    {
        //        (result as CommonAttribute).SetOwnerType(type);
        //    }
        //    return result;
        //}

        ///// <summary>
        ///// 获取自定义的标注;
        ///// </summary>
        ///// <typeparam name="TAttr"></typeparam>
        ///// <param name="type"></param>
        ///// <returns></returns>
        //public static IEnumerable<TAttr> GetCustomAttributes<TAttr>(Type type)
        //    where TAttr : Attribute
        //{
        //    bool isCommonAttribute = typeof(CommonAttribute).IsAssignableFrom(typeof(TAttr));
        //    if (!isCommonAttribute)
        //        return type.GetCustomAttributes<TAttr>();
        //    return type.GetCustomAttributes<TAttr>().Select(b =>
        //    {
        //        (b as CommonAttribute).SetOwnerType(type);
        //        return b;
        //    });
        //}
    }
}
