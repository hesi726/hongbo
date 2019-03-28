using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using hongbao.CollectionExtension;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 字符串的工具类。
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 返回第1个非空字符串;
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string Coalesce(params string[] args)
        {
            foreach(var x in args)
            {
                if (!string.IsNullOrEmpty(x))
                    return x; 
            }
            return null;
        }
        /// <summary>
        /// 查找给定字符串数组任意字符串在字符串中第一个出现的位置
        /// </summary>
        /// <param name="source"></param>
        /// <param name="stringComparison"></param>
        /// <param name="substringArray"></param>
        /// <returns></returns>
        public static int IndexOf(this string source, StringComparison stringComparison = StringComparison.Ordinal, params string[] substringArray)
        {
            foreach(var sub in substringArray)
            {
                var index = source.IndexOf(sub, stringComparison);
                if (index >= 0) return index;
            }
            return -1;
        }

        /// <summary>
        /// 查找给定字符串数组任意字符串在字符串中第一个出现的位置
        /// </summary>
        /// <param name="source"></param>
        /// <param name="substringArray"></param>
        /// <returns></returns>
        public static int IndexOf(this string source,  params string[] substringArray)
        {
            return IndexOf(source, StringComparison.Ordinal, substringArray);
        }

        /// <summary>
        /// 在源字符串中将 srcstr替换成 targetstr字符串;但注意：不是全部替换，只会替换 指定次数；
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="srcstr">被替换字符串</param>
        /// <param name="targetstr">目的字符串</param>
        /// <param name="count">进行的替换次数，&lt;=0 表示全部替换</param>/// 
        /// <returns></returns>
        public static string Replace(this string source, string srcstr, string targetstr, int count)
        {
            return Replace(source, srcstr, "", targetstr, count);
        }

        /// <summary>
        /// 在源字符串中将 srcstr 字符数组内的每一个字符都 替换成 targetstr 字符；
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="srcstr">字符数组</param>
        /// <param name="targetstr">目的字符</param>
        /// <returns></returns>
        public static string Replace(this string source, char[] srcstr, char targetstr)
        {
            foreach(var chr in srcstr)
            {
                source = source.Replace(chr, targetstr);
            }
            return source;
        }

        /// <summary>
        /// 替换给定字符串中不符合规范的字符，使之成为一个正常的文件名称;
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToFilename(this string source)
        {
            return Replace(source, new char[] { '\\', '/', ':', '|', '>', '<', '*', '?', '\"' }, '_' );
        }

        /// <summary>
        /// Trim后，如果字符串是空字符串，返回 null, 否则，返回 Trim之后的字符串;
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string TrimToNull(string source)
        {
            if (source == null) return null;
            source = source.Trim();
            if (source == "") return null;
            return source;
        }
        /// <summary>
        /// 在源字符串中寻找 beginstr 开头后, 第一个endstr位置的字符串，并替换成 targetstr字符串;
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="beginstr">开头的字符串</param>
        /// <param name="endstr">结尾字符串, 如果本参数为 null,表示从 beginstr 开始，直到结尾字符串全部进行替换</param>
        /// <param name="targetstr">目的字符串</param>
        /// <returns></returns>
        public static string Replace(this string source, string beginstr, string endstr, string targetstr)
        {
            return Replace(source, beginstr, endstr, targetstr, 0);
        }

        /// <summary>
        /// 在源字符串中寻找 beginstr 开头后, endstr位置的字符串，并替换成 targetstr字符串;
        /// 总共进行 count 次替换；
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="beginstr">开头的字符串</param>
        /// <param name="endstr">结尾字符串, 如果本参数为 null,表示从 beginstr 开始，直到结尾字符串全部进行替换;
        ///                      如果 endstr 为 "" ， 则只替换 beginstr 字符串； 
        /// </param>
        /// <param name="targetstr">目的字符串</param>
        /// <param name="count">进行的替换次数，&lt;=0 表示全部替换</param>
        /// <returns></returns>
        public static string Replace(this string source, string beginstr, string endstr, string targetstr, int count)
        {
            int replaceCount = 0;
            int spn = source.IndexOf(beginstr);  //<n></n> 没有传入，替换成 null
            if (spn < 0) return source;
            if (spn >= 0 && endstr == null)
            {
                return source.Substring(0, spn) + targetstr;
            }
            int beginlen = beginstr.Length;
            int endlen = endstr.Length;
            while (spn >= 0)
            {
                int spend = spn + beginlen;
                if (endlen != 0)
                    spend = source.IndexOf(endstr, spn + beginlen);
                if (spend < 0) break;
                string name = source.Substring(spn, spend - spn + endlen);
                source = source.Substring(0, spn) + targetstr + source.Substring(spend + endlen);
                spn = source.IndexOf(beginstr);
                replaceCount++;
                if (replaceCount == count)
                {
                    return source;
                }
            }
            return source;
        }

        /// <summary>
        /// 用空格填充给定数量的字符串； 
        /// </summary>
        /// <param name="spaceCount"></param>
        /// <param name="padding">填充字符串</param>
        /// <returns></returns>
        public static string Padding(int spaceCount, string padding = " ")
        {
            if (spaceCount == 0) return "";
            if (spaceCount == 1) return padding;
            var sb = new StringBuilder();
            for (var index = 0; index < spaceCount; index++)
                sb.Append(padding);
            return sb.ToString();
        }

        /// <summary>
        /// 传入给定的字符串，返回处理的字符串
        /// </summary>
        /// <param name="index"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public delegate void HandleSplitString(ref int index, string source);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="splitChar"></param>
        /// <param name="aHandle"></param>
        public static void SplitAndHandle(this string source, char[] splitChar, HandleSplitString aHandle)
        {
            string[] sources = source.Split(splitChar);
            for (int i = 0; i < sources.Length; i++)
            {
                aHandle(ref i, sources[i]);
            }
        }

        /// <summary>
        /// 传入给定的字符串，返回处理的字符串
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public delegate string HandleString(string source);

        /// <summary>
        /// 在源字符串中寻找 begin 开头, end位置的字符串，用给定函数进行处理以后，
        /// 并将该字符串替换成处理以后的字符串；
        /// 为避免死循环，从处理后字符串继续寻找和下一次处理
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="begin">待处理的开头标记字符串</param>
        /// <param name="end">待处理的结尾标记字符串, 如果本参数为 null,表示从 beginstr 开始，直到结尾字符串全部进行处理;
        ///                      如果 endstr 为 "" ， 则只处理 begin 字符串； 
        /// </param>
        /// <param name="aHandle">对字符串进行处理的函数，返回处理结果字符串</param>
        /// <returns></returns>
        public static string Handle(this string source, string begin, string end, HandleString aHandle)
        {
            int beginIndex = source.IndexOf(begin);  //<n></n> 没有传入，替换成 null
            if (beginIndex < 0) return source;
            if (beginIndex >= 0 && end == null)
            {
                return source.Substring(0, beginIndex) + aHandle(source.Substring(beginIndex));
            }
            int beginLen = begin.Length;
            int endLen = end.Length;
            while (beginIndex >= 0)
            {
                int endIndex = beginIndex + beginLen;
                if (endLen != 0)
                {
                    endIndex = source.IndexOf(end, beginIndex + beginLen);
                }
                if (endIndex < 0) break;
                string beginEndString = source.Substring(beginIndex, endIndex - beginIndex + endLen);  //替换字符串
                string handeledString = aHandle(beginEndString); //
                source = source.Substring(0, beginIndex) + handeledString + source.Substring(endIndex + endLen);
                //为避免死循环，因为处理不一定是替换，也可能是追加字符串，而　ｂｅｇｉｎ　仍然存在于原有的字符串中                         
                beginIndex = source.IndexOf(begin, beginIndex + handeledString.Length);
            }
            return source;
        }

        /// <summary>
        /// 在源字符串中寻找 beginstr 开头后, 第一个endstr位置的字符串，并返回;找不到返回 null;
        /// 例如传入参数分别为: aaaa_bbbb_ccc, _, _时  将返回 _bbbb_
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="beginstr">开头的字符串</param>
        /// <param name="endstr">结尾字符串</param>		
        /// <returns></returns>
        public static string Substring(this string source, string beginstr, string endstr)
        {
            int spn = source.IndexOf(beginstr);  //<n></n> 没有传入，替换成 null            
            int beginlen = beginstr.Length;
            var nextSpn = spn + beginlen;            
            int spend = source.IndexOf(endstr, nextSpn);
            if (spend < 0) return null;
            int endlen = endstr.Length;
            return source.Substring(spn, spend - spn + endlen);
        }

        /// <summary>
        /// 寻找第一个 begin 和 最后1个 last 之间的字符串，如果找不到或者找到的 last的位置小于 begin的位置，
        /// 返回 null;
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="begin"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        public static string FistAndLast(this string source, string begin, string last)
        {
            var beginPos = source.IndexOf(begin);
            var lastPos = source.LastIndexOf(last);
            if (lastPos <= beginPos) return null;
            return source.Substring(beginPos + 1, lastPos - beginPos - 1);
        }

        /// <summary>
        /// 在源字符串中寻找 beginstr 开头后, 第一个endstr位置的中间的字符串 ;
        /// 例如传入参数分别为: aaaa<q>bbbb</q>ccc,<q>,</q> 时  将返回 bbbb
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="beginstr">开头的字符串</param>
        /// <param name="endstr">结尾字符串</param>		
        /// <returns></returns>
        public static string Middle(this string source, string beginstr, string endstr)
        {
            int spn = source.IndexOf(beginstr);  //<n></n> 没有传入，替换成 null
            int beginlen = beginstr.Length;
            int endlen = endstr.Length;
            while (spn >= 0)
            {
                int spend = source.IndexOf(endstr, spn + beginlen);
                if (spend < 0) break;
                string name = source.Substring(spn + beginlen, spend - spn - beginlen);
                return name;
            }
            return null;
        }

        /// <summary>
        /// 在源字符串中寻找 beginstr 开头后, 第一个endstr位置的中间的字符串 ;
        /// 例如传入参数分别为: abbbbca1c,a, c 时  将返回 { "b","1"}
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="beginstr">开头的字符串</param>
        /// <param name="endstr">结尾字符串</param>		
        /// <returns></returns>
        public static List<string> MiddleAll(this string source, string beginstr, string endstr)
        {
            List < string > result = new List<string>();
            int spn = 0;
            int beginlen = beginstr.Length;
            int endlen = endstr.Length;
            spn = source.IndexOf(beginstr, spn);  //<n></n> 没有传入，替换成 null           
            while (spn >= 0)
            {
                int spend = source.IndexOf(endstr, spn + beginlen);
                if (spend < 0) break;
                string name = source.Substring(spn + beginlen, spend - spn - beginlen);
                result.Add(name);
                spn = source.IndexOf(beginstr, spend);  //<n></n> 没有传入，替换成 null       
            }
            return result;
        }

        /// <summary>
        /// 在源字符串中寻找 endstr 开头后, 第一个beginstr位置的中间的字符串 ;
        /// 例如传入参数分别为: &lt;q&gt;aaaa&lt;q&gt;bbbb&lt;/q&gt;ccc,&lt;q&gt;,&lt;/q&gt; 时  将返回 bbbb
        ///                     而 middle 将会返回 aaaa&lt;q&gt;bbbb
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="beginstr">开头的字符串</param>
        /// <param name="endstr">结尾字符串</param>		
        /// <returns></returns>
        public static string ReverseMiddle(this string source, string beginstr, string endstr)
        {
            int spn = source.LastIndexOf(endstr);  //<n></n> 没有传入，替换成 null
            int endLen = endstr.Length;

            int lastBeginPos = -1;
            while (spn >= 0)
            {
                int beginPos = source.IndexOf(beginstr, lastBeginPos < 0 ? 0 : lastBeginPos);
                if (beginPos > spn) break;
                if (beginPos > lastBeginPos)
                {
                    lastBeginPos = beginPos + beginstr.Length;
                    continue;
                }
                else break;
            }
            if (spn < 0 || lastBeginPos < 0 || lastBeginPos > spn) return null;
            return source.Substring(lastBeginPos, spn - lastBeginPos);
        }

        /// <summary>
        /// 在给定字符串中查找某个字符串给定次数出现的位置；
        /// 当 findCount=1 时， 相当于 source.IndexOf(findStr);
        /// 当 findCount=2 时， 相当于 source.IndexOf(findStr, source.IndexOf(findStr)+1);
        /// </summary>
        /// <param name="source"></param>
        /// <param name="findStr"></param>
        /// <param name="findCount"></param>
        /// <returns></returns>
        public static int Find(this string source, string findStr, int findCount)
        {
            int result = -1;
            while (findCount > 0)
            {
                result = source.IndexOf(findStr, result + 1);
                findCount--;
                if (result < 0)
                    return result;
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="trimstr"></param>
        /// <returns></returns>
        public static string Trim(this string source, string trimstr)
        {
            while (source.StartsWith(trimstr)) source = source.Substring(trimstr.Length);
            while (source.EndsWith(trimstr)) source = source.Substring(0, source.Length - trimstr.Length);
            return source;
        }

        /// <summary>
        /// 将原字符间隔成数组，重复的元素剔除，再拼成一个字符串返回；
        /// </summary>
        /// <param name="source"></param>
        /// <param name="split"></param>
        /// <param name="joinStr"></param>
        /// <returns></returns>
        public static string Distinct(this string source, char[] split, string joinStr)
        {
            string[] srcs = source.Split(split);
            List<string> xx = new List<string>();
            foreach (var x in srcs)
            {
                if (xx.IndexOf(x) < 0)
                    xx.Add(x);
            }
            return xx.ToString(joinStr);
        }

        #region 扩展方法


        /// <summary>
        /// 在源字符串中将 srcstr替换成 targetstr字符串;
        /// 但注意：不会全部替换，只会替换指定次数；
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="srcstr">被替换字符串</param>
        /// <param name="targetstr">目的字符串</param>
        /// <param name="count">进行的替换次数，&lt;=0 表示全部替换</param>/// 
        /// <returns></returns>
        public static string FindAndReplace(this string source, string srcstr, string targetstr, int count)
        {
            return source.FindAndReplace(srcstr, "", targetstr, count);
        }

        /// <summary>
        /// 在源字符串中寻找 beginstr 开头后, 第一个endstr位置的字符串，并替换成 targetstr字符串;
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="beginstr">开头的字符串</param>
        /// <param name="endstr">结尾字符串, 如果本参数为 null,表示从 beginstr 开始，直到结尾字符串全部进行替换;
        ///       如果为 空字符串，则表示只处理 beginstr
        /// </param>
        /// <param name="targetstr">目的字符串</param>
        /// <returns></returns>
        public static string FindAndReplaceAll(this string source, string beginstr, string endstr, string targetstr)
        {
            return source.FindAndReplace(beginstr, endstr, targetstr, 0);
        }

        /// <summary>
        /// 在源字符串中寻找 beginstr 开头后, endstr位置的字符串，并替换成 targetstr字符串;
        /// 如果 begin 和 end 均为空字符串，返回 targetstr; 
        /// 如果 begin 和 end 均为 null, 则返回 null;
        /// 总共进行 count 次替换；如果 count&lt;=0,则表示全部替换；
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="begin">开头的字符串</param>
        /// <param name="end">结尾字符串, 如果本参数为 null,表示从 beginstr 开始，直到结尾字符串全部进行替换;
        ///                      如果 endstr 为 "" ， 则只替换 beginstr 字符串； 
        /// </param>
        /// <param name="targetstr">目的字符串</param>
        /// <param name="count">进行替换的最大次数，&lt;=0 表示全部替换</param>
        /// <returns></returns>
        public static string FindAndReplace(this string source, string begin, string end, string targetstr, int count)
        {
            int replaceCount = 0;
            if (begin == null && end == null) return null;
            int beginLen = begin.Length;
            int endLen = end.Length;
            if (beginLen == 0 && endLen == 0) return targetstr;

            int beginIndex = source.IndexOf(begin);  //<n></n> 没有传入，替换成 null
            if (beginIndex < 0) return source;

            if (beginIndex >= 0 && end == null)
            {
                return source.Substring(0, beginIndex) + targetstr;
            }

            while (beginIndex >= 0)
            {
                int endIndex = beginIndex + beginLen;
                if (endLen != 0)
                {
                    endIndex = source.IndexOf(end, beginIndex + beginLen);
                }
                if (endIndex < 0) break;
                string beginEndString = source.Substring(beginIndex, endIndex - beginIndex + endLen);  //替换字符串

                string handeledString = targetstr; //
                source = source.Substring(0, beginIndex) + handeledString + source.Substring(endIndex + endLen);
                replaceCount++;
                if (replaceCount == count) break;
                //为避免死循环，因为处理不一定是替换，也可能是追加字符串，而　ｂｅｇｉｎ　仍然存在于原有的字符串中                         
                beginIndex = source.IndexOf(begin, beginIndex + handeledString.Length);
            }
            return source;
        }

        /// <summary>
        /// 在源字符串中寻找包含 begin开头和 和 end结束 的的字符串，用给定函数进行处理以后，
        /// 并将该字符串替换成处理以后的字符串；
        /// 如果 begin 和  end 均为空字符串，返回原始字符串；
        /// 如果 begin 和  end 均为 null, 返回 aHandle(原始字符串) 的处理结果；
        /// 例如，替换 aaccbbaaxxbb  把　aaccbb 和　aaxxbb 替换成 yy; 
        /// 为避免死循环，从处理后字符串继续寻找和下一次处理
        /// </summary>
        /// <param name="source"></param>
        /// <param name="begin">待处理的开头标记字符串</param>
        /// <param name="end">待处理的结尾标记字符串, 如果本参数为 null,表示从 beginstr 开始，直到结尾字符串全部进行处理;
        ///    如果 endstr 为 "" ， 则只处理 begin 字符串； 
        /// </param>
        /// <param name="aHandle">对字符串进行处理的函数，返回处理结果字符串</param>
        /// <returns></returns>
        public static string FindAndReplace(this string source, string begin, string end, Func<string, string> aHandle)
        {
            if (begin == null && end == null) return aHandle(source);
            int beginLen = begin.Length;
            int endLen = end.Length;
            if (beginLen == 0 && endLen == 0) return source;

            int beginIndex = source.IndexOf(begin);  //<n></n> 没有传入，替换成 null
            if (beginIndex < 0) return source;

            if (beginIndex >= 0 && end == null)
            {
                return source.Substring(0, beginIndex) + aHandle(source.Substring(beginIndex));
            }

            while (beginIndex >= 0)
            {
                int endIndex = beginIndex + beginLen;
                if (endLen != 0)
                {
                    endIndex = source.IndexOf(end, beginIndex + beginLen);
                }
                if (endIndex < 0) break;
                string beginEndString = source.Substring(beginIndex, endIndex - beginIndex + endLen);  //替换字符串

                string handeledString = aHandle(beginEndString); //
                source = source.Substring(0, beginIndex) + handeledString + source.Substring(endIndex + endLen);
                //为避免死循环，因为处理不一定是替换，也可能是追加字符串，而　ｂｅｇｉｎ　仍然存在于原有的字符串中                         
                beginIndex = source.IndexOf(begin, beginIndex + handeledString.Length);
            }
            return source;
        }
       

        /// <summary>
        /// 字符串重复n次的函数; 
        /// </summary>
        /// <param name="src"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string Multi(this string src, int count)
        {
            if (count == 0) return "";
            else if (count == 1) return src;
            else if (count == 2) return src + src;
            else
            {
                var sb = new StringBuilder(src, src.Length * count--);
                while (count-- > 0) sb.Append(src);
                return sb.ToString();
            }
        }

        /// <summary>
        /// 将字符串使用逗号拆分后再转换成给定的格式;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="split"></param>
        /// <returns></returns>
        public static T[] Split<T>(this string source, string split)
        {
            var chr = '羙';
            source = source.Replace(split, "羙");
            return Split<T>(source, new char[] { chr });
        }

        /// <summary>
        /// 将字符串使用逗号拆分后再转换成给定的格式;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="split"></param>
        /// <returns></returns>
        public static T[] Split<T>(this string source,char split=',')
        {
            return Split<T>(source, new char[] { split });
        }

        /// <summary>
        /// 字符串拆分，并转换成给定类型； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">如果为 null 或者 空字符串，返回空数组 ； </param>
        /// <param name="splitChar"></param>
        /// <returns></returns>
        public static T[] Split<T>(this string source, char[] splitChar)
        {
            if (string.IsNullOrEmpty(source)) return new T[] { };
            source = source.Trim(splitChar);
            string[] sources = source.Split(splitChar);
            T[] result = new T[sources.Length];
            for (var index=0; index<result.Length; index++)
            {
                if (string.IsNullOrEmpty(sources[index])) continue; //去除空字符串;
                result[index] = (T) Convert.ChangeType(sources[index], typeof(T));
            }
            return result; 
        }

        /// <summary>
        /// 字符串拆分，并转换成给定类型； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">如果为 null 或者 空字符串，返回空数组 ； </param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static List<T> Split<T>(this string source, Func<string, T> func)
        {
            return Split(source, func, new char[] { ',' });
        }
        /// <summary>
        /// 字符串拆分，并转换成给定类型； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">如果为 null 或者 空字符串，返回空数组 ； </param>
        /// <param name="func"></param>
        /// <param name="splitChar"></param>
        /// <returns></returns>
        public static List<T> Split<T>(this string source, Func<string,T> func, char[] splitChar)
        {
            if (string.IsNullOrEmpty(source)) return new List<T>();
            string[] sources = source.Split(splitChar);
            List<T> result = new List<T>(); //[sources.Length];
            for (var index = 0; index < sources.Length; index++)
            {
                if (sources[index] == string.Empty) continue;
                result.Add(func(sources[index]));
            }
            return result;
        }

        /// <summary>
        /// 对字符串进行拆分，并对拆分后的每一个字符串进行处理；
        /// </summary>
        /// <param name="source"></param>
        /// <param name="splitChar">需要进行拆分的字符数组</param>
        /// <param name="ahandle">对字符串进行的处理操作，int - 表示索引，　string - 表示子字符串; </param>
        public static string SplitAndHandle(this string source, char[] splitChar, Action<int, string> ahandle)
        {
            string[] sources = source.Split(splitChar);
            for (int i = 0; i < sources.Length; i++)
            {
                ahandle(i, sources[i]);
            }
            return source;
        }

        /// <summary>
        /// 对字符串进行拆分，并对拆分后的每一个字符串进行处理；
        /// 如果处理结果&lt;0,则不处理余下的字符串；
        /// 如果处理结果&gt;0,则重置当前拆分数组的处理索引；并从处理结果位置起重新进行处理；
        /// </summary>
        /// <param name="source"></param>
        /// <param name="splitChar">需要进行拆分的字符数组</param>
        /// <param name="ahandle">对字符串进行的处理操作，int - 表示索引，　string - 表示子字符串;
        ///  返回结果表示是否继续处理剩余　或者　下一次处理的拆分后字符串数组的索引位置；
        /// </param>
        public static string SplitAndHandle(this string source, char[] splitChar, Func<int, string, int> ahandle)
        {
            string[] sources = source.Split(splitChar);
            for (int i = 0; i < sources.Length; i++)
            {
                int x = ahandle(i, sources[i]);
                if (x < 0) break;
                i = x;
            }
            return source;
        }

        /// <summary>
        /// 将原字符间隔成数组，剔除重复元素，再用给定的连接字符串拼成一个字符串返回；
        /// </summary>
        /// <param name="source"></param>
        /// <param name="split">拆分的字符数组</param>
        /// <param name="joinStr">连接字符串</param>
        /// <returns></returns>
        public static string SplitAndRemoveRepeat(this string source, char[] split, string joinStr)
        {
            string[] srcs = source.Split(split);
            List<string> xx = new List<string>();
            foreach (var x in srcs)
            {
                if (xx.IndexOf(x) < 0)
                    xx.Add(x);
            }
            return xx.Join(joinStr);
        }

        /// <summary>
        /// 将原字符间隔成数组，对于数组里面的每一个元素，用给定处理函数进行处理，
        /// 处理结果用于替换该元素内容，最后，再用给定的连接字符串拼成一个字符串返回；
        /// 请特别注意，对于 \r\n 的处理，因为当你要替换某一行但需要维持空行时可能无法实现你想要的效果，        
        /// 你可能传入 \n 来进行拆分，
        /// 但 连接字符串你只传入了 \n 时，将无法通过测试， 
        /// 例如, 对于 aa\r\n\bb\r\n\cc, 你想要替换 bb 这一行并保持空行，
        /// SplitAndReplace(new char[]{'\n'},(str)=>{ if (str=="bb") return ""; else return str; }, "\n", true)
        /// 将返回 aa\r\n\nbb\r\ncc 而不会是你想要的 aa\r\n\r\n\r\ncc; 
        /// 你可以使用　SplitAndReplaceLine 函数; 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="split">拆分的字符数组</param>        
        /// <param name="func">对字符串的处理函数，传入字符串，返回字符串</param>
        /// <param name="joinStr">连接字符串</param>
        /// <param name="maintainNullLine">是否维持空行－－true:维持， false-不维持空行</param>
        /// <returns></returns>
        public static string SplitAndReplace(this string source, char[] split, Func<string, string> func, string joinStr,
            bool maintainNullLine)
        {
            if (source == null) return null;
            if (source == "") return "";
            string[] srcs = source.Split(split);
            List<string> xx = new List<string>();
            foreach (var x in srcs)
            {
                string handledX = func(x);
                if (handledX.Length > 0) xx.Add(handledX);
                else
                {
                    if (maintainNullLine) xx.Add(handledX);
                }
            }
            return xx.Join(joinStr);
        }

        /// <summary>
        /// 将原字符拆分成行，对于字符串里面的每一行，用给定处理函数进行处理，
        /// 处理结果用于替换行内容，注意，你可能传如 windows 的字符串,
        /// 但在其他平台下，将使用其它平台的字符串行间隔；
        /// </summary>
        /// <param name="source">源字符串</param>        
        /// <param name="func">对字符串的处理函数，传入字符串，返回字符串,请注意，　</param>        
        /// <param name="maintainNullLine">是否维持空行－－true:维持， false-不维持空行</param>
        /// <returns></returns>
        public static string SplitAndReplaceLine(this string source, Func<string, string> func, bool maintainNullLine)
        {
            if (source == null) return null;
            if (source == "") return source;
            string[] srcs = source.Split('\n');
            List<string> xx = new List<string>();
            foreach (var x in srcs)
            {
                var ax = x.TrimEnd(new char[] { '\r' });
                string handledX = func(ax);
                if (handledX.Length > 0) xx.Add(handledX);
                else
                {
                    if (maintainNullLine) xx.Add(handledX);
                }
            }
            return xx.Join(Environment.NewLine);
        }

        #endregion

        /// <summary>
        /// 例如，如下字符串 {  abc { } } , 将找到 { abc { } } 而不是 { abc { } 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="beginPosition"></param>
        /// <returns></returns>
        public static string MiddelWithLoop(this string source, char begin, char end, int beginPosition = 0)
        {
            int count = 0;
            int beginPos = source.IndexOf(begin, beginPosition);
            if (beginPos < 0) return null;
            count++;
            char[] chars = source.ToCharArray();
            int index = beginPos + 1;
            for (; index<chars.Length; index++)
            {
                if (chars[index] == begin) count++;
                else if (chars[index] == end) count--;
                if (count == 0) break;
            }
            if (count != 0) return null; 
            return source.Substring(beginPos, index - beginPos + 1);
        }
    }
}
