using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using hongbaoStandardExtension.CollectionExtension;

namespace hongbao.CollectionExtension
{
    /// <summary>
    /// 为数组提供扩展方法的静态类; 
    /// </summary>
    public static class ArrayUtil
    {

        /// <summary>
        /// 合并成一个数组;但是排除了重复项;
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static T[] Concat<T>(this T[] a, T[] b)
        {
            return a.Union(b).ToArray();
        }

        /// <summary>
        /// 当传入的比较函数为null时，构建默认的比较函数;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="compare"></param>
        private static void BuildCompare<T, K>(ref Func<T, K, bool> compare)
        {
            if (compare == null)
            {
                compare = (obja, objb) =>
                {
                    if ((obja == null) && (objb == null)) return true;
                    else if ((obja == null && objb != null) || (obja != null && objb == null))
                    {
                        return false;
                    }
                    return (obja.Equals(objb));
                };
            }
        }
        /// <summary>
        /// 用列表1 和  列表2 比较，获取不同部分:
        /// Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="srcList"></param>
        /// <param name="destList"></param>
        /// <param name="compare"></param>
        /// <returns>
        ///   Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        /// </returns>
        public static Different<T> Different<T>(this T[] srcList, T[] destList, Func<T, T, bool> compare = null)
        {
            Different<T> result = new Different<T>();
            if (ArrayUtil.IsNullOrEmpty(srcList) && ArrayUtil.IsNullOrEmpty(destList))
                return result;
            BuildCompare<T, T>(ref compare);
            result.Removed = srcList.Where(a => !destList.Any(b => compare(a, b))).ToList();
            result.Added = destList.Where(a => !srcList.Any(b => compare(a, b))).ToList();
            result.Unmodified = destList.Where(a => srcList.Any(b => compare(a, b))).ToList();
            return result;
        }

        /// <summary>
        /// 比较数组是否相等；(长度一致且相同位置的数组元素相等)
        /// 奇怪，数组没有比较元素是否相等的方法；(使用 默认的 equals 方法;
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static bool EqualsOtherArray<T>(this T[] array1, T[] array2, Func<T, T, bool> compare = null)
        {
            if (array1 == array2) return true;
            if (array1.Length == 0 && array2.Length == 0) return true;
            if (array1.Length != array2.Length) return false;
            BuildCompare<T, T>(ref compare);
            for (int index = 0; index < array2.Length; index++)
            {
                var obja = array1[index];
                var objb = array2[index];
                if (!compare(obja, objb))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 用给定的对象填充对象数组
        /// </summary>
        /// <param name="objs"></param>
        /// <param name="obj"></param>
        public static void Fill<T>(this T[] objs, T obj)
        {                        
            for (int i = 0; i < objs.Length; i++)
            {
                objs.SetValue(obj, i);         
            }
        }

        /// <summary>
        /// 判断数组是否具有不同项（不管顺序)，特别注意，返回值;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="srcList"></param>
        /// <param name="destList"></param>
        /// <param name="compare"></param>
        /// <returns> true 时，数组没有不同项，false时，数组有不同项;</returns>
        public static bool HaveDifferent<T>(this T[] srcList, T[] destList, Func<T, T, bool> compare = null)
        {
            if (ArrayUtil.IsNullOrEmpty(srcList) && ArrayUtil.IsNullOrEmpty(destList))
                return false;
            BuildCompare<T, T>(ref compare);
            Different<T> result = new Different<T>();
            if (srcList.Any(a => !destList.Any(b => compare(a, b)))) return false;
            if (destList.Any(a => !srcList.Any(b => compare(a, b)))) return false;
            return true;
        }
        /// <summary>
        /// 查找元素在数组中的位置； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ary"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int IndexOf<T>(this T[] ary, T element, Func<T, T, bool> compare = null)
        {
            BuildCompare<T, T>(ref compare);
            for (var index=0; index<ary.Length; index++)
            {
                T a = ary[index];             
                if (compare(a, element))
                    return index;
            }
            return -1; 
        }

        /// <summary>
        /// 是否是null或者空数组;
        /// </summary>
        /// <param name="anyPrivileges"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(T[] anyPrivileges)
        {
            return anyPrivileges == null || anyPrivileges.Length == 0;
        }
        /// <summary>
        /// 将数组拼接成一个字符串
        /// </summary>
        /// <param name="objects">数组</param>
        /// <returns></returns>
        public static string Join(this Array objects)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var s in objects) sb.Append(s);
            return sb.ToString();
        }

        /// <summary>
        /// 合并字符串数组,返回合并后的合并后数组,重复元素一并添加；
        /// </summary>
        /// <param name="ary1"></param>
        /// <param name="arys"></param>
        /// <returns></returns>
        public static T[] Merge<T>(this T[] ary1, T[] arys)
        {
             if (ary1 == null && arys == null) return new T[] { };
            if (ary1.Length == 0 && arys.Length == 0) return new T[] { };
            T[] result = new T[ary1.Length + arys.Length];            
            System.Array.Copy(ary1, result, ary1.Length);
            System.Array.Copy(arys, 0, result, ary1.Length, arys.Length);
            return result;
        }

        /// <summary>
        /// 返回数组相减后的数组
        /// </summary>
        /// <param name="ary1"></param>
        /// <param name="ary2"></param>
        /// <returns></returns>
        public static T[] Minus<T,K>(this T[] ary1, K[] ary2, Func<T, K, bool> compare = null)
        {
            BuildCompare<T, K>(ref compare);
            List<T> xList = new List<T>(); int i = 0;
            for (; i < ary1.Length; i++)
            {
                bool find = false;
                for (int j = 0; j < ary2.Length; j++)
                {
                    if (compare(ary1[i], ary2[j]))
                    {
                        find = true;
                        break;
                    }
                }
                if (!find)     xList.Add(ary1[i]);
            }
            return xList.ToArray();
        }
        



        // <summary>
        // 将数组拼接成一个字符串,已经改为放到 IEnumerableExtension 类中：
        // </summary>
        // <param name="objects"></param>
        // <param name="joinStr"></param>
        // <returns></returns>
        /*public static string Join(this Array objects, string joinStr)
        {
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < objects.Length; index++)
            {
                sb.Append(objects.GetValue(index));
                if (index != objects.Length - 1) sb.Append(joinStr);
            }
            string result = sb.ToString();
            return result;
        }*/


        ///// <summary>
        ///// 将数组拼接成一个字符串
        ///// </summary>
        ///// <param name="objects"></param>
        ///// <param name="stringFunc"></param>
        ///// <param name="joinStr"></param>
        ///// <returns></returns>
        //public static string Join<T>(this T[] objects, Func<T,string> stringFunc, string joinStr = ",")
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int index = 0; index < objects.Length; index++)
        //    {
        //        sb.Append(stringFunc(objects[index]));
        //        if (index != objects.Length - 1) sb.Append(joinStr);
        //    }
        //    string result = sb.ToString();
        //    return result;
        //}

        /// <summary>
        /// 得到一个子数组；
        /// </summary>
        /// <typeparam name="T">泛型的类型</typeparam>
        /// <param name="objects">原数组</param>
        /// <param name="beginIndex">起始位置</param>
        /// <returns></returns>
        public static T[] SubArray<T>(this T[] objects, int beginIndex)
        {
              return SubArray<T>(objects, beginIndex, -1);
        }


        /// <summary>
        /// 得到一个子数组；
        /// </summary>
        /// <typeparam name="T">泛型的类型</typeparam>
        /// <param name="objects">原数组</param>
        /// <param name="beginIndex">起始位置</param>
        /// <param name="count">子数组元素数目，-1表示从起始位置直到结束；</param>
        /// <returns></returns>
        public static T[] SubArray<T>(this T[] objects, int beginIndex, int count )
        {
            T[] result = new T[ count<0? objects.Length - beginIndex : count ];
            for (int i = beginIndex; i < objects.Length &&  i < beginIndex + result.Length; i++)
            {
                result[i - beginIndex] = objects[i];
            }
            return result;
        }

        /// <summary>
        /// 获得整数数组, 从  begin 到  end; 包含 end;
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int[] GetIntArray(int begin, int end)
        {
            if (end < begin) return new int[] { };
            int[] array = new int[end - begin + 1];
            for (int i = begin; i <= end; i++)
            {
                array[i - begin] = i;
            }
            return array;
        }

        #region 转换成为另外一个数组
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="ary"></param>
        ///// <param name="func"></param>
        ///// <returns></returns>
        //public static T[] ToArray<T>(this T[] ary, Func<object, T> func)
        //{
        //    T[] result = new T[ary.Length];
        //    for (var index=0; index<result.Length; index++)
        //    {
        //        result[index] = func(ary.GetValue(index));
        //    }
        //    return result;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="ary"></param>
        ///// <param name="func"></param>
        ///// <returns></returns>
        //public static T[] ToArray<T>(Array ary, Func<object,int, T> func)
        //{
        //    T[] result = new T[ary.Length];
        //    for (var index = 0; index < result.Length; index++)
        //    {
        //        result[index] = func(ary.GetValue(index), index);
        //    }
        //    return result;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <typeparam name="K"></typeparam>
        ///// <param name="ary"></param>
        ///// <param name="func"></param>
        ///// <returns></returns>
        //public static T[] ToArray<T,K>(K[] ary, Func<K, T> func)
        //{
        //    T[] result = new T[ary.Length];
        //    for (var index = 0; index < result.Length; index++)
        //    {
        //        result[index] = func(ary[index]);
        //    }
        //    return result;
        //}

        /// <summary>
        /// 转换为另外一个数组;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="ary"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static K[] ToArray<T, K>(T[] ary, Func<T,int, K> func)
        {
            return ary.Select((a, index) => func(a, index)).ToArray();
        }
        #endregion
    }
}
