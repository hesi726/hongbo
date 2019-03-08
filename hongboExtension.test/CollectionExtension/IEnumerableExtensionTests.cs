using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.CollectionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.CollectionExtension.Tests
{
    [TestClass()]
    public class IEnumerableExtensionTests
    {
        [TestMethod()]
        public void JoinTest()
        {
            string[] abc = new string[] { "a", "b" };
            var result = abc.Join("/");
            Assert.IsTrue(result == "a/b");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            string[] abc = new string[] { "a", "b" };
            var result = abc.ToString("/");
            Assert.IsTrue(result == "a/b");
        }
    }
}