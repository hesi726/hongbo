using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// DateTime 的扩展方法类； 
    /// </summary>
    public static class DateTimeUtil
    {
        /// <summary>
        /// 执行一个动作并进行计时;
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static long Calculate(Action action)
        {
            DateTime begin = DateTime.Now;
            action();
            DateTime end = DateTime.Now;
            return (long) (end - begin).TotalMilliseconds;
        }

        /// <summary>
        /// 执行一个动作并进行计时;
        /// </summary>
        /// <param name="action"></param>
        /// <param name="tips"></param>
        /// <param name="log"></param>
        /// <returns></returns>
        public static void Calculate(Action action, string tips, Action<string> log)
        {
            DateTime begin = DateTime.Now;
            log?.Invoke("准备执行 " + tips);
            action();
            DateTime end = DateTime.Now;
            log?.Invoke("完成执行 " + tips + ",共计花费时间:" + (end - begin).TotalSeconds);
        }
        /// <summary>
        /// 根据传入的2个时间判断是否存在变化且未更新;
        /// changeDateTime 为 null，返回 false;
        /// 否则如果 updateToDeviceDateTime 为 null, 返回 true;
        /// 否则如果 changeDateTime >= updateToDeviceDateTime, 返回 true,
        /// 否则， 返回 false;
        /// </summary>
        /// <returns></returns>
        public static bool ChangeAndNotUpdate(DateTime? changeDateTime, DateTime? updateToDeviceDateTime)
        {
            if (!changeDateTime.HasValue) return false;
            if (changeDateTime.HasValue && !updateToDeviceDateTime.HasValue) return true;
            if (changeDateTime.Value >= updateToDeviceDateTime) return true;
            return false;
        }
        /// <summary>
        /// 获取给定日期所在月的开始日期； 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime MonthBeginDate(this DateTime date)
        {
            return date.Date.AddDays(-1 * (int)date.Day + 1);
        }

        /// <summary>
        /// 获取给定日期所在月的结束日期； 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime MonthEndDate(this DateTime date)
        {
            return date.Date.AddDays(-1 * (int)date.Day + 1).AddMonths(1).AddDays(-1);
        }
        /// <summary>
        /// 获取给定日期所在周 下一周的开始日期； 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime NextWeekBeginDate(this DateTime date)
        {
            return date.Date.AddDays(-1 * (int)date.DayOfWeek + 7);
        }
        /// <summary>
        /// 获取给定日期所在月上一个月的开始日期； 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime PriorMonthBeginDate(this DateTime date)
        {
            return date.Date.AddDays(-1 * (int)date.Day + 1).AddMonths(-1);
        }

        /// <summary>
        /// 获取给定日期所在月上一个月的结束日期； 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime PriorMonthEndDate(this DateTime date)
        {
            return date.Date.AddDays(-1 * (int)date.Day);
        }
        /// <summary>
        /// 获取给定日期所在周上周的开始日期； 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime PriorWeekBeginDate(this DateTime date)
        {
            return date.Date.AddDays(-1 * (int)date.DayOfWeek - 7);
        }

        /// <summary>
        /// 获取给定日期所在周上周的结束日期； 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime PriorWeekEndDate(this DateTime date)
        {
            return date.Date.AddDays(-1 * (int)date.DayOfWeek - 1);
        }
        /// <summary>
        /// 获得时间字符串所代表的秒数;
        /// </summary>
        /// <param name="time">08:00 或者 09:00, 如果为空字符，返回null; </param>
        /// <returns></returns>
        public static int? Second(string time)
        {
            if (!string.IsNullOrEmpty(time))
            {
                var datetime = DateTime.ParseExact(time.Length > 5 ? time.Substring(0, 5) : time, "HH:mm",
                    CultureInfo.CurrentCulture);
                return (int)(datetime - datetime.Date).TotalSeconds;
            }
            return null;
        }

        /// <summary>
        /// 传入从0点开始经过的秒数，返回时间; 例如, 传入 3600,返回 01:00
        /// </summary>
        /// <param name="second">从0点开始经过的秒数</param>
        /// <returns></returns>
        public static string Time(int? second)
        {
            if (!second.HasValue) return "";
            return DateTime.Today.AddSeconds(second.Value).ToString("HH:mm");
        }
        /// <summary>
        /// 比较给定日期的时间部分是否在给定开始和结束时间的时间部分以内；
        /// 注意，只比较时间部分；暂时只比较时间的时钟和分钟部分；秒不进行比较了；
        /// </summary>
        /// <param name="date"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static bool TimeBetween(this DateTime date, DateTime begin, DateTime end)
        {
            bool greatBegin = (begin.Hour < date.Hour || (begin.Hour == date.Hour && begin.Minute <= date.Minute));
            bool lowerEnd = (date.Hour < end.Hour || (date.Hour == end.Hour && date.Minute <= end.Minute));
            return greatBegin && lowerEnd;
        }
        /// <summary>
        /// 包含毫秒的日期时间字符串;
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static string ToFullDateTimeString(this DateTime datetime)
        {
            return datetime.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
        /// <summary>
        /// 将时间截断给定的部分，注意，将会一直截断此后部分，例如，截断 分钟，则分钟，妙，毫秒 都会一并截断； ； 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="datePart"></param>
        /// <returns></returns>
        public static DateTime Trunc(this DateTime date, Enum_DatePart datePart)
        {
            switch (datePart)
            {
                case Enum_DatePart.MillSecond:
                    return date.AddMilliseconds(-1 * date.Millisecond);
                case Enum_DatePart.Second:
                    return date.AddMilliseconds(-1 * date.Millisecond).AddSeconds(-1 * date.Second);
                case Enum_DatePart.Minute:
                    return date.AddMilliseconds(-1 * date.Millisecond).AddSeconds(-1 * date.Second).AddMinutes(-1 * date.Minute);
                case Enum_DatePart.Hour:
                    return date.Date;
                case Enum_DatePart.Week:
                    return date.WeekBeginDate();
                case Enum_DatePart.Month:
                    return date.MonthBeginDate();
                case Enum_DatePart.Year:
                    return DateTime.Parse(date.ToString("yyyy") + "-01-01");
            }
            return date;
        }
        /// <summary>
        /// 获取给定日期所在周的开始日期； 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime WeekBeginDate(this DateTime date)
        {
            return date.Date.AddDays(-1 * (int) date.DayOfWeek);
        }


        /// <summary>
        /// 获取给定日期所在周的结束日期； 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime WeekEndDate(this DateTime date)
        {
            return date.Date.AddDays(-1 * (int)date.DayOfWeek + 6);
        } 
    }

    /// <summary>
    /// 日期的各个段落部分； 
    /// </summary>
    public enum Enum_DatePart
    {
        /// <summary>
        /// 毫秒；
        /// </summary>
        MillSecond = 0,
        /// <summary>
        /// 秒
        /// </summary>
        Second,
        /// <summary>
        /// 分钟
        /// </summary>
        Minute,
        /// <summary>
        /// 小时
        /// </summary>
        Hour,
        /// <summary>
        /// 截断到周
        /// </summary>
        Week,
        /// <summary>
        /// 截断到月
        /// </summary>
        Month,
        /// <summary>
        /// 截断到年； 
        /// </summary>
        Year
    }
}
