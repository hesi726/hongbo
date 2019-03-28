using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.SystemExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension.Tests
{
    [TestClass()]
    public class StringExtensionTests
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        public void MiddelWithLoopTest()
        {
            string content = "{abc{abb}";
            Assert.IsTrue(content.MiddelWithLoop('{', '}') == null);

            content = "{a{a}a}";
            Assert.IsTrue(content.MiddelWithLoop('{', '}') == content);
        }

        [TestMethod()]
        public void TrimToNull()
        {
            Assert.IsNull(StringExtension.TrimToNull("  "),"应该为 null");
            Assert.IsNull(StringExtension.TrimToNull(""), "应该为 null");
            Assert.IsNull(StringExtension.TrimToNull(null), "应该为 null");
            Assert.IsTrue(StringExtension.TrimToNull(" a b ")=="a b", "应该为 a b");
        }
    }
}