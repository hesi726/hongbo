using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// int的扩展函数;
    /// </summary>
    public static class IntExtension
    {
        static char[] CHARS = null;

        static int CHARS_LEN = 0;

        static char[] CHARSWITHNUMBERS = null;

        static int CHARSWITHNUMBERS_LEN = 0;

        static IntExtension()
        {

            CHARS = new char[]
            {
                'z','y','x','w','a','b','c','d','u','e','f','g','h','i','j','k','l','m','n','v','o','p','q','r','s','t'
            };
            CHARS_LEN = CHARS.Length;

            CHARSWITHNUMBERS = new char[]
            {
                'z','y','x','w','a','b','c','d','u','e','f','g','h','i','j','k','l','m','n','v','o','p','q','r','s','t',
                '0','1','2','3','4','5','6','7','8','9',
            };

            CHARSWITHNUMBERS_LEN = CHARSWITHNUMBERS.Length;
        }

        /// <summary>
        /// 转换为只包含有字母的整数;(全部小写)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string ConvertToChar(long val)
        {
            var xval = val;
            int maxLen = 20;
            char[] seeds = new char[maxLen];
            int seedLen = 19;
            while (xval > 0)
            {
                long mod = xval % CHARS_LEN;
                seeds[seedLen--] = CHARS[mod];
                xval = xval / CHARS_LEN;
            }
            var result = new string(seeds, seedLen + 1, maxLen - seedLen - 1);
            return result;
        }

        /// <summary>
        /// 转换为只包含有字母和数字的整数;(全部小写)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string ConvertToCharAndNumber(long val)
        {
            var xval = val;
            int maxLen = 20;
            char[] seeds = new char[maxLen];
            int seedLen = 19;
            while (xval > 0)
            {
                long mod = xval % CHARSWITHNUMBERS_LEN;
                seeds[seedLen--] = CHARSWITHNUMBERS[mod];
                xval = xval / CHARSWITHNUMBERS_LEN;
            }
            var result = new string(seeds, seedLen + 1, maxLen - seedLen - 1);
            return result;
        }

    }
}
