using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.CollectionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hongboExtension.test;

namespace hongbao.CollectionExtension.Tests
{
    [TestClass()]
    public class IEnumerableExtensionTests
    {
        /// <summary>
        /// 泛型的 iEnum
        /// </summary>
        IEnumerable<string> iEnum = new  string[] { "a", "b" };

        /// <summary>
        /// 泛型的 iEnum
        /// </summary>
        IEnumerable<string> jEnum = new string[] { "a", "d" };
        /// <summary>
        /// 非泛型的 xEnum;
        /// </summary>
        System.Collections.IEnumerable xEnum = new string[] { "a", "b" };


        /// <summary>
        /// 对 IEnumerable<T> 进行分批操作;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="batchCount"></param>
        /// <param name="batchAction"></param>
        [TestMethod]
        public void Batch()
        {
            var xx = "";
            var batchCnt = 0;
            iEnum.Batch(1, (item) => { xx += item.First(); batchCnt++; });
            Assert.IsTrue(batchCnt == 2 && xx == "ab");

            var aEnum = ArrayUtil.GetIntArray(0, 16);
            batchCnt = 0;
            var sum = 0;
            aEnum.Batch(4, (batchItems) => { var childSum = batchItems.Sum(); sum += childSum; batchCnt++; });
            Assert.IsTrue(batchCnt == 5 && sum == (0 + 16) * 17 / 2);
        }
        [TestMethod]
        public void Find()
        {
            Assert.IsNull(iEnum.Find((item, index) => false));
            Assert.IsTrue(iEnum.Find((item, index) => true) == "a");
            AssertUtil.Exception(() =>
            {
                var ienumList = iEnum.ToList();
                Assert.IsTrue(ienumList.Find((item, index) =>
                {
                    if (index == 0) ienumList.Add("c"); //修改时将抛出异常;
                    return item == "c";
                }) == "c");
            });
        }
        [TestMethod()]
        public void ForEach()
        {
            var xx = "";
            iEnum.ForEach(item => xx += item);
            Assert.IsTrue(xx == "ab");

            xx = "";
            xEnum.ForEach(item => xx += item);
            Assert.IsTrue(xx == "ab");
        }

        [TestMethod()]
        public void ForEachWithIndex()
        {
            var xx = "";
            iEnum.ForEach((item, index) => xx += item+index);
            Assert.IsTrue(xx == "a0b1");

            xx = "";
            xEnum.ForEach((item, index) => xx += item.ToString() + index);
            Assert.IsTrue(xx == "a0b1");
        }

        [TestMethod()]
        public void ForEachWithFunction()
        {
            var xx = "";
            iEnum.ForEach((item) => { xx += item; return true; });
            Assert.IsTrue(xx == "ab", "全部处理");

            xx = "";
            iEnum.ForEach((item) => { xx += item; return item=="b"; });
            Assert.IsTrue(xx == "a", "处理完第一个元素 a 后不再继续处理");

            xx = "";
            xEnum.ForEach((item) => { xx += item; return true; });
            Assert.IsTrue(xx == "ab", "全部处理");

            xx = "";
            xEnum.ForEach((item) => { xx += item; return item.Equals("b"); });
            Assert.IsTrue(xx == "a", "处理完第一个元素 a 后不再继续处理");
        }

        [TestMethod()]
        public void ForEachWithFunctionIndex()
        {
            var xx = "";
            iEnum.ForEach((item, index) => { xx += item; return true; });
            Assert.IsTrue(xx == "ab", "全部处理");

            xx = "";
            iEnum.ForEach((item, index) => { xx += item; return index <0; });
            Assert.IsTrue(xx == "a", "处理完第一个元素 a 后不再继续处理");

            xx = "";
            xEnum.ForEach((item, index) => { xx += item; return true; });
            Assert.IsTrue(xx == "ab", "全部处理");

            xx = "";
            xEnum.ForEach((item, index) => { xx += item; return index < 0; });
            Assert.IsTrue(xx == "a", "处理完第一个元素 a 后不再继续处理");
        }

        [TestMethod()]
        public void Intersect()
        {
            var xx = iEnum.Intersect(jEnum, (a, b) => { return a == b; }).ToArray();
            Assert.IsTrue(xx.Count()==1 && xx.First()=="a", "只剩下 a");

            xx = iEnum.Intersect(jEnum, (a, b) => { return a != b; }).ToArray();
            Assert.IsTrue(xx.Count() == 2 && xx.First() == "a", "[a,b] 都剩下");
        }

        [TestMethod()]
        public void IntersectWithCompare()
        {
            var xx = iEnum.IntersectWithCompare((a) => { return a == "a"; }).ToArray();
            Assert.IsTrue(xx.Count() == 1 && xx.First() == "a", "只剩下 a");

            xx = iEnum.IntersectWithCompare((a) => { return a == "b"; }).ToArray();
            Assert.IsTrue(xx.Count() == 1 && xx.First() == "b", "只剩下 b");
        }
        [TestMethod()]
        public void IndexOf()
        {
            var xx = iEnum.IndexOf((a) => { return a == "a"; });
            Assert.IsTrue(xx == 0, "a 在0 位置");

            xx = iEnum.IndexOf((a) => { return a == "d"; });
            Assert.IsTrue(xx < 0, "d 不存在");
        }
        [TestMethod()]
        public void Select()
        {            
            var xx = xEnum.Select((item, index) => item).Join("");
            Assert.IsTrue(xx == "ab", "变成 [a,b]");

            xx = xx = xEnum.Select((item, index) =>  item.ToString() + index).Join("");
            Assert.IsTrue(xx == "a0b1", "变成 [a0,b1]");
        }

        [TestMethod()]
        public void ToArray()
        {
            var xx = xEnum.ToArray((item) => item).Join("");
            Assert.IsTrue(xx == "ab", "全部处理");

            xx = xEnum.ToArray((item, index) => item.ToString() + index).Join("");
            Assert.IsTrue(xx == "a0b1", "处理完第一个元素 a 后不再继续处理");

            xx = iEnum.ToArray((item, index) => item.ToString() + index).Join("");
            Assert.IsTrue(xx == "a0b1", "处理完第一个元素 a 后不再继续处理");
        }

        [TestMethod()]
        public void Union()
        {
            var xx = iEnum.Union("c").Join("");
            Assert.IsTrue(xx == "abc", "全部处理");
        }


        [TestMethod()]
        public void JoinTest()
        {
            string[] abc = new string[] { "a", "b" };
            var result = abc.Join("/");
            Assert.IsTrue(result == "a/b", "Join后变成 a/b");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            string[] abc = new string[] { "a", "b" };
            var result = abc.ToString("/");
            Assert.IsTrue(result == "a/b", "ToString后变成 a/b");
        }
        [TestMethod()]
        public void Dicar()
        {
            var xx = iEnum.Dicarl<string>(iEnum);
            Assert.IsTrue(xx.Count() == 4);
        }
        [TestMethod()]
        public void Dicar2()
        {
            var xx = iEnum.Dicarl<string, string>(jEnum);
            var yy = xx.Select((a) => a.Item1 + a.Item2).Join("");
            Assert.IsTrue(yy == "aaadbabd", "Dicarl 后变成 [[a,b],[a,d],[b,a],[b,d]]");
        }

        [TestMethod()]
        public void Dicar3()
        {
            IEnumerable<string>[] enumList = new IEnumerable<string>[] {iEnum, iEnum, iEnum};
            var xx = iEnum.Dicarl<string, string, string>(jEnum, jEnum);
            Assert.IsTrue(xx.Count() == 8);
        }

        [TestMethod()]
        public void Dicar4()
        {
            var xx = iEnum.Dicarl<string, string, string, string>(jEnum, jEnum, jEnum);
            Assert.IsTrue(xx.Count() == 16);
        }
        [TestMethod()]
        public void Dicar5()
        {
            var xx = iEnum.Dicarl<string, string, string, string, string>(jEnum, jEnum, jEnum, jEnum);
            Assert.IsTrue(xx.Count() == 32);
        }

        [TestMethod()]
        public void Dicar7()
        {
            var xx = iEnum.Dicarl<string, string, string, string, string, string>(jEnum, jEnum, jEnum, jEnum, jEnum);
            Assert.IsTrue(xx.Count() == 64);
        }
        [TestMethod()]
        public void Dicar8()
        {
            var xx = iEnum.Dicarl<string, string, string, string, string, string, string>(jEnum, jEnum, jEnum, jEnum, jEnum, jEnum);
            Assert.IsTrue(xx.Count() == 128);
        }

        
        [TestMethod()]
        public void Distinct()
        {
            var xx = iEnum.Distinct(item=>1);
            Assert.IsTrue(xx.First() == 1, "转换后 再 distinct ，返回 1");
        }
        [TestMethod()]
        public void DistinctBy()
        {
            IEnumerable<Person> xx = new List<Person>
            {
                new Person{ Age = 18, Name="Daiwei"},
                new Person{ Age = 18, Name="Zhao"}
            };
            var yy = xx.DistinctBy(item => item.Age);
            Assert.IsTrue(yy.Count() == 1 && yy.First().Name=="Daiwei", "转换后 再 distinct ，返回 1");
        }
        [TestMethod()]
        public void Except()
        {
            IEnumerable<Person> xx = new List<Person>
            {
                new Person{ Age = 18, Name="Daiwei"},
                new Person{ Age = 18, Name="Zhao"}
            };
            var yy = xx.Except<Person, Person>(xx, (a,b) => false);
            Assert.IsTrue(yy.Count() == 2 && yy.First().Name == "Daiwei", "Except 不处理任何项");

            xx = new List<Person>
            {
                new Person{ Age = 18, Name="Daiwei"},
                new Person{ Age = 18, Name="Zhao"}
            };
            yy = xx.Except(xx, (a, b) => true);
            Assert.IsTrue(yy.Count() == 0, "Except 处理所有项");
        }



        [TestMethod()]
        public void ToDictionary()
        {
            IEnumerable<Person> xx = new List<Person>
            {
                new Person{ Age = 18, Name="Daiwei"},
                new Person{ Age = 18, Name="Zhao"}
            };
            var yy = xx.ToDictionary((item, index) => item.Age);
            Assert.IsTrue(yy.Count() == 1 && yy.First().Value.Name == "Daiwei", "转换后 再 distinct ，返回 1");
        }

        [TestMethod()]
        public void ToSortedList()
        {
            IEnumerable<Person> xx = new List<Person>
            {
                new Person{ Age = 19, Name="Daiwei"},
                new Person{ Age = 18, Name="Zhao"}
            };
            var yy = xx.ToSortedList((item) => item.Age);
            Assert.IsTrue(yy.Count() == 2 && yy.Last().Value.Name == "Daiwei", "转换后 再 distinct ，返回 1");
        }
    }
}