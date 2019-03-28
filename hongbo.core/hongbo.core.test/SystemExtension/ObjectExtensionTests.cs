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
    public class ObjectExtensionTests
    {
        [TestMethod()]
        public void SetPropertyTest()
        {
            TestObject obj = new TestObject();

            obj.SetProperty("TestEnum", "1");
            Assert.IsTrue(obj.TestEnum == TestEnum.End);//

            obj.SetProperty("Salary", "123.5");
            Assert.IsTrue(obj.Salary - 123.5 <=0.001);
            obj.SetProperty("Salary", "123.5");
            Assert.IsTrue(obj.Salary - 123.5 <= 0.001);

            obj.SetProperty("Name", "Test");
            Assert.IsTrue(obj.Name == "Test");
            obj.SetProperty("Name", "Test");
            Assert.IsTrue(obj.Name == "Test");
            obj.SetProperty("Name", "");  //设置为空字符串时（因为空字符串当作null)，不会改变原来的值；
            Assert.IsTrue(obj.Name == "Test");
            obj.SetProperty("Name", "", false);  //设置为空字符串时（因为空字符串将作为空字符串)，不会改变原来的值；
            Assert.IsTrue(obj.Name == "");

            obj.SetProperty("Age", "1");
            Assert.IsTrue(obj.Age == 1);
            obj.SetProperty("Age", "1");
            Assert.IsTrue(obj.Age == 1);
            obj.SetProperty("Age", ""); //设置为空字符串时（因为空字符串当作null)，不会改变原来的值；
            Assert.IsTrue(obj.Age == 1);

            obj.SetProperty("Money", "1.2222");
            Assert.IsTrue(obj.Money - 1.2222 < 0.001);
            obj.SetProperty("Money", ""); //设置为空字符串时（因为空字符串当作null)，不会改变原来的值；
            Assert.IsTrue(obj.Money - 1.2222 < 0.001);

            obj.SetProperty("Birth", "2015-12-31");
            Assert.IsTrue(obj.Birth == DateTime.Parse("2015-12-31"));
            obj.SetProperty("Money", ""); //设置为空字符串时（因为空字符串当作null)，不会改变原来的值；
            Assert.IsTrue(obj.Birth == DateTime.Parse("2015-12-31"));
        }

        [TestMethod()]
        public void SetPropertiesTest()
        {
            TestObject obj = new TestObject();
            obj.SetProperties(new string[] { "Name", "Age" }, new string[] { "Test", "12" });
            Assert.IsTrue(obj.Name == "Test");
            Assert.IsTrue(obj.Age == 12);
        }

        [TestMethod()]
        public void GetPropertyTest()
        {
            TestObject obj = new TestObject();
            obj.SetProperties(new string[] { "Name", "Age" }, new string[] { "Test", "12" });
            Assert.IsTrue("Test".Equals(obj.GetProperty("Name")));
            Assert.IsTrue(12.Equals(obj.GetProperty("Age")));
        }

        [TestMethod()]
        public void CallMethodTest()
        {
            TestObject obj = new TestObject { Name = "Dai" };
            object result = obj.CallMethod("Hello", null);
            Assert.IsTrue(result.Equals("Hello,Dai"));
            result = obj.CallMethod("hello", null, true);
            Assert.IsTrue(result.Equals("Hello,Dai"));

            result = obj.CallMethod("Say", new object[] { "daiwei" });
            Assert.IsTrue(result.Equals("daiwei"));
            result = obj.CallMethod("say", new object[] { "daiwei" }, true);
            Assert.IsTrue(result.Equals("daiwei"));

            result = obj.CallMethod("nothismethod", new object[] { "daiwei" }, true);
            Assert.IsNull(result);
        }
    }

    public class TestObject
    {
        public string Name { get; set;  }

        public int Age { get; set; }

        public double Money { get; set; }

        public DateTime Birth { get; set;  }

        public double? Salary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TestEnum TestEnum { get; set; }

        public string Hello()
        {
            return "Hello," + Name; 
        }

        public string Say(string welcome)
        {
            return welcome;
        }

        
    }

    public enum TestEnum
    {
        Begin =0, 
        End = 1
    }

}