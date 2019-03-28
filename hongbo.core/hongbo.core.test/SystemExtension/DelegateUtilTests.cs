using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.SystemExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace hongbao.SystemExtension.Tests
{
    public delegate int Call(int num1, int num2);//第一步：定义委托类型

    [TestClass()]
    public class DelegateUtilTests
    {
        [TestMethod()]
        public void DelegateUtil_ConvertTo_Static_FullComplicatable() //静态方法，参数和返回类型完全一致;
        {
            Call objCall;//第二步：声明委托变量
            objCall = Multiply_StaticFullfit;
            var method = this.GetType().GetMethod("Multiply_StaticFullfit");
            Call objCall1 = DelegateUtil.ConvertTo<Call>(method, null);
            Assert.IsNotNull(objCall);

            Assert.AreEqual(10, objCall1(2, 5));
        }

        [TestMethod()]
        public void DelegateUtil_ConvertTo_StaticComplitable()   //静态方法，参数可兼容
        {
            var method = this.GetType().GetMethod("Multiply_StaticComplitable", BindingFlags.Static | BindingFlags.Public);
            Call objCall1 = DelegateUtil.ConvertTo<Call>(method, null);
            Assert.IsNotNull(objCall1);
            Assert.AreEqual(10, objCall1(2, 5));
        }

        [TestMethod()]
        public void DelegateUtil_ConvertTo_Multiply_InstanceFullfit() //实例方法，参数完全一致;
        {
            var method = this.GetType().GetMethod("Multiply_InstanceFullfit", BindingFlags.Instance | BindingFlags.Public);
            Call objCall1 = DelegateUtil.ConvertTo<Call>(method, new DelegateUtilTests());
            Assert.IsNotNull(objCall1);
            Assert.AreEqual(10, objCall1(2, 5));
        }

        [TestMethod()]
        public void DelegateUtil_ConvertTo_InstanceComplitable()  //实例的可兼容方法，
        {
            var method = this.GetType().GetMethod("Multiply_InstanceComplitable");
            Call objCall1 = DelegateUtil.ConvertTo<Call>(method,  new DelegateUtilTests());
            Assert.AreEqual(10, objCall1(2, 5));
        }

        [TestMethod()]
        public void DelegateUtil_HasCompatiableMethodParameter()
        {
            var method = this.GetType().GetMethod("Multiply_InstanceComplitable");
            Assert.IsTrue(DelegateUtil.HasCompatiableMethodParameter<Call>(method));  //可兼容方法，返回 true;

            method = this.GetType().GetMethod("Multiply_InstanceNoComplitable");
            Assert.IsFalse(DelegateUtil.HasCompatiableMethodParameter<Call>(method)); //不可兼容方法，返回 false;
        }

        // 乘法方法
        public int Multiply_InstanceComplitable(int num1, object num2)
        {
            int xx = (int)num2;
            return num1 * Convert.ToInt32(num2);
        }
        // 乘法方法
        public int Multiply_InstanceNoComplitable(int num1, string num2)
        {
            return 0;
            //int xx = (int)num2;
            //return num1 * Convert.ToInt32(num2);
        }
        // 乘法方法
        public int Multiply_InstanceFullfit(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Multiply_StaticComplitable(int num1, object num2)
        {
            int xx = (int)num2;
            return num1 * Convert.ToInt32(num2);
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="num1"></param>
       /// <param name="num2"></param>
       /// <returns></returns>
        public static int Multiply_StaticFullfit(int num1, int num2)
        {
            return num1 * num2;
        }

        
    }
}