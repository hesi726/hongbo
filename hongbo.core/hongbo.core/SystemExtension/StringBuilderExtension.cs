using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringBuilderExtension
    {
        /// <summary>
        /// 反转 StringBuilder; 
        /// </summary>
        /// <param name="sb"></param>
        public static StringBuilder Reverse(this StringBuilder sb)
        {
            for(var index=0; index<sb.Length/2; index++)
            {
                var charIndex = sb[index];
                var relateChar = sb[sb.Length - 1 - index];
                sb[index] = relateChar;
                sb[sb.Length - 1 - index] = charIndex;
            }
            return sb;
        }

        /// <summary>
        /// 增加格式字符串后再增加新行;
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="format"></param>
        /// <param name="par"></param>
        public static StringBuilder AppendFormatLine(this StringBuilder sb, string format, params object[] par)
        {
            sb.AppendFormat(format, par).AppendLine();
            return sb; 
        }

        /// <summary>
        /// 有内容时按照给定格式增加到 StringBuilder;
        /// 并增加新行;
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="content"></param>
        /// <param name="format"></param>
        public static StringBuilder AppendFormatLineIfNotNull(this StringBuilder sb, string content, string format)
        {
            if (!string.IsNullOrEmpty(content))
                sb.AppendFormatLine(format, content);
            return sb;
        }

        /// <summary>
        /// 有内容时按照给定格式增加到 StringBuilder;
        /// 并增加新行;
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="content"></param>
        /// <param name="format"></param>
        public static StringBuilder AppendFormatLineIfNotNull(this StringBuilder sb, int? content, string format)
        {
            if (content.HasValue)
                sb.AppendFormatLine(format, content);
            return sb;
        }
        /// <summary>
        /// 有内容时按照给定格式增加到 StringBuilder;
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="content"></param>
        /// <param name="formatContent"></param>
        public static StringBuilder AppendFormatIfNotNull(this StringBuilder sb, string content, string formatContent)
        {
            if (!string.IsNullOrEmpty(content))
                sb.AppendFormat(formatContent, content); return sb;
        }
        /// <summary>
        /// 有内容时按照给定格式增加到 StringBuilder;
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="content"></param>
        /// <param name="formatContent"></param>
        public static StringBuilder AppendFormatIfNotNull(this StringBuilder sb, int? content, string formatContent)
        {
            AppendFormatIfNotNull(sb, content, formatContent, content); return sb;
        }

        /// <summary>
        /// 有内容时按照给定格式增加到 StringBuilder;
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="content"></param>
        /// <param name="formatContent"></param>
        /// <param name="formatParameter"></param>
        public static StringBuilder AppendFormatIfNotNull(this StringBuilder sb, int? content, string formatContent,params object[] formatParameter)
        {
            if (content.HasValue)
                sb.AppendFormat(formatContent, formatParameter); return sb;
        }
    }
}
