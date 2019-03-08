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
        public IListExtensionTest1()
        {
          
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

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
