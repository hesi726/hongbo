using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using youzan;

namespace youzanTests
{
    [TestClass()]
    public class BaseTest
    {
        protected YouzanConfig youzanConfig = null;

        [TestInitialize]
        public void TestInitiate()
        {
            YouzanConfig youzanConfig = new YouzanConfig { AppId = "Appid1", AppSecret = "AppSecret1", KdtId = "KdtId1" };
        }

        [TestCleanup]
        public void TestCleanup()
        {
            youzanConfig = null;
        }
    }
}
