using hongbao.Drawing.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hongbao.DrawingTest.Utils
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
