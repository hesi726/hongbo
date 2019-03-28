using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.EntityExtension
{
    /// <summary>
    /// EntityFamework的工具类
    /// </summary>
    public static class EFUtil
    {
        /// <summary>
        /// 获取真实的实体类型;
        /// </summary>
        /// <param name="entityType"></param>
        /// <returns></returns>
        public static Type GetObjectType(Type maybeProxyType)
        {
            var result = maybeProxyType;
            var typeNs = maybeProxyType.Namespace;
            var typeName = maybeProxyType.Name;
            if (typeNs == "System.Data.Entity.DynamicProxies") //代理类型
            {
                result = maybeProxyType.BaseType;
            }
#warning ("可能会有错误,不知道 EntityFrameworkCore 自动产生的代理类型会需要什么样的参数")
            if (typeNs.StartsWith("Microsoft.EntityFrameworkCore"))
            {
                result = maybeProxyType.BaseType;
            }
            return result;
        }
        /// <summary>
        /// 返回实体类的名称，对于可能产生动态的代理类，返回此代理类所代理的实体类的名称；
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static string GetTypeName(Type type)
        {
            return GetObjectType(type).Name;
        }

        /// <summary>
        /// 获取缓存键，返回类似于 EH_DeviceInfo: 或者 EH_DeviceInfo:abcdefg 之类的字符串;
        /// </summary>
        /// <param name="type">类型，作为键的前缀，如果传入EF的代理类型，将返回其真实类型;</param>
        /// <param name="appenx">后缀键字符串</param>
        /// <returns></returns>
        public static string GetCacheKey(Type type, string appenx = null)
        {
            var typeName = GetTypeName(type);
            if (appenx == null) return string.Format("{0}:", typeName);
            else return $"{typeName}:{appenx}" ;
        }
    }
}
