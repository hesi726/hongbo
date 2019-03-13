using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongboExtension.test
{
    public static class AssertUtil
    {
        /// <summary>
        /// 期望产生异常
        /// </summary>
        /// <param name="action"></param>
        /// <param name="message"></param>
        public static void Exception(Action action, string message = null)
        {
            try
            {
                action();
                Assert.Fail(message??"期望产生异常");
            }
            catch
            {

            }
        }
    }
}
