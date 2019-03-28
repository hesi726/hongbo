namespace youzan.com.youzan.push
{
    /// <summary>
    /// 退款事件 TRADE_ORDER_REFUND
    /// </summary>
    class PushMessage_TradeOrderRefund
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
        public decimal oid { get; set; }
        ///<sumary>
        ///退款id
        ///W32132132122321
        ///</sumary>
        public string refund_id { get; set; }
        ///<sumary>
        ///退款状态
        ///SAFE_NEW（买家发起）；SAFE_HANDLED（被拒绝后再次发起）；SAFE_REJECT（卖家拒绝）；SAFE_INVOLVED（客服介入）；SAFE_ACCEPT（卖家接受）；SAFE_SEND（买家发货）；SAFE_NO_RECEIVE（卖家没有收到货）；SAFE_CLOSE（维权关闭）；SAFE_FINISHED（维权结束）
        ///</sumary>
        public string refund_state { get; set; }
        ///<sumary>
        ///更新时间
        ///42874.4166666667
        ///</sumary>
        public string update_time { get; set; }
        ///<sumary>
        ///退款金额
        ///0.01
        ///</sumary>
        public decimal refunded_fee { get; set; }
        ///<sumary>
        ///退款类型
        ///REFUND_ONLY（仅退款）；REFUND_AND_RETURN（退货退款）
        ///</sumary>
        public string refund_type { get; set; }
        ///<sumary>
        ///退款原因
        ///仅退款，未收到货申请原因：REFUND_QUALITY（质量问题）；
        ///REFUND_BUYWRONG（拍错/多拍/不喜欢）；
        ///REFUND_INCONFORMITY（商品描述不符）；
        ///REFUND_FAKE（假货）；
        ///REFUND_SENDWRONG（商家发错货）；
        ///REFUND_GOODSLESS（商品破损/少件）；
        ///REFUND_OTHER（其他）；仅退款，已收到货申请原因：
        ///RETURNSNOT_BUYWRONG（多买/买错/不想要）；
        ///RETURNSNOT_NULLEXPRESS（快递无记录）；
        ///RETURNSNOT_GOODSLESS（少货/空包裹）；
        ///RETURNSNOT_NOTEXPRESS_ONTIME（未按约定时间发货）；
        ///RETURNSNOT_NOTRECEIVE（快递一直未送达）；
        ///RETURNSNOT_OTHER（快递一直未送达）；退货退款，申请原因：
        ///RETURNS_GOODSLESS（商品破损/少件）；
        ///RETURNS_SENDWRONG（商家发错货）；
        ///RETURNS_INCONFORMITY（商品描述不符）；
        ///RETURNS_BUYWRONG（拍错/多拍/不喜欢）；
        ///RETURNS_QUALITY（质量问题）；
        ///RETURNS_FAKE（假货）；
        ///RETURNS_OTHER（其他）
        ///</sumary>
        public string refund_reason { get; set; }



    }
}
