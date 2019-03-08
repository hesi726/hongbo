using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.SystemExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace hongbao.SystemExtension.Tests
{
    [TestClass()]
    public class EnumUtilTests
    {
        [TestMethod()]
        public void GetValueTest()
        {
            Assert.IsTrue(EnumUtil.GetValue<XTest>(0) == XTest.A);

            Assert.IsTrue((XTest) EnumUtil.GetValue(typeof(XTest), 0) == XTest.A);

            Assert.IsTrue((XTest)EnumUtil.GetValue(typeof(XTest), "A") == XTest.A);

            Assert.IsTrue((XTest)EnumUtil.GetValue(typeof(XTest), "0") == XTest.A);
        }

        [TestMethod()]
        public void ExistsValueTest()
        {
            XTest xx = (XTest)3;
            Assert.IsFalse(EnumUtil.ExistsValue<XTest>(xx));
            xx = (XTest)1;
            Assert.IsTrue(EnumUtil.ExistsValue<XTest>(xx));
            xx = XTest.A;
            Assert.IsTrue(EnumUtil.ExistsValue<XTest>(xx));
        }

        [TestMethod]
        public void GetIntValue()
        {
            var result = EnumUtil.GetIntValue(XTest.C);
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void DecodeValue()
        {
            var result = EnumUtil.Decode(XTest.A, 0, (XTest.A, 1));
            Assert.IsTrue(result == 1);

            result = EnumUtil.Decode(XTest.B, 0, (XTest.B, 1));
            Assert.IsTrue(result == 1);


            result = EnumUtil.Decode(XTest.C, 0, new[] { (XTest.A, 1),
                (XTest.C, 2),
            });
            Assert.IsTrue(result == 2);
        }

        [TestMethod()]
        public void EnumUtil_GetAttribute()
        {
            var result = EnumUtil.GetAttribute(typeof(XTest), XTest.A);
            Assert.IsTrue(result.Count == 1 && result[0] is DisplayAttribute);

            result = EnumUtil.GetAttribute(typeof(XTest), XTest.B);
            Assert.IsTrue(result.Count == 0);

            result = EnumUtil.GetAttribute(typeof(XTest), "0");
            Assert.IsTrue(result.Count == 1 && result[0] is DisplayAttribute);

            result = EnumUtil.GetAttribute(typeof(XTest), "A");
            Assert.IsTrue(result.Count == 1 && result[0] is DisplayAttribute);
        }
    }

    public enum XTest
    {
        [Display(Name = "Abc")]
        A = 0,

        B = 1,

        C = 2
    }
}