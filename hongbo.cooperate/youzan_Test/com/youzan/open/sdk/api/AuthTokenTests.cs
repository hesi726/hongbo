using Microsoft.VisualStudio.TestTools.UnitTesting;
using youzan.com.youzan.open.sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using youzanTests;

namespace youzan.com.youzan.open.sdk.Tests
{
    [TestClass()]
    public class AuthTokenTests : BaseTest
    {
        [TestMethod()]
        public void FormUrlEncodedPostGetResultTest()
        {
            dynamic token = youzanConfig.Token;
            Assert.IsNotNull(token);
            Assert.IsTrue(!string.IsNullOrEmpty(token.getToken()));
        }
    }
}