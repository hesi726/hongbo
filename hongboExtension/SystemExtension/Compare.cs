using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    ///一个排序类； 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Compare<T> : IComparer<T>
    {
        Func<T, T, int> compareFunc = null;
        /// <summary>
        /// 构造函数； 
        /// </summary>
        /// <param name="compareFunc"></param>
        public Compare(Func<T, T, int> compareFunc)
        {
            this.compareFunc = compareFunc;
        }
        /// <summary>
        /// 实现 比较接口； 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int IComparer<T>.Compare(T x, T y)
        {
            return compareFunc(x, y);
        }
    }
}
