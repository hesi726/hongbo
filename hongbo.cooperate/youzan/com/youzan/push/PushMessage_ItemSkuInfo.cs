using System;

namespace youzan.com.youzan.push
{
    /// <summary>
    /// https://www.youzanyun.com/docs/guide/3401/3456
    /// 商品基础信息事件 ITEM_INFO
    /// </summary>
    public class PushMessage_ItemSkuInfo
    {
        ///<sumary>
        ///商品ID
        ///
        ///</sumary>
        public long item_id { get; set; }
        ///<sumary>
        ///店铺ID
        ///
        ///</sumary>
        public long kdt_id { get; set; }
        ///<sumary>
        ///规格库存数量
        ///
        ///</sumary>
        public long stock_num { get; set; }
        ///<sumary>
        ///规格库存价格
        ///
        ///</sumary>
        public long price { get; set; }
        ///<sumary>
        ///规格商家编码
        ///
        ///</sumary>
        public String code { get; set; }

    }

}
