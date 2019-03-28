namespace youzan.com.youzan.push
{
    /// <summary>
    /// 物流事件 TRADE_ORDER_EXPRESS
    /// </summary>
    class PushMessage_TradeOrderExpress
    {
        ///<sumary>
        ///订单号
        ///E20171234567890123456789
        ///</sumary>
        public string tid { get; set; }
        ///<sumary>
        ///交易明细编号
        ///123455532
        ///</sumary>
        public decimal oids { get; set; }
        ///<sumary>
        ///物流类型
        ///4
        ///</sumary>
        public decimal express_id { get; set; }
        ///<sumary>
        ///物流单号
        ///1212312312312
        ///</sumary>
        public string express_no { get; set; }
        ///<sumary>
        ///更新时间
        ///42874.4166666667
        ///</sumary>
        public string update_time { get; set; }



    }
}
