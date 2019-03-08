using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.SecurityExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SecurityExtension.Tests
{
    [TestClass()]
    public class CRC32Tests
    {
        [TestMethod()]
        public void CRC32_GetCRC32Test()
        {
            string content = "123456789";
            var result = CRC32.GetCRC32(content);
            Assert.IsTrue(result == "CBF43926");

            content = "中国";
            result = CRC32.GetCRC32(content);
            Assert.IsTrue(result == "2BEDF491");
        }
    }
}