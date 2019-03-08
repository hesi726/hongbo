using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 日期段接口; 
    /// </summary>
    public interface IDateRange
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        [Column(TypeName = "Date")]
        DateTime BeginDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [Column(TypeName = "Date")]
        DateTime EndDate { get; set; }
    }

    /// <summary>
    /// 日期段接口; 
    /// </summary>
    public interface IDateTimeRange
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        DateTime BeginDateTime { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        DateTime EndDateTime { get; set; }
    }

    /// <summary>
    /// 日期范围的扩展接口;
    /// </summary>
    public static class IDateRangeExtension
    {
        /// <summary>
        /// 复制;
        /// </summary>
        /// <param name="dateRange"></param>
        /// <param name="dest"></param>
        public static void Copy(this IDateRange dateRange, IDateRange dest)
        {
            dest.BeginDate = dateRange.BeginDate;
            dest.EndDate = dateRange.EndDate;
        }

        /// <summary>
        /// 复制;
        /// </summary>
        /// <param name="dateRange"></param>
        /// <param name="dest"></param>
        public static void Copy(this IDateTimeRange dateRange, IDateTimeRange dest)
        {
            dest.BeginDateTime = dateRange.BeginDateTime;
            dest.EndDateTime = dateRange.EndDateTime;
        }

        /// <summary>
        /// 比较两个日期，并对日期有交叉部分进行处理;
        /// 如果日期不交叉，不进行任何处理;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="range1">日期范围对象1</param>
        /// <param name="range2">日期范围对象2</param>
        /// <param name="begin1LowerBegin2_End1GreatEnd2">开始日期1小于等于开始日期2，并且结束日期1大于等于结束日期2 的行为处理</param>
        /// <param name="begin1LowerBegin2_End1GreatBegin2_End1LowerEnd2">开始日期1小于等于开始日期2，并且结束日期1大于开始日期2和小于结束日期2 的行为处理</param>
        /// <param name="begin1GreatBegin2_Begin1LowerEnd2_End1GreatEnd2">开始日期1大于开始日期2,且小于结束日期2，并且结束日期1大于结束日期2 的行为处理</param>
        /// <param name="begin1GreatBegin2_End1LowerEnd2">开始日期1大于开始日期2，并且结束日期1小于结束日期2 的行为处理</param>
        public static void DicarlDateRange<T, K>(T range1, K range2,
            Action<T, K> begin1LowerBegin2_End1GreatEnd2,
            Action<T, K> begin1LowerBegin2_End1GreatBegin2_End1LowerEnd2,
            Action<T, K> begin1GreatBegin2_Begin1LowerEnd2_End1GreatEnd2,
            Action<T, K> begin1GreatBegin2_End1LowerEnd2

        )
            where T : IDateRange
            where K : IDateRange
        {
            if (range1.BeginDate >= range2.EndDate ||
               range1.EndDate <= range2.BeginDate) return; //无任何时间交叉记录;
            if (range1.BeginDate <= range2.BeginDate)
            {
                if (range1.EndDate >= range2.EndDate)
                {
                    begin1LowerBegin2_End1GreatEnd2(range1, range2);
                    return;
                }
                else if (range1.EndDate < range2.EndDate)
                {
                    begin1LowerBegin2_End1GreatBegin2_End1LowerEnd2(range1, range2);
                }
            }
            else if (range1.BeginDate > range2.BeginDate)
            {
                if (range1.EndDate >= range2.EndDate)
                {
                    begin1GreatBegin2_Begin1LowerEnd2_End1GreatEnd2(range1, range2);
                }
                else
                {
                    begin1GreatBegin2_End1LowerEnd2(range1, range2);
                }
            }
        }

        /// <summary>
        /// 比较两个日期，并对日期有交叉部分进行处理;
        /// 如果日期不交叉，不进行任何处理;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="range1">日期范围对象1</param>
        /// <param name="range2">日期范围对象2</param>
        /// <param name="begin1LowerBegin2_End1GreatEnd2">开始日期1小于等于开始日期2，并且结束日期1大于等于结束日期2 的行为处理</param>
        /// <param name="begin1LowerBegin2_End1GreatBegin2_End1LowerEnd2">开始日期1小于等于开始日期2，并且结束日期1大于开始日期2和小于结束日期2 的行为处理</param>
        /// <param name="begin1GreatBegin2_Begin1LowerEnd2_End1GreatEnd2">开始日期1大于开始日期2,且小于结束日期2，并且结束日期1大于结束日期2 的行为处理</param>
        /// <param name="begin1GreatBegin2_End1LowerEnd2">开始日期1大于开始日期2，并且结束日期1小于结束日期2 的行为处理</param>
        public static void DicarlDateTimeRange<T,K>(T range1, K range2,
            Action<T, K> begin1LowerBegin2_End1GreatEnd2,
            Action<T, K> begin1LowerBegin2_End1GreatBegin2_End1LowerEnd2,
            Action<T, K> begin1GreatBegin2_Begin1LowerEnd2_End1GreatEnd2,
            Action<T, K> begin1GreatBegin2_End1LowerEnd2

        )
            where T : IDateTimeRange
            where K : IDateTimeRange
        {
            if (range1.BeginDateTime >= range2.EndDateTime ||
               range1.EndDateTime <= range2.BeginDateTime) return; //无任何时间交叉记录;
            if (range1.BeginDateTime <= range2.BeginDateTime)
            {
                if (range1.EndDateTime >= range2.EndDateTime)
                {
                    begin1LowerBegin2_End1GreatEnd2(range1, range2);
                    return;
                }
                else if (range1.EndDateTime < range2.EndDateTime)
                {
                    begin1LowerBegin2_End1GreatBegin2_End1LowerEnd2(range1, range2);
                }
            }
            else if (range1.BeginDateTime > range2.BeginDateTime)
            {
                if (range1.EndDateTime >= range2.EndDateTime)
                {
                    begin1GreatBegin2_Begin1LowerEnd2_End1GreatEnd2(range1, range2);
                }
                else
                {
                    begin1GreatBegin2_End1LowerEnd2(range1, range2);
                }
            }
        }
    }

}
