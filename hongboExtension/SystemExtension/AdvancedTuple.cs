using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 因为　　Tuple 为只读，　更麻烦的是 Tuple 没有提供构造函数； 
    /// 所以创建一个可以读写的元组，主要是为了避免在　DataContext 执行动态查询时，
    /// 去创建一些不必要的类；
    /// 而只要将字段名处改为　　Item1, Item2, ... 即可；
    /// </summary>
    public static class AdvancedTuple
    {
        /// <summary>
        /// 创建单元素的 Tuple 对象； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static AdvancedTuple<T> Create<T>(T item)
        {
            return new AdvancedTuple<T> { Item1 = item };
        }

        /// <summary>
        /// 创建2个元素的 Tuple 对象； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static AdvancedTuple<T,K> Create<T,K>(T item1, K item2)
        {
            return new AdvancedTuple<T,K> { Item1 = item1, Item2 = item2 };
        }

        /// <summary>
        /// 创建3个元素的 Tuple 对象； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <param name="item3"></param>
        /// <returns></returns>
        public static AdvancedTuple<T, K, J> Create<T, K, J>(T item1, K item2, J item3)
        {
            return new AdvancedTuple<T, K, J> { Item1 = item1, Item2 = item2, Item3 = item3  };
        }

        /// <summary>
        /// 创建4个元素的 Tuple 对象； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <typeparam name="L"></typeparam>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <param name="item3"></param>
        /// <param name="item4"></param>
        /// <returns></returns>
        public static AdvancedTuple<T, K, J, L> Create<T, K, J, L>(T item1, K item2, J item3, L item4)
        {
            return new AdvancedTuple<T, K, J, L> { Item1 = item1, Item2 = item2, Item3 = item3, Item4 = item4 };
        }

        /// <summary>
        /// 创建5个元素的 Tuple 对象； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <typeparam name="L"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <param name="item3"></param>
        /// <param name="item4"></param>
        /// <param name="item5"></param>
        /// <returns></returns>
        public static AdvancedTuple<T, K, J, L, M> Create<T, K, J, L, M>(T item1, K item2, J item3, L item4, M item5)
        {
            return new AdvancedTuple<T, K, J, L, M> { Item1 = item1, Item2 = item2, Item3 = item3, Item4 = item4, Item5 = item5 };
        }

        /// <summary>
        /// 创建6个元素的 Tuple 对象； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <typeparam name="L"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="O"></typeparam>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <param name="item3"></param>
        /// <param name="item4"></param>
        /// <param name="item5"></param>
        /// <param name="item6"></param>
        /// <returns></returns>
        public static AdvancedTuple<T, K, J, L, M, O> Create<T, K, J, L, M, O >(T item1, K item2, J item3, L item4, M item5, O item6)
        {
            return new AdvancedTuple<T, K, J, L, M, O> { Item1 = item1, Item2 = item2, Item3 = item3, Item4 = item4, Item5 = item5, Item6 = item6 };
        }

        /// <summary>
        /// 创建7个元素的 Tuple 对象； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <typeparam name="L"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="O"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <param name="item3"></param>
        /// <param name="item4"></param>
        /// <param name="item5"></param>
        /// <param name="item6"></param>
        /// <param name="item7"></param>
        /// <returns></returns>
        public static AdvancedTuple<T, K, J, L, M, O, P> Create<T, K, J, L, M, O, P>(T item1, K item2, J item3, L item4, M item5, O item6, P item7)
        {
            return new AdvancedTuple<T, K, J, L, M, O, P> { Item1 = item1, Item2 = item2, Item3 = item3, Item4 = item4, Item5 = item5, Item6 = item6, Item7 = item7 };
        }

        /// <summary>
        /// 创建8个元素的 Tuple 对象； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <typeparam name="L"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <typeparam name="O"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <typeparam name="Q"></typeparam>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <param name="item3"></param>
        /// <param name="item4"></param>
        /// <param name="item5"></param>
        /// <param name="item6"></param>
        /// <param name="item7"></param>
        /// <param name="item8"></param>
        /// <returns></returns>
        public static AdvancedTuple<T, K, J, L, M, O, P, Q> Create<T, K, J, L, M, O, P, Q>(T item1, K item2, J item3, L item4, M item5, O item6, P item7,Q item8)
        {
            return new AdvancedTuple<T, K, J, L, M, O, P, Q> { Item1 = item1, Item2 = item2, Item3 = item3, Item4 = item4, Item5 = item5, Item6 = item6, Item7 = item7, Item8 = item8 };
        }
    }

    /// <summary>
    /// 单个元素的 Tuple 类; , 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AdvancedTuple<T>
    {        
        /// <summary>
        /// 元素1；
        /// </summary>
         public T Item1 { get; set;  }

    }

    /// <summary>
    /// 2个元素的 Tuple 类; , 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public class AdvancedTuple<T,K> : AdvancedTuple<T>
    {
        /// <summary>
        /// 元素2；
        /// </summary>
        public K Item2 { get; set; }
    }

    /// <summary>
    /// 3个元素的 Tuple 类; , 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="J"></typeparam>
    public class AdvancedTuple<T, K, J> : AdvancedTuple<T, K>
    {
        /// <summary>
        /// 元素3
        /// </summary>
        public J Item3 { get; set; }

    }

    /// <summary>
    /// 4个元素的 Tuple 类; , 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="J"></typeparam>
    /// <typeparam name="L"></typeparam>
    public class AdvancedTuple<T, K, J, L> : AdvancedTuple<T, K, J>
    {
        /// <summary>
        /// 元素4
        /// </summary>
        public L Item4 { get; set; }

    }

    /// <summary>
    /// 5个元素的 Tuple 类; , 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="J"></typeparam>
    /// <typeparam name="L"></typeparam>
    /// <typeparam name="M"></typeparam>
    public class AdvancedTuple<T, K, J,L, M> : AdvancedTuple<T, K, J, L >
    {
        /// <summary>
        /// 元素5
        /// </summary>
        public M Item5 { get; set; }

    }

    /// <summary>
    /// 6个元素的 Tuple 类; , 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="J"></typeparam>
    /// <typeparam name="L"></typeparam>
    /// <typeparam name="M"></typeparam>
    /// <typeparam name="N"></typeparam>
    public class AdvancedTuple<T, K, J, L,M, N> : AdvancedTuple<T, K, J, L, M>
    {
        /// <summary>
        /// 元素6
        /// </summary>
        public N Item6 { get; set; }

    }

    /// <summary>
    /// 7个元素的 Tuple 类; , 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="J"></typeparam>
    /// <typeparam name="L"></typeparam>
    /// <typeparam name="M"></typeparam>
    /// <typeparam name="N"></typeparam>
    /// <typeparam name="O"></typeparam>
    public class AdvancedTuple<T, K, J, L, M, N, O> : AdvancedTuple<T, K, J, L, M, N>
    {
        /// <summary>
        /// 元素7
        /// </summary>
        public O Item7 { get; set; }

    }

    /// <summary>
    /// 8个元素的 Tuple 类; , 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="J"></typeparam>
    /// <typeparam name="L"></typeparam>
    /// <typeparam name="M"></typeparam>
    /// <typeparam name="N"></typeparam>
    /// <typeparam name="O"></typeparam>
    /// <typeparam name="P"></typeparam>
    public class AdvancedTuple<T, K, J, L, M, N, O, P> : AdvancedTuple<T, K, J, L, M, N, O>
    {
        /// <summary>
        /// 元素8
        /// </summary>
        public P Item8 { get; set; }

    }
}
