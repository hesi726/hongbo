using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.youzan.open.sdk.gen.v3_0_0.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.youzan.open.sdk.gen.v3_0_0.model;
using youzanTests;

namespace com.youzan.open.sdk.gen.v3_0_0.api.Tests
{
    [TestClass()]
    public class YouzanShopGetTests : BaseTest
    {
        [TestMethod()]
        public void YouzanShopGetTest()
        {
           
            YouzanShopGet shopGet = new YouzanShopGet();
            YouzanShopGetParams param = new YouzanShopGetParams();
            shopGet.APIParams = param;
            YouzanShopGetResult result = shopGet.Invoke(youzanConfig);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Name);
        }
        
    }
}