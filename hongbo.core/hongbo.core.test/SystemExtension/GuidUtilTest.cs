using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.SystemExtension;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Linq.Expressions;

namespace hongboExtensionsTests.SystemExtension
{

   

    class SimpleMath
    {
        // 乘法方法
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // 除法方法
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
    [TestClass]
    public class GuidUtilTest
    {
        [TestMethod]
        public void TestNewGuid()
        {
            //SortedSet<string> guids = new SortedSet<string>();
            DateTime begin = DateTime.Now;
            for (var index = 0; index < 100000; index++)
            {
                string newguid = GuidUtil.NewGuid();
               // Assert.IsFalse(guids.Contains(newguid));
               // guids.Add(newguid);
            }
            Assert.IsTrue((DateTime.Now - begin).TotalSeconds < 1.0);
        }
        
    }

}
