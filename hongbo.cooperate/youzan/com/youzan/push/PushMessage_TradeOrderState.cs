using System;

namespace youzan.com.youzan.push
{
    /// <summary>
    /// 订单状态事件 TRADE_ORDER_STATE
    /// ：订单消息推送的是订单简要信息，非所有字段，如果推送的字段没法满足使用需求，可以配合订单详情接口 https://www.youzanyun.com/apilist/detail/group_trade/trade/youzan.trade.get 使用。包括会员、积分等消息也是一样的情况
    /// </summary>
    public class PushMessage_TradeOrderState
    {
        ///<sumary>
        ///订单号
        ///E20171234567890123456789
        ///</sumary>
        public string tid { get; set; }
        ///<sumary>
        ///订单状态
        ///WAIT_BUYER_PAY(等待买家付款)；
        ///WAIT_CONFIRM (等待确认，买家已付款，等待商家确认。包括 拼团订单的待成团，外卖订单的待接单)；
        ///WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款)；
        ///WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货)；
        ///TRADE_SUCCESS(交易成功)；TRADE_CLOSED(交易关闭)
        ///</sumary>
        public String status { get; set; }
        ///<sumary>
        ///订单金额（单位：元）
        ///0.01
        ///</sumary>
        public decimal payment { get; set; }
        ///<sumary>
        ///更新时间
        ///42874.4166666667
        ///</sumary>
        public string update_time { get; set; }


    }
}
