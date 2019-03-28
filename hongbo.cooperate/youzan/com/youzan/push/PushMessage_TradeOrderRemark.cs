namespace youzan.com.youzan.push
{
    /// <summary>
    /// 订单备注事件 TRADE_ORDER_REMARK
    /// </summary>
    class PushMessage_TradeOrderRemark
    {
        ///<sumary>
        ///订单号
        ///E20171234567890123456789
        ///</sumary>
        public string tid { get; set; }
        ///<sumary>
        ///订单星级
        ///0
        ///</sumary>
        public decimal star { get; set; }
        ///<sumary>
        ///备注内容
        ///测试
        ///</sumary>
        public string seller_memo { get; set; }
        ///<sumary>
        ///更新时间
        ///42874.4166666667
        ///</sumary>
        public string update_time { get; set; }


    }
}
