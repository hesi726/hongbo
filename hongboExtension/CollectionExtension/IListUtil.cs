using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbaoStandardExtension.CollectionExtension
{
    ///// <summary>
    ///// 
    ///// </summary>
    //public static class ArrayUtil
    //{
    //    ///// <summary>
    //    ///// 
    //    ///// </summary>
    //    ///// <param name="array"></param>
    //    ///// <returns></returns>
    //    //public static bool IsNullOrEmpty(Array array)
    //    //{
    //    //    return array == null || array.Length == 0;
    //    //}

    //    ///// <summary>
    //    ///// 
    //    ///// </summary>
    //    ///// <param name="array"></param>
    //    ///// <returns></returns>
    //    //public static object Find(Array array, Func<object, bool> func)
    //    //{
    //    //    int count = array.Length;
    //    //    for(var index=0; index<count; index++)
    //    //    {
    //    //        var ele = array.GetValue(index);
    //    //        if (func(ele)) return ele;
    //    //    }
    //    //    return null;
    //    //}
    //}
    /// <summary>
    /// 
    /// </summary>
    public static class IListUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(IList<T> array)
        {
            return array == null || array.Count == 0;
        }
    }
}
