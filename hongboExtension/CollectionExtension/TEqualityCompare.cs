using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.CollectionExtension
{
    /// <summary>
    /// 对 IEqualityComparer 接口的一个实现类； 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TEqualityCompare<T> : IEqualityComparer<T>
    {
        Func<T, T, bool> compareFunc;
        Func<T, int> hashcodeFunc;
        /// <summary>
        /// 构造函数； 
        /// </summary>
        /// <param name="compareFunc"></param>
        /// <param name="hashcodeFunc">必须提供，因为将首先使用 hash进行比较;</param>
        public TEqualityCompare(Func<T, T, bool> compareFunc, Func<T, int> hashcodeFunc)
        {
            this.compareFunc = compareFunc;
            this.hashcodeFunc = hashcodeFunc;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool Equals(T x, T y)
        {
            return this.compareFunc(x, y);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int GetHashCode(T obj)
        {
            return this.hashcodeFunc(obj);
        }
    }
}
