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
    public class ConfigTests
    {
        [TestMethod()]
        public void AppSettingTest()
        {
            Assert.IsTrue(ConfigurationUtil.AppSetting("config_for_test") == "123");
            Assert.IsTrue(ConfigurationUtil.AppSetting<int>("config_for_test") == 123);

            Assert.IsTrue(ConfigurationUtil.AppSetting("nothis_config_for_test","abc") == "abc");
            Assert.IsTrue(ConfigurationUtil.AppSetting<int>("nothis_config_for_test", 123) == 123);
        }
    }
}