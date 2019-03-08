using System;
using System.Collections.Generic;
using System.Text;

namespace hongbao.LbsExtension
{

    /// <summary>
    /// GPS 坐标以及地址信息； 
    /// </summary>
    public class Gps
    {
        /// <summary>
        /// 经度；
        /// </summary>
        public decimal Longtitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 详细地址； 
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 区域； 
        /// </summary>
        public string district { get; set; }

        /// <summary>
        /// 街道名称，说明，只有在坐标解析时才有此数据；
        /// 解析地址时可能出错，用处不大，屏蔽掉;
        /// </summary>
        /// public string township { get; set;  }
        /// <summary>
        /// 建筑物名称，说明，只有在坐标解析时才有此数据；
        /// </summary>
        public string building { get; set; }

        /// <summary>
        ///  建筑物类型，说明，只有在坐标解析时才有此数据；
        /// </summary>
        public string buildingType { get; set; }
    }
}
