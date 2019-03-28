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
    public class ClassUtilTests
    {
        [TestMethod()]
        public void ClassUtil_BuildGenericTypeInstance()
        {
            var obj = ClassUtil.BuildGenericTypeInstance(typeof(ClassUtilTest<>), typeof(string));
            Assert.IsTrue(obj is ClassUtilTest<string>);

            obj = ClassUtil.BuildGenericTypeInstance(typeof(ClassUtilTest<>), new Type[] { typeof(string) }, "abc");
            Assert.IsTrue(obj is ClassUtilTest<string>);
        }
    }

    public class ClassUtilTest<T>
    {
       public ClassUtilTest()
        {

        }

        public ClassUtilTest(string xx)
        {
            this.Xx = xx;
        }

        public string Xx { get; private set; }
    }
}