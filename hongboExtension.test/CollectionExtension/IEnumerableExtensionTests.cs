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
        public void Dicarl()
        {
            var xx = iEnum.Dicarl<string, string>(jEnum);
            var yy = xx.Select((a) => a.Item1 + a.Item2).Join("");
            Assert.IsTrue(yy == "aaadbabd", "Dicarl 后变成 [[a,b],[a,d],[b,a],[b,d]]");
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
            var yy = xx.ToDictionary((item, index) => item.Age);
            Assert.IsTrue(yy.Count() == 1 && yy.First().Value.Name == "Daiwei", "转换后 再 distinct ，返回 1");
        }
    }
}