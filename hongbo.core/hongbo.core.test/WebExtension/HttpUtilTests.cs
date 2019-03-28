using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.WebExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.WebExtension.Tests
{
    [TestClass()]
    public class HttpUtilTests
    {
        [TestMethod()]
        public void ReadBinaryTest()
        {
            var result = HttpUtil.ReadWeb("https://cdns.max-media.cc/.well-known/acme-challenge/GcQTTvspLXfdv5F8cbedRHckVAyF9WNUs395jFTAGNo");
            Assert.IsNotNull(result);
        }
    }
}