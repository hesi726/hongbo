using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// ClassExtension
    /// </summary>
    public static class ClassUtil
    {
        /// <summary>
        /// 构建泛型类型并返回
        /// </summary>
        /// <param name="genericType">形如 typeof(GenericType&lt;&gt;)类型或者  typeof(GenericType&lt;,&gt;) typeof(GenericType&lt;,,&gt;)
        ///     而获取到的泛型类型
        /// </param>
        /// <param name="tTypes">泛型类型参数</param>
        /// <returns></returns>
        public static Type BuildGenericType(Type genericType, params Type[] tTypes)
        {
            var genericMemoryObjectType = genericType.MakeGenericType(tTypes);
            return genericMemoryObjectType;
        }

        /// <summary>
        /// 构建泛型对象的实例;此类型应该有空的构造函数;
        /// </summary>
        /// <param name="genericType">形如 typeof(GenericType&lt;&gt;)类型或者  typeof(GenericType&lt;,&gt;) typeof(GenericType&lt;,,&gt;)
        ///     而获取到的泛型类型
        /// </param>
        /// <param name="tTypes">泛型类型参数</param>
        /// <returns></returns>
        public static object BuildGenericTypeInstance(Type genericType, params Type[] tTypes)
        {
            var type = BuildGenericType(genericType, tTypes);
            return type.GetConstructor(Type.EmptyTypes).Invoke(null);
        }

        /// <summary>
        /// 构建泛型对象的实例;此类型应该有空的构造函数;
        /// </summary>
        /// <param name="genericType">形如 typeof(GenericType&lt;&gt;)类型或者  typeof(GenericType&lt;,&gt;) typeof(GenericType&lt;,,&gt;)
        ///     而获取到的泛型类型
        /// </param>
        /// <param name="tTypes">泛型类型参数</param>
        /// <param name="constructParams"></param>
        /// <returns></returns>
        public static object BuildGenericTypeInstance(Type genericType, Type[] tTypes, params object[] constructParams)
        {
            var type = BuildGenericType(genericType, tTypes);
            var constructTypes = constructParams.Select(b => b.GetType()).ToArray();
            var construct = type.GetConstructor(constructTypes);
            return construct.Invoke(constructParams);
        }

        /// <summary>
        /// 构建泛型方法,在 实例的非公开方法中寻找给定名称的方法并构建泛型方法;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="methodName"></param>
        /// <param name="genericTypes"></param>
        /// <returns></returns>
        public static MethodInfo BuildGenericMethod(Type type, string methodName, params Type[] genericTypes)
        {
            var method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
            method = method.MakeGenericMethod(genericTypes);
            return method;
        }
       
        
    }
}
