using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Reflection
{
    /// <summary>
    /// 动态集合类工具； 
    /// </summary>
    public static class DynamicCollectionUtil
    {
        static Type TYPEOF_DynamicCollectionUtil = null;
        static MethodInfo CreateCollectionMethodInfo = null; 
        /// <summary>
        /// 
        /// </summary>
        static DynamicCollectionUtil()
        {
            TYPEOF_DynamicCollectionUtil = typeof(DynamicCollectionUtil);
            CreateCollectionMethodInfo = TYPEOF_DynamicCollectionUtil.GetMethod("CreateCollection");

        }
        /// <summary>
        /// 返回一个集合类； 并给集合赋予初始化元素； 
        /// </summary>
        /// <returns></returns>
        public static ICollection<T> CreateCollection<T>(object[] elements)
        {
            var result = new List<T>();
            if (elements != null) result.AddRange(elements.Select((x) => (T)x));
            return result;
        }

        /// <summary>
        /// 根据类型返回一个集合类； 并给集合赋予初始化元素； 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static object CreateCollectionByType(Type type, object[] elements = null)
        {
            return CreateCollectionMethodInfo.MakeGenericMethod(type).Invoke(null,new object[]{elements});
        }
    }
}
