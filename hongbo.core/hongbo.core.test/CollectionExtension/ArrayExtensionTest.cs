using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using hongbaoStandardExtension.CollectionExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hongbao.CollectionExtension
{
    /// <summary>
    /// 为数组提供扩展方法的静态类; 
    /// </summary>
    [TestClass]
    public class ArrayExtensionTest
    {
        /// <summary>
        /// 包含有 a 和 b 2个元素的数组
        /// </summary>
        string[] array_a_b = new string[] { "a", "b" };
        /// <summary>
        /// 包含有 a 和 d 2个元素的数组
        /// </summary>
        string[] array_a_d = new string[] { "a", "d" };
        /// <summary>
        /// 包含有 b  和 a 2个元素的数组
        /// </summary>
        string[] array_b_a = new string[] { "b", "a" };
        /// <summary>
        /// 字符串的比较方法
        /// </summary>
        Func<string, string, bool> simpleCompare = (a, b) => a == b;

        /// <returns></returns>
        [TestMethod]
        public  void HaveDifferent()
        {
            Assert.IsFalse(ArrayUtil.HaveDifferent(array_a_b, array_a_d), "数组有不同项");
            Assert.IsTrue(ArrayUtil.HaveDifferent(array_a_b, array_b_a), "数组没有不同项");

            Assert.IsFalse(ArrayUtil.HaveDifferent(array_a_b, array_a_d, simpleCompare), "数组有不同项");
            Assert.IsTrue(ArrayUtil.HaveDifferent(array_a_b, array_b_a, simpleCompare), "数组没有不同项");
        }


        [TestMethod]
        public void Different()
        {
            var result = ArrayUtil.Different(array_a_b, array_a_d, simpleCompare);
            Assert.IsTrue(result.Unmodified.Count == 1 && result.Unmodified[0] == "a", "元素 a 不变");
            Assert.IsTrue(result.Removed.Count == 1 && result.Removed[0] == "b", "元素 b 删除");
            Assert.IsTrue(result.Added.Count == 1 && result.Added[0] == "d", "元素 d 新增");

            result = ArrayUtil.Different(array_a_d, array_a_b,  simpleCompare);
            Assert.IsTrue(result.Unmodified.Count == 1 && result.Unmodified[0] == "a", "元素 a 不变");
            Assert.IsTrue(result.Removed.Count == 1 && result.Removed[0] == "d", "元素 b 删除");
            Assert.IsTrue(result.Added.Count == 1 && result.Added[0] == "b", "元素 d 新增");
        }

        [TestMethod]
        public void Concat()
        {
            var result = ArrayUtil.Concat(array_a_b, array_a_d);
            Assert.IsTrue(result.Join(",") == "a,b,d", "合并后数组应该为 a,b,d");

            result = ArrayUtil.Concat(array_a_d, array_a_b);
            Assert.IsTrue(result.Join(",") == "a,d,b", "合并后数组应该为 a,d,b");
        }

        [TestMethod]
        public void IsNullOrEmpty()
        {
            int[] nullT = null;
            int[] nullArray = new int[] { };
            Assert.IsTrue(ArrayUtil.IsNullOrEmpty(nullT), "null 应该返回 true ");
            Assert.IsTrue(ArrayUtil.IsNullOrEmpty(nullArray), "空数组 应该返回 true ");
            Assert.IsFalse(ArrayUtil.IsNullOrEmpty(array_a_b), "非空数组 应该返回 false ");
        }

        [TestMethod]
        public void EqualsOtherArray()
        {
            Assert.IsFalse(ArrayUtil.EqualsOtherArray(array_a_b, array_a_d), "数组有不同项");
            Assert.IsFalse(ArrayUtil.EqualsOtherArray(array_a_b, array_b_a), "数组没有不同项");

            Assert.IsTrue(ArrayUtil.EqualsOtherArray(array_a_b, array_a_b), "数组有不同项");
            Assert.IsTrue(ArrayUtil.EqualsOtherArray(array_b_a, array_b_a), "数组没有不同项");
        }

        /// <summary>
        /// 用给定的对象填充对象数组
        /// </summary>
        /// <param name="objs"></param>
        /// <param name="obj"></param>
        [TestMethod]
        public void Fill()
        {
            var ary = new int[10];
            ArrayUtil.Fill(ary, 20);
            Assert.IsTrue(ary.Sum() == 200);
        }

        /// <summary>
        /// 查找元素在数组中的位置； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ary"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        [TestMethod]
        public void IndexOf()
        {
            Assert.IsTrue(ArrayUtil.IndexOf(array_a_b, array_a_b[0]) == 0, "查找第0号元素应该返回0");
            Assert.IsTrue(ArrayUtil.IndexOf(array_a_b, array_a_b[1]) == 1, "查找第0号元素应该返回0");
            Assert.IsTrue(ArrayUtil.IndexOf(array_a_b, "x") <0, "查找不存在的元素应该返回 -1 ");
        }

        /// <summary>
        /// 合并字符串数组,返回合并后的合并后数组,重复元素一并添加；
        /// </summary>
        /// <param name="ary1"></param>
        /// <param name="arys"></param>
        /// <returns></returns>
        [TestMethod]
        public void Merge()
        {
            var result = ArrayUtil.Merge(array_a_b, array_a_d);
            Assert.IsTrue(result.Join(",") == "a,b,a,d", "合并后数组应该为 a,b,a,d");

            result = ArrayUtil.Merge(array_a_d, array_a_b);
            Assert.IsTrue(result.Join(",") == "a,d,a,b", "合并后数组应该为 a,d,a,b");
        }

        /// <summary>
        /// 返回数组相减后的数组
        /// </summary>
        /// <param name="ary1"></param>
        /// <param name="ary2"></param>
        /// <returns></returns>
        [TestMethod]
        public void Minus()
        {
            var result = ArrayUtil.Minus(array_a_b, array_a_d);
            Assert.IsTrue(result.Length == 1 && result.Join(",") == "b", "Minus后数组应该为 b");

            result = ArrayUtil.Minus(array_a_d, array_a_b);
            Assert.IsTrue(result.Length == 1 && result.Join(",") == "d", "Minus后数组应该为 d");

            result = ArrayUtil.Minus(array_a_d, array_a_b, (a,b) => true);
            Assert.IsTrue(result.Length == 0, "Minus后数组应该为 空数组");
        }

        /// <summary>
        /// 将数组拼接成一个字符串
        /// </summary>
        /// <param name="objects">数组</param>
        /// <returns></returns>
        [TestMethod]
        public void Join()
        {
            Assert.IsTrue(ArrayUtil.Join(array_a_b)=="ab", "Join后数组应该为 ab");
            Assert.IsTrue(ArrayUtil.Join(array_a_d) == "ad", "Join后数组应该为 ad");
        }

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
        [TestMethod]
        public void SubArray()
        {
            var sub = ArrayUtil.SubArray(array_a_b, 0);
            Assert.IsTrue(ArrayUtil.EqualsOtherArray(sub, array_a_b));

            sub = ArrayUtil.SubArray(array_a_b, 1);
            var sub1 = ArrayUtil.SubArray(array_a_d, 1);
            Assert.IsFalse(ArrayUtil.EqualsOtherArray(sub, sub1));
        }


        /// <summary>
        /// 得到一个子数组；
        /// </summary>
        /// <typeparam name="T">泛型的类型</typeparam>
        /// <param name="objects">原数组</param>
        /// <param name="beginIndex">起始位置</param>
        /// <param name="count">子数组元素数目，-1表示从起始位置直到结束；</param>
        /// <returns></returns>
        [TestMethod]
        public void SubArrayWithCount()
        {
            var sub = ArrayUtil.SubArray(array_a_b, 0, array_a_b.Length);
            Assert.IsTrue(ArrayUtil.EqualsOtherArray(sub, array_a_b));

            sub = ArrayUtil.SubArray(array_a_b, 1, 1);
            var sub1 = ArrayUtil.SubArray(array_a_d, 1, 1);
            Assert.IsFalse(ArrayUtil.EqualsOtherArray(sub, sub1));
        }

        /// <summary>
        /// 获得整数数组, 从  begin 到  end; 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        [TestMethod]
        public void GetIntArray()
        {
            var ary = ArrayUtil.GetIntArray(1, 6);
            Assert.IsTrue(ary.Join() == "123456");
        }

        #region 转换成为另外一个数组
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ary"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        [TestMethod]
        public void ToArray()
        {
            var ary = ArrayUtil.ToArray<string, int>(array_a_b, (a, index) => a.ToCharArray()[0] - 'a');
            Assert.IsTrue(ary.Join() == "01");
        }

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

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <typeparam name="K"></typeparam>
        ///// <param name="ary"></param>
        ///// <param name="func"></param>
        ///// <returns></returns>
        //public static T[] ToArray<T, K>(K[] ary, Func<K,int, T> func)
        //{
        //    T[] result = new T[ary.Length];
        //    for (var index = 0; index < result.Length; index++)
        //    {
        //        result[index] = func(ary[index], index);
        //    }
        //    return result;
        //}
        #endregion
    }
}
