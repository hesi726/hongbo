using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using hongbao.CollectionExtension;

namespace hongboExtensionsTests.CollectionExtension
{
    /// <summary>
    /// IListExtensionTest1 的摘要说明
    /// </summary>
    [TestClass]
    public class IListExtensionTest1
    {
        

        /// <summary>
        /// 多个列表 笛卡尔 交集测试
        /// </summary>
        [TestMethod]
        public void IListExtension_DicarlTest()
        {
            List<string[]> test = new List<string[]>
            {
                new string[] {"1","2"}, new string[] {"3","4"}
            };
            var result = test.Dicarl();
            Assert.IsTrue(result.Count == 4);
            test.Add(new string[] {"5", "6"});
            result = test.Dicarl();
            Assert.IsTrue(result.Count == 8);
            test.Add(new string[] {"8","9","10"});
            result = test.Dicarl();
            Assert.IsTrue(result.Count == 24);
        }

        /// <summary>
        /// 层叠查询;
        /// </summary>
        [TestMethod]
        public void IListExtension_CascadeTest()
        {
            var grandFather = new Person();
            var father = new Person { Parent = grandFather };
            var son1 = new Person { Parent = father };
            var son2 = new Person { Parent = father };
            var mather = new Person { Parent = grandFather };
            var dau1 = new Person { Parent = mather };
            var dau2 = new Person { Parent = mather };
            List<Person> allPerson = new List<Person>
            {
                grandFather,father,son1,son2,mather,dau1,dau2
            };
            var result = grandFather.FindAllChild(allPerson, (parent, child) => child.Parent == parent);
            Assert.IsTrue(result.Count == 6);
            Assert.IsTrue(result.Where(a => a.Level == 1).Count() == 2);
            Assert.IsTrue(result.Where(a => a.Level == 2).Count() == 4);
            result = father.FindAllChild(allPerson, (parent, child) => child.Parent == parent);
            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result.Where(a => a.Level == 1).Count() == 2);
        }

        class Person
        {
            public Person Parent { get; set; }
        }
    }
}
