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
    public class WeatherTests
    {
        [TestMethod()]
        public void Weather_QueryTest()
        {
            var result = new Weather().Query("广州");
            Assert.IsNotNull(result); 
            Assert.IsTrue(result != null); 
        }
    }
}