using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Reflection
{
    /// <summary>
    /// 反射的工具类;
    /// </summary>
    public static class ReflectionUtil
    {
        /// <summary>
        /// 根据类型查找给定的方法，(先找非公开实例方法，再找公开实例方法)
        /// 如果方法是泛型方法，使用给定泛型类型将此方法转换为泛型方法
        /// 如果找不到方法，返回 null;
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="genericParameterType">泛型参数类型</param>
        /// <returns></returns>
        public static MethodInfo ConvertToGeneric(Type type, string methodName, Type genericParameterType)
        {
            var method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
            if (method == null)  method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);
            if (method == null) return null;
            if (method.IsGenericMethod)
            {
                return method.MakeGenericMethod(genericParameterType);
            }
            return method;
        }
    }
}
