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
    public class DateTimeExtensionTests
    {
        [TestMethod()]
        public void PriorMonthBeginDateTest()
        {
            DateTime dt = DateTime.Parse("2015-01-10");
            Assert.IsTrue(dt.PriorMonthBeginDate().ToString("yyyy-MM-dd") == "2014-12-01");
        }

        [TestMethod()]
        public void PriorMonthEndDateTest()
        {
            DateTime dt = DateTime.Parse("2015-01-10");
            Assert.IsTrue(dt.PriorMonthEndDate().ToString("yyyy-MM-dd") == "2014-12-31");
        }

        [TestMethod()]
        public void MonthEndDateTest()
        {
            DateTime dt = DateTime.Parse("2015-01-10");
            Assert.IsTrue(dt.MonthEndDate().ToString("yyyy-MM-dd") == "2015-01-31");
        }

        [TestMethod()]
        public void MonthBeginDateTest()
        {
            DateTime dt = DateTime.Parse("2015-01-10");
            Assert.IsTrue(dt.MonthBeginDate().ToString("yyyy-MM-dd") == "2015-01-01");
        }

        [TestMethod()]
        public void WeekEndDateTest()
        {
            DateTime dt = DateTime.Parse("2016-01-20");
            Assert.IsTrue(dt.WeekEndDate().ToString("yyyy-MM-dd") == "2016-01-23");
        }

        [TestMethod()]
        public void WeekBeginDateTest()
        {
            DateTime dt = DateTime.Parse("2018-04-19");
            Assert.IsTrue(dt.WeekBeginDate() == DateTime.Parse("2018-04-15"));

            dt = DateTime.Parse("2018-04-25 01:00:00");
            Assert.IsTrue(dt.WeekBeginDate() == DateTime.Parse("2018-04-22"));
        }

        [TestMethod()]
        public void PriorWeekEndDateTest()
        {
            DateTime dt = DateTime.Parse("2016-01-20");
            Assert.IsTrue(dt.PriorWeekEndDate().ToString("yyyy-MM-dd") == "2016-01-16");
        }

        [TestMethod()]
        public void PriorWeekBeginDateTest()
        {
            DateTime dt = DateTime.Parse("2016-01-20");
            Assert.IsTrue(dt.PriorWeekBeginDate().ToString("yyyy-MM-dd") == "2016-01-10");
        }
    }
}