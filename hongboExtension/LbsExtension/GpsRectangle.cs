using System;
using System.Collections.Generic;
using System.Text;

namespace hongbao.LbsExtension
{
    /// <summary>
    /// 一个GPS的区域；
    /// </summary>
    public class GpsRectangle
    {
        /// <summary>
        /// 顶部纬度
        /// </summary>
        public decimal Top { get; set; }

        /// <summary>
        /// 底部纬度
        /// </summary>
        public decimal Bottom { get; set; }

        /// <summary>
        /// 左边经度
        /// </summary>
        public decimal Left { get; set; }

        /// <summary>
        /// 右边经度；
        /// </summary>
        public decimal Right { get; set; }
    }

}
