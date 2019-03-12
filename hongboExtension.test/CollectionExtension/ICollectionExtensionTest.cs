using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.CollectionExtension;
using System.Linq;

namespace hongboExtensionsTests.CollectionExtensionTest
{

    /// <summary>
    /// IEnumerable 的扩展类；
    /// </summary>
    [TestClass]
    public class ICollectionExtensionTest
    {


        /// <summary>
        /// 从 ICollection 中增加给定的元素；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="objEnum"></param>
        [TestMethod]
        public void AddRange()
        {
            ICollection<int> iEnum = new List<int>();
            iEnum.AddRange(new[] { 1, 2 });
            Assert.IsTrue(iEnum.Sum() == 3);
        }

        ///// <summary>
        ///// 从 ICollection 中移走给定的元素；
        ///// </summary>
        ///// <param name="iEnum"></param>
        ///// <param name="objEnum"></param>
        [TestMethod]
        public void Remove()
        {
            ICollection<int> iEnum = new List<int> { 1, 2, 3 };
            iEnum.Remove(new[] { 1, 2 });
            Assert.IsTrue(iEnum.Sum() == 3 && iEnum.Count() == 1);
        }

        ///// <summary>
        ///// 移除元素；
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="iEnum"></param>
        ///// <param name="objEnum"></param>
        [TestMethod]
        public void RemoveAccordFunc()
        {
            ICollection<int> iEnum = new List<int> { 1, 2, 3 };
            iEnum.Remove((item)=> item<=2);
            Assert.IsTrue(iEnum.Sum() == 3 && iEnum.Count() == 1);
        }


        //#region 转换成为另外一个数组

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="ary"></param>
        ///// <param name="func"></param>
        ///// <returns></returns>
        [TestMethod]
        public void ToArray()
        {
            ICollection<int> iEnum = new List<int> { 1, 2, 3 };
            var jEnum = iEnum.ToArray(item => item * item);
            Assert.IsTrue(jEnum.Sum() == 14);
        }


        [TestMethod]
        public void ToArray_WithIndex()
        {
            ICollection<int> iEnum = new List<int> { 1, 2, 3 };
            var jEnum = iEnum.ToArray((item,index) => (int) item * index);
            Assert.IsTrue(jEnum.Sum() == 8);
        }
        //#endregion

       

        ///// <summary>
        ///// 将列表里面的元素随机重排；
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="list"></param>
        ///// <param name="loopCount">随机重排次数，默认为2，越多越随机； </param>
        //public static void RandomRearrange<T>(this IList<T> list, int loopCount = 2)
        //{
        //    var random = new Random(); //
        //    while (loopCount-- > 0)
        //    {
        //        int length = list.Count;
        //        while (length > 1)
        //        {
        //            list.Swap(random.Next(0, length), length - 1);
        //            length--;
        //        }
        //    }
        //}
    }
}
