using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace hongbao.CollectionExtension
{
    /// <summary>
    /// IEnumerable 的扩展类；
    /// </summary>
    public static class ICollectionExtension
    {
        

        /// <summary>
        /// 从 ICollection 中增加给定的元素；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="objEnum"></param>
        public static void AddRange<T>(this ICollection<T> iEnum, IEnumerable<T> objEnum)
        {
            foreach (var aenum in objEnum)
            {
                iEnum.Add(aenum);
            }
        }

        /// <summary>
        /// 从 ICollection 中移走给定的元素；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="objEnum"></param>
        public static void Remove<T>(this ICollection<T> iEnum, IEnumerable<T> objEnum)
        {
            foreach (var aenum in objEnum)
            {
                iEnum.Remove(aenum);
            }
        }

        /// <summary>
        /// 移除元素；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="objEnum"></param>
        public static void Remove<T>(this ICollection<T> iEnum, Func<T,bool> objEnum)
        {
            List<T> list = new List<T>();
            foreach (var aenum in iEnum)
            {
                if (objEnum(aenum)) list.Add(aenum);                
            }
            iEnum.Remove(list);
        }


        #region 转换成为另外一个数组
        /*/// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ary"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static T[] ToArray<T>(ICollection ary, Func<object, T> func)
        {
            T[] result = new T[ary.Count];
            int index = 0; 
            foreach (var obj in ary)
            {
                result[index++] = func(obj);
            }
            return result;
        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ary"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static T[] ToArray<T>(ICollection ary, Func<object, int, T> func)
        {
            T[] result = new T[ary.Count];
            int index = 0;
            foreach (var obj in ary)
            {
                result[index++] = func(obj, index);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="ary"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static T[] ToArray<T, K>(ICollection<K> ary, Func<K, T> func)
        {
            T[] result = new T[ary.Count];
            int index = 0;
            foreach (var obj in ary)
            {
                result[index++] = func(obj);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="ary"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static T[] ToArray<T, K>(ICollection<K> ary, Func<K, int, T> func)
        {
            T[] result = new T[ary.Count];
            int index = 0;
            foreach (var obj in ary)
            {
                result[index++] = func(obj, index);
            }
            return result;
        }
        #endregion

        /// <summary>
        /// 交换值； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="coll"></param>
        /// <param name="pos1"></param>
        /// <param name="pos2"></param>
        public static void Swap<T>(this IList<T> coll, int pos1, int pos2)
        {
            T element = coll[pos1];
            coll[pos1] = coll[pos2];
            coll[pos2] = element;
        }

        /// <summary>
        /// 将列表里面的元素随机重排；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="loopCount">随机重排次数，默认为2，越多越随机； </param>
        public static void RandomRearrange<T>(this IList<T> list, int loopCount=2)
        {
            var random = new Random(); //
            while (loopCount --  > 0)
            {
                int length = list.Count;
                while (length > 1)
                {
                    list.Swap(random.Next(0, length), length - 1);
                    length--;
                }
            }
        }
    }
}
