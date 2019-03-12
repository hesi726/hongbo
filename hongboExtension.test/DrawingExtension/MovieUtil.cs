
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hongbao.DrawingExtension
{
    /// <summary>
    /// 视频的工具类； 
    /// </summary>
    [TestClass]
    public class MovieUtilTest
    {
        /// <summary>
        /// 获取视频文件长度； 
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public void GetMediaTimeLenSecond()
        {

            string filepath = @"";
            var result = MovieUtil.GetMediaTimeLenSecond(filepath);
            Assert.IsTrue(result > 0);
        }
    }
}
