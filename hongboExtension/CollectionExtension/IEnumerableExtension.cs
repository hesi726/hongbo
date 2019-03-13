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
    public static class IEnumerableExtension
    {

        /// <summary>
        /// 对 IEnumerable<T> 进行分批操作;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="batchCount"></param>
        /// <param name="batchAction"></param>
        public static void Batch<T>(this IEnumerable<T> list, int batchCount, Action<IEnumerable<T>> batchAction)
        {
            var enumCount = list.Count();
            var cnt = enumCount / batchCount;
            if (enumCount % batchCount > 0) cnt = cnt + 1;
            for (var index = 0; index < cnt; index++)  //获取所有昨天给设备分配的场景列表;
            {
                var batchList = list.Skip(index * batchCount).Take(batchCount).ToList();
                batchAction(batchList);
            }
        }

        #region 笛卡尔交集
        /// <summary>
        /// 笛卡尔交集;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="kEnum"></param>
        /// <returns></returns>
        public static IEnumerable<T[]> Dicarl<T>(this IEnumerable<T> iEnum, IEnumerable<T> kEnum)
        {
            foreach (T t in iEnum)
            {
                foreach (T k in kEnum)
                {
                    yield return new T[] { t, k };
                }
            }
        }
        /// <summary>
        /// 笛卡尔交集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="kEnum"></param>
        /// <returns></returns>
        public static IEnumerable<Tuple<T,K>> Dicarl<T,K>(this IEnumerable<T> iEnum, IEnumerable<K> kEnum)
        {
            foreach (T t in iEnum)
            {
                foreach (K k in kEnum)
                {
                    yield return Tuple.Create(t,k);
                }
            }
        }
        /// <summary>
        /// 笛卡尔交集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="kEnum"></param>
        /// <param name="jEnum"></param>
        /// <returns></returns>
        public static IEnumerable<Tuple<T, K, J>> Dicarl<T, K,J>(
            this IEnumerable<T> iEnum, 
            IEnumerable<K> kEnum,
            IEnumerable<J> jEnum)
        {
            foreach (T t in iEnum)
            {
                foreach (K k in kEnum)
                {
                    foreach (J j in jEnum)
                    {
                        yield return Tuple.Create(t, k, j);
                    }
                }
            }
        }
        /// <summary>
        /// 笛卡尔交集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="kEnum"></param>
        /// <param name="jEnum"></param>
        /// <param name="xEnum"></param>
        /// <returns></returns>
        public static IEnumerable<Tuple<T, K, J,X>> Dicarl<T, K, J,X>(
            this IEnumerable<T> iEnum,
            IEnumerable<K> kEnum,
            IEnumerable<J> jEnum,
            IEnumerable<X> xEnum)
        {
            foreach (T t in iEnum)
            {
                foreach (K k in kEnum)
                {
                    foreach (J j in jEnum)
                    {
                        foreach (X x in xEnum)
                        {
                            yield return Tuple.Create(t, k, j, x);
                        }
                    }
                }
            }
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <typeparam name="Y"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="kEnum"></param>
        /// <param name="jEnum"></param>
        /// <param name="xEnum"></param>
        /// <param name="yEnum"></param>
        /// <returns></returns>
        public static IEnumerable<Tuple<T, K, J, X, Y>> Dicarl<T, K, J, X, Y>(
            this IEnumerable<T> iEnum,
            IEnumerable<K> kEnum,
            IEnumerable<J> jEnum,
            IEnumerable<X> xEnum,
            IEnumerable<Y> yEnum
            )
        {
            foreach (T t in iEnum)
            {
                foreach (K k in kEnum)
                {
                    foreach (J j in jEnum)
                    {
                        foreach (X x in xEnum)
                        {
                            foreach (Y y in yEnum)
                            {
                                yield return Tuple.Create(t, k, j, x, y);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 笛卡尔交集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <typeparam name="Y"></typeparam>
        /// <typeparam name="Z"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="kEnum"></param>
        /// <param name="jEnum"></param>
        /// <param name="xEnum"></param>
        /// <param name="yEnum"></param>
        /// <param name="zEnum"></param>
        /// <returns></returns>
        public static IEnumerable<Tuple<T, K, J, X, Y, Z>> Dicarl<T, K, J, X, Y, Z>(
            this IEnumerable<T> iEnum,
            IEnumerable<K> kEnum,
            IEnumerable<J> jEnum,
            IEnumerable<X> xEnum,
            IEnumerable<Y> yEnum,
            IEnumerable<Z> zEnum
            )
        {
            foreach (T t in iEnum)
            {
                foreach (K k in kEnum)
                {
                    foreach (J j in jEnum)
                    {
                        foreach (X x in xEnum)
                        {
                            foreach (Y y in yEnum)
                            {
                                foreach (Z z in zEnum)
                                {
                                    yield return Tuple.Create(t, k, j, x, y, z);
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 笛卡尔交集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="J"></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <typeparam name="Y"></typeparam>
        /// <typeparam name="Z"></typeparam>
        /// <typeparam name="H"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="kEnum"></param>
        /// <param name="jEnum"></param>
        /// <param name="xEnum"></param>
        /// <param name="yEnum"></param>
        /// <param name="zEnum"></param>
        /// <param name="hEnum"></param>
        /// <returns></returns>
        public static IEnumerable<Tuple<T, K, J, X, Y, Z, H>> Dicarl<T, K, J, X, Y, Z, H>(
            this IEnumerable<T> iEnum,
            IEnumerable<K> kEnum,
            IEnumerable<J> jEnum,
            IEnumerable<X> xEnum,
            IEnumerable<Y> yEnum,
            IEnumerable<Z> zEnum,
            IEnumerable<H> hEnum
            )
        {
            foreach (T t in iEnum)
            {
                foreach (K k in kEnum)
                {
                    foreach (J j in jEnum)
                    {
                        foreach (X x in xEnum)
                        {
                            foreach (Y y in yEnum)
                            {
                                foreach (Z z in zEnum)
                                {
                                    foreach (H h in hEnum)
                                    {
                                        yield return Tuple.Create(t, k, j, x, y, z, h);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
       
        #endregion
        /// <summary>
        /// 转换后再进行 Distinct;
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<TTarget> Distinct<TSource, TTarget>(this IEnumerable<TSource> source,
            Func<TSource, TTarget> func)
        {
            return source.Select((a) => func(a)).Distinct();
        }
        /// <summary>
        /// 将对象转换为另外的对象进行比较，但是返回原始的对象的 Distinct;
        /// 例如, { Age=18, Name='daiwei'}, { Age=18, Name='Zhao'} 根据 (x)=>x.Age 进行 Distinct， 
        /// 只返回 { Age  = 18, Name="daiwei" } 这一个对象； 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="source"></param>
        /// <param name="convertFunc"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TTarget>(this IEnumerable<TSource> source,
            Func<TSource, TTarget> convertFunc)
        {
            return source.GroupBy(convertFunc)
                    .Select(grp => grp.First());
            //List<TSource> sourceList = new List<TSource>();
            //foreach (var x in source)
            //{
            //    if (!sourceList.Any(b => (convertFunc(b).Equals(convertFunc(x)))))
            //    {
            //        sourceList.Add(x);
            //    }
            //}
            //return sourceList;
        }
        /// <summary>
        /// 排除;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="kEnum"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<T> Except<T, K>(this IEnumerable<T> iEnum,
            IEnumerable<K> kEnum, Func<T, K, bool> func)
        {
            foreach (var t in iEnum)
            {
                if (!kEnum.Any((a) => func(t, a)))
                    yield return t;
            }
        }

        /// <summary>
        /// 根据给定函数查找项目;但是查找过程中不能修改 iEnum;
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static object Find(this System.Collections.IEnumerable iEnum, Func<object, int, bool> func)
        {
            int index = 0;
            foreach(var item in iEnum)  // 不可以修改 iEnum, 当使用 foreach 语法时
            {
                if (func(item, index)) return item;
                index++;
            }
            return null;
        }

        #region 利用foreach方法对于进行顺序处理
        /// <summary>
        /// 对于IEnumerable里面的每一个元素，执行给定的动作；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="actionT"></param>
        public static void ForEach<T>(this IEnumerable<T> iEnum, Action<T> actionT)
        {
            foreach (var aT in iEnum)
            {
                actionT(aT);
            }
        }

        /// <summary>
        /// 对于IEnumerable里面的每一个元素，执行给定的动作；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="actionT"></param>
        public static void ForEach<T>(this IEnumerable<T> iEnum, Action<T,int> actionT)
        {
            int index = 0;
            foreach (var aT in iEnum)
            {
                actionT(aT, index++);
            }
        }

        /// <summary>
        /// 对于IEnumerable里面的每一个元素，执行给定的操作，
        /// 但如果该操作返回 false,则不处理后续元素，本函数总会处理第0个元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="continueFunc"></param>
        public static void ForEach<T>(this IEnumerable<T> iEnum, Func<T, bool> continueFunc)
        {
            foreach (var aT in iEnum)
            {
                var result = continueFunc(aT);
                if (!result) return;
            }
        }

        /// <summary>
        /// 对于IEnumerable里面的每一个元素，执行给定的操作，
        /// 但如果该操作返回 false,则不处理后续元素，本函数总会处理第0个元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="continueFunc"></param>
        public static void ForEach<T>(this IEnumerable<T> iEnum, Func<T, int,  bool> continueFunc)
        {
            int index = 0;
            foreach (var aT in iEnum)
            {
                var result = continueFunc(aT, index++);
                if (!result)
                    return;
            }
        }

        /// <summary>
        /// 对于IEnumerable里面的每一个元素，执行给定的动作；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="actionT"></param>
        public static void ForEach(this IEnumerable iEnum, Action<object> actionT)
        {
            foreach (var aT in iEnum)
            {
                actionT(aT);
            }
        }

        /// <summary>
        /// 对于IEnumerable里面的每一个元素，执行给定的动作；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="actionT"></param>
        public static void ForEach(this IEnumerable iEnum, Action<object,int> actionT)
        {
            int index = 0;
            foreach (var aT in iEnum)
            {
                actionT(aT, index++);
            }
        }

        /// <summary>
        /// 对于IEnumerable里面的每一个元素，执行给定的操作，
        /// 但如果该操作返回 false,则不处理后续元素，本函数总会处理第0个元素
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="continueFunc"></param>
        public static void ForEach(this IEnumerable iEnum, Func<object, bool> continueFunc)
        {
            foreach (var aT in iEnum)
            {
                var result = continueFunc(aT);
                if (!result) return;
            }
        }

        /// <summary>
        /// 对于IEnumerable里面的每一个元素，执行给定的操作，
        /// 但如果该操作返回 false,则不处理后续元素，
        /// 注意：本函数总会处理第0个元素；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="continueFunc"></param>
        public static void ForEach(this IEnumerable iEnum, Func<object, int, bool> continueFunc)
        {
            int index = 0;
            foreach (var aT in iEnum)
            {
                var result = continueFunc(aT, index++);
                if (!result) return;
            }
        }
        #endregion



        /// <summary>
        /// 交集;
        /// 比标准的 Intersect 要慢， 因为 标准的 Intersect 将首先使用 hashcode 比较，然后再使用 比较器  比较;
        /// 注意， [a,b] 和 [a,d] 使用 如下的 func来进行比价时 (x,y) => x!=y 来进行 Intersect 时，
        /// 还是会反hi [a, b], 因为 [a, d] 中存在不为 a 的元素;
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="kEnum"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<T> Intersect<T>(this IEnumerable<T> iEnum,
            IEnumerable<T> kEnum, Func<T, T, bool> func)
        {
            return iEnum.IntersectWithCompare(item => kEnum.Any(k => func(item, k)));
            //{
            
            //})
            //foreach (var i in iEnum)
            //{
            //    if (kEnum.Any(k => func(i, k))) yield return i;
            //}
        }
        /// <summary>
        /// 和给定的枚举利用给定的判断函数进行 Intersect 操作，返回 Intersect操作后的结果； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="compareFunc"></param>
        /// <returns></returns>
        public static IEnumerable<T> IntersectWithCompare<T>(
            this IEnumerable<T> source,
            Func<T, bool> compareFunc)
        {
            // var intersectList = new List<T>();
            foreach (var key in source)
            {
                if (compareFunc(key))
                {
                    yield return key;
                }
            };
        }

        /// <summary>
        /// 寻找对象的索引；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="compareFunc"></param>
        /// <returns></returns>
        public static int IndexOf<T>(this IEnumerable<T> iEnum, Func<T, bool> compareFunc)
        {
            var index = 0;
            foreach (var el in iEnum)
            {
                if (compareFunc(el))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        /// <summary>
        /// 将 IEnumerable里面的每一个元素，拼凑成一个字符串返回；返回形如 a,b 形式的字符串
        /// 如果枚举中不包含任何元素，返回空字符串;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="joinString"></param>
        public static string Join<T>(this IEnumerable<T> iEnum, string joinString)
        {
            if (iEnum == null) return null;
            //但是注意，如果序列不包含任何元素，返回null;
            StringBuilder sb = new StringBuilder();
            //bool contains = false;
            foreach (var aT in iEnum)
            {
                if (sb.Length == 0) sb.Append(aT == null ? "" : aT.ToString());
                else sb.Append(joinString).Append(aT == null ? "" : aT.ToString());
            }
            //if (!contains) return null;
            return sb.ToString();
        }
        ///// <summary>
        ///// 寻找对象的索引；
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="iEnum"></param>
        ///// <param name="element"></param>
        ///// <returns></returns>
        //public static int IndexOf<T>(this IEnumerable<T> iEnum, T element)
        //{
        //    var index = 0;
        //    foreach (var el in iEnum)
        //    {
        //        if (el == null && element == null) return index;
        //        else if (el != null && element == null) return -1;
        //        else if (el == null && element != null) return -1;
        //        else if (el.Equals(element))
        //        {
        //            return index;
        //        }
        //        index++;
        //    }
        //    return -1;
        //}

        /// <summary>
        /// 将 IEnumerable 转换成数组； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="funcT"></param>
        /// <returns></returns>
        public static IEnumerable<T> Select<T>(this IEnumerable iEnum, Func<object, int, T> funcT)
        {
            List<T> resultList = new List<T>();
            int index = 0;
            foreach (var x in iEnum)
            {
                yield return funcT(x, index++);
            }
        }

        /// <summary>
        /// 将 IEnumerable 转换成数组； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="funcT"></param>
        /// <returns></returns>
        public static IEnumerable<T> Select<T>(this IEnumerable iEnum, Func<object, T> funcT)
        {
            List<T> resultList = new List<T>();
            foreach (var x in iEnum)
            {
                yield return funcT(x);
            }
        }

        /// <summary>
        /// 将 IEnumerable 转换成数组； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="funcT"></param>
        /// <returns></returns>
        public static T[] ToArray<T>(this IEnumerable iEnum, Func<object,int, T> funcT)
        {
            return iEnum.Select(funcT).ToArray();
        }


       
        /// <summary>
        /// 将 IEnumerable 转换成数组； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="funcT"></param>
        /// <returns></returns>
        public static T[] ToArray<T>(this IEnumerable iEnum, Func<object,T> funcT)
        {
            return iEnum.Select(funcT).ToArray();
        }

        /// <summary>
        /// 将 IEnumerable 转换成数组； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="funcT"></param>
        /// <returns></returns>
        public static T[] ToArray<T,K>(this IEnumerable<K> iEnum, Func<K, T> funcT)
        {
            return iEnum.Select(a => funcT(a)).ToArray();
        }

        /// <summary>
        /// 将 遍历 的对象转换为字典； 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="source"></param>
        /// <param name="keyFunc"></param>
        /// <param name="valueFunc"></param>
        /// <returns></returns>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source,
            Func<TSource, int, TKey> keyFunc)
        {
            return ToDictionary<TSource, TKey, TSource>(source, keyFunc, (item, index)=>item);
        }


        /// <summary>
        /// 将 遍历 的对象转换为字典； 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="source"></param>
        /// <param name="keyFunc"></param>
        /// <param name="valueFunc"></param>
        /// <returns></returns>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source,
            Func<TSource, int, TKey> keyFunc, 
            Func<TSource, int, TElement> valueFunc)
        {
            //return source.GroupBy((item, index)=>keyFunc(item, index))
            //    .ToDictionary(item => item.Key, item => item.First()); 
            Dictionary<TKey, TElement> result = new Dictionary<TKey, TElement>();
            int index = 0;
            foreach (var obj in source)
            {
                var key = keyFunc(obj, index);
                var value = valueFunc(obj, index);
                index++;
                result.FindOrInsert(key, value);
               // result[key] = value;
            }
            return result;
        }


        

            

        /// <summary>
        /// 将枚举对象转换为SortedList对象； 
        /// </summary>
        public static SortedList<TKey
            , K> ToSortedList<TKey
            , K>(this IEnumerable<K> iEnum, Func<K, TKey
            > keyFunc)
        {
            return ToSortedList<K, TKey
            , K>(iEnum, keyFunc, item => item);
        }

        /// <summary>
        /// 将枚举对象转换为SortedList对象； 
        /// </summary>
        public static SortedList<K, L> ToSortedList<T, K, L>(this IEnumerable<T> iEnum, Func<T, K> keyFunc, Func<T, L> valueFunc)
        {
            SortedList<K, L> sort = new SortedList<K, L>();
            iEnum.ForEach((a) =>
            {
                var t = keyFunc(a);
                var v = valueFunc(a);
                sort[t] = v;
            });
            return sort;
        }
        #region ToString方法
        /// <summary>
        /// 将 IEnumerable里面的每一个元素，拼凑成一个字符串返回；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="joinString">间隔字符串</param>
        public static string ToString(this IEnumerable iEnum, string joinString)
        {
            StringBuilder sb = new StringBuilder(); 
            foreach (var aT in iEnum)
            {
                if (sb.Length == 0) sb.Append(aT == null ? "" : aT.ToString());
                else  sb.Append(joinString).Append(aT == null ? "" : aT.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// 将 IEnumerable里面的每一个元素，拼凑成一个字符串返回；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="joinString"></param>
        public static string ToString<T>(this IEnumerable<T> iEnum, string joinString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var aT in iEnum)
            {
                if (aT == null) continue;
                if (sb.Length == 0) sb.Append(aT == null ? "" : aT.ToString());
                else sb.Append(joinString).Append(aT == null ? "" : aT.ToString());
            }            
            return sb.ToString();
        }

        

        /// <summary>
        /// 将 IEnumerable里面的每一个元素，拼凑成一个字符串返回；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="toStringFunc"></param>
        /// <param name="joinString"></param>
        public static string ToString<T>(this IEnumerable<T> iEnum, Func<T,string> toStringFunc, string joinString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var aT in iEnum)
            {
                if (sb.Length == 0) sb.Append(toStringFunc(aT));
                else sb.Append(joinString).Append(toStringFunc(aT));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 将 IEnumerable里面的每一个元素，拼凑成一个字符串返回；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="toStringFunc"></param>
        /// <param name="joinString"></param>
        public static string ToString<T>(this IEnumerable<T> iEnum, Func<T,int, string> toStringFunc, string joinString)
        {
            StringBuilder sb = new StringBuilder();
            var index = 0; 
            foreach (var aT in iEnum)
            {
                if (sb.Length == 0) sb.Append(toStringFunc(aT, index++));
                else sb.Append(joinString).Append(toStringFunc(aT, index++));
            }
            return sb.ToString();
        }
        #endregion

        

        #region 扩展Sum方法
        /// <summary>
        /// 计算 IEnumerable 中元素多个属性的和 ;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static double[] Sum<T>(this IEnumerable<T> iEnum, Func<T,double[]> func)
        {
            double[] result = null;
            foreach(var xx in iEnum)
            {
                var row = func(xx);
                if (result == null) result = row;
                else
                {
                    row.ForEach((async, index) =>
                    {
                        result[index] += async;
                    });
                }
            }
            return result;
        }

        /// <summary>
        /// 计算 IEnumerable 中元素多个属性的和 ;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static long[] Sum<T>(this IEnumerable<T> iEnum, Func<T, long[]> func)
        {
            long[] result = null;
            foreach (var xx in iEnum)
            {
                var row = func(xx);
                if (result == null) result = row;
                else
                {
                    row.ForEach((async, index) =>
                    {
                        result[index] += async;
                    });
                }
            }
            return result;
        }

        /// <summary>
        /// 计算 IEnumerable 中元素多个属性的和 ;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static decimal[] Sum<T>(this IEnumerable<T> iEnum, Func<T, decimal[]> func)
        {
            decimal[] result = null;
            foreach (var xx in iEnum)
            {
                var row = func(xx);
                if (result == null) result = row;
                else
                {
                    row.ForEach((async, index) =>
                    {
                        result[index] += async;
                    });
                }
            }
            return result;
        }

        /// <summary>
        /// 计算 IEnumerable 中元素多个属性的和 ;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static int[] Sum<T>(this IEnumerable<T> iEnum, Func<T, int[]> func)
        {
            int[] result = null;
            foreach (var xx in iEnum)
            {
                var row = func(xx);
                if (result == null) result = row;
                else
                {
                    row.ForEach((async, index) =>
                    {
                        result[index] += async;
                    });
                }
            }
            return result;
        }
        #endregion

        
        /// <summary>
        /// Union 某1个元素;
        /// 特别注意，类似于这样的 Union 时，
        /// new object[]{ 1,2}.Union(new object[]{3,4} 会得到这样的结果
        /// new object[]{ 1,2, new object[]{3,4}} 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static IEnumerable<T> Union<T>(this IEnumerable<T> iEnum, T element)
        {
            foreach (var el in iEnum)
            {
                yield return el;
            }
            yield return element;
        }




    }

}
