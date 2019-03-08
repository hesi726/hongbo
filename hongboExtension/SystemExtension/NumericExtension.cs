using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 数值的扩展类； 
    /// </summary>
    public static class NumericExtension
    {
        /// <summary>
        /// 
        /// </summary>
        public static string Yuan = "元";                        // “元”，可以改为“圆”、“卢布”之类

        /// <summary>
        /// 
        /// </summary>
        public static string Jiao = "角";                        // “角”，可以改为“拾”

        /// <summary>
        /// 
        /// </summary>
        public static string Fen = "分";                        // “分”，可以改为“美分”之类

        static string Digit = "零壹贰叁肆伍陆柒捌玖";      // 大写数字
      
        
        /// <summary>
        /// 零元 的大写字符串； 
        /// </summary>
        public static string ZeroString
        {
            get { return Digit[0] + Yuan; }
        }
        // 构造函数

        //public Money(decimal money)
        //{
        // //   try { money100 = (long)(money * 100m); }
        //    catch { Overflow = true; }
        //    if (money100 == long.MinValue) Overflow = true;
        //}       

        /// <summary>
        /// 转换为大写金额字符串； 
        /// </summary>
        /// <returns></returns>
        public static string ToUpperString(decimal money)
        {
            long money100 = (long)(money * 100m);
            bool Overflow = false;
            if (money100 == long.MinValue) Overflow = true;
            if (Overflow) return "金额超出范围";

            if (money100 == 0) return ZeroString;
            string[] Unit = { Yuan, "万", "亿", "万", "亿亿" };
            long value = System.Math.Abs(money100);
            bool isAllZero = true;
            bool isPreZero = true;
            StringBuilder sb = new StringBuilder();
            ParseSection(value, true, ref isAllZero, ref isPreZero, sb);
            for (int i = 0; i < Unit.Length && value > 0; i++)
            {
                if (isPreZero && !isAllZero) sb.Append(Digit[0]);
                if (i == 4 && sb.ToString().EndsWith(Unit[2]))
                    sb.Remove(sb.Length - Unit[2].Length, Unit[2].Length);
                sb.Append(Unit[i]);
                ParseSection(value, false, ref isAllZero, ref isPreZero, sb);
                if ((i % 2) == 1 && isAllZero)
                    sb.Remove(sb.Length - Unit[i].Length, Unit[i].Length);
            }
            if (money100 < 0) sb.Append("负");
            sb.Reverse();
            return sb.ToString();
        }


        /// <summary>
        /// 解析“片段”: “角分(2位)”或“万以内的一段(4位)”
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isJiaoFen"></param>
        /// <param name="isAllZero"></param>
        /// <param name="isPreZero"></param>
        /// <param name="sb"></param>
        private static bool ParseSection(long value, bool isJiaoFen, ref bool isAllZero, ref bool isPreZero, StringBuilder sb )
        {
            string[] Unit = isJiaoFen ?
              new string[] { Fen, Jiao } :
              new string[] { "", "拾", "佰", "仟" };           
            for (int i = 0; i < Unit.Length && value > 0; i++)
            {
                int d = (int)(value % 10);
                if (d != 0)
                {
                    if (isPreZero && !isAllZero) sb.Append(Digit[0]);
                    sb.AppendFormat("{0}{1}", Unit[i], Digit[d]);
                    isAllZero = false;
                }
                isPreZero = (d == 0);
                value /= 10;
            }
            return isPreZero;
        }
    }
}
