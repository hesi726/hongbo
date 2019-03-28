using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.CollectionExtension;
using System.Linq;

namespace hongboExtensionsTests.CollectionExtension
{
    /// <summary>
    /// DictionaryExtensionTest 的摘要说明
    /// </summary>
    [TestClass]
    public class DictionaryExtensionTest
    {
        

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

        [TestMethod]
        public void FindOrInsert()
        {
            Dictionary<int, long> xx = new Dictionary<int, long>();
            int sum = 1000;
            for (var index = 0; index < sum; index++) xx[index] = 0;
            for (var index=0; index< sum; index++)
            {
                xx[index] = index;
            }
            var value = xx.FindOrInsert(0, 100);
            Assert.IsTrue(value == 0);

            value = xx.FindOrInsert(0, ()=> 1000);
            Assert.IsTrue(value == 0);


            value = xx.FindOrInsert(()=> 100, () => 1000);
            Assert.IsTrue(value == 100);
        }
    }
}
