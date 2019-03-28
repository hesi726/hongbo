using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// GUID 的工具类； 
    /// </summary>
    public static class GuidUtil
    {

        private static char[] CHARS = new char[]
        {
            'A','B','C','D','E','F','G',
            'H','I','J','K','L','M','N',
            'O','P','Q','R','S','T',
            'U','V','W','X','Y','Z',
            '0','1','2','3','4','5','6','7','8','9',
            '_' // ,'^','@', '~','`','(',')','{','}','$',,'[',']',';',',','#','|'
        };
        private static Random random = new Random(Int32.MaxValue);
        private static DateTime begin = DateTime.Parse("2016-04-01");
        //private static int seedIndex = 0; 

        /// <summary>
        /// 因为 Guid函数，返回32个字符串；替换了 Guid中的 - 字符串;
        /// </summary>
        /// <returns></returns>
        public static string NewGuid()
        {
            return System.Guid.NewGuid().ToString("N");
           /* TimeSpan ts1 = (DateTime.Now - begin);//  Process.GetCurrentProcess().TotalProcessorTime;
            long ms = (long) ts1.TotalMilliseconds;  //毫秒，10年毫秒大约为 87600 * 365 * 1000 =  300 * 10000 * 10000

            long seed = (seedIndex++) * 1000L * 10000 * 10000 + ms + random.Next(Int32.MaxValue);
            if (seedIndex >= 10000 * 10000) seedIndex = 0;
            char[] seeds = new char[20];
            int seedLen = 0; 
            int len = CHARS.Length; 
            while (seed > 0)
            {
                long mod = seed % len;
                seeds[seedLen++] += CHARS[mod];
                seed = seed / len;
            }
            return new string(seeds, 0, seedLen);*/
        }
    }
}
