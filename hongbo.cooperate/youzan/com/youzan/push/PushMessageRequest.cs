using Newtonsoft.Json;
using System;
using System.Text;
using System.Web;

namespace youzan.com.youzan.push
{
    /// <summary>
    /// 推送消息的接入请求
    /// https://www.youzanyun.com/docs/guide/3401/3448
    /// https://www.youzanyun.com/docs/guide/3401/3449
    /// </summary>
    public class PushMessageRequest
    {
        /// <summary>
        /// 1-自用型/工具型/平台型消息；0-签名模式消息
        /// </summary>
        public int mode { get; set; }

        /// <summary>
        /// 业务消息的标识: 如 订单消息为订单编号, 会员卡消息为会员卡id标识
        /// </summary>
        public String id { get; set; }

        /// <summary>
        /// 对应开发者后台的client_id
        /// </summary>
        public String client_id { get; set; }

        /// <summary>
        /// 消息业务类型：PushMessageConst ， 但不是枚举类型，因为总是有莫名奇妙的消息传入进来
        /// TRADE_ORDER_STATE-订单状态事件，TRADE_ORDER_REFUND-退款事件，TRADE_ORDER_EXPRESS-物流事件，ITEM_STATE-商品状态事件，ITEM_INFO-商品基础信息事件，POINTS-积分，SCRM_CARD-会员卡（商家侧），SCRM_CUSTOMER_CARD-会员卡（用户侧），TRADE-交易V1，ITEM-商品V1
        /// 噗通的是，事件肯定不只是上面这几种的..
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 消息状态，对应消息业务类型。如TRADE_ORDER_STATE-订单状态事件，对应有等待买家付款（WAIT_BUYER_PAY）、等待卖家发货（WAIT_SELLER_SEND_GOODS）等多种状态，详细可参考 消息结构里的描述
        /// </summary>
        public String status { get; set; }

        /// <summary>
        /// 经过UrlEncode（UTF-8）编码的消息对象，具体参数请看本页中各业务消息结构文档
        /// </summary>
        public String msg { get; set; }

        /// <summary>
        ///  店铺ID
        /// </summary>
        public int kdt_id { get; set; }

        /// <summary>
        ///  防伪签名 ：MD5(client_id+msg+client_secrect)
        /// </summary>
        public String sign { get; set; }

        /// <summary>
        /// 消息版本号，为了解决顺序性的问题 ，高版本覆盖低版本
        /// </summary>
        public long version { get; set; }

        /// <summary>
        /// -非测试消息，true- 测试消息 ；PUSH服务会定期通过发送测试消息检查开发者服务是否正常
        /// </summary>
        public bool test { get; set; }
        /// <summary>
        ///   重发的次数
        /// </summary>
        public int send_count { get; set; }

        /// <summary>
        /// 返回解码后的 msg 字段内容，
        /// </summary>
        public string DecodeMessage
        {
            get
            {
                if (string.IsNullOrEmpty(this.msg)) return null;
                return HttpUtility.UrlDecode(this.msg, Encoding.UTF8);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public object ConvertToDetailMessage()
        {
            var decodeMsg = DecodeMessage;
            if (string.IsNullOrEmpty(decodeMsg)) return null;
            switch (type)
            {
                case EnumYouzanPushMessageType.ITEM_INFO:
                    var jsonContent = JsonConvert.DeserializeObject<PushMessageResultWrapper>(decodeMsg).data;
                    return JsonConvert.DeserializeObject<PushMessage_ItemInfo>(jsonContent);
                case EnumYouzanPushMessageType.TRADE_ORDER_STATE:
                    return JsonConvert.DeserializeObject<PushMessage_TradeOrderState>(decodeMsg);
                //case EnumYouzanPushMessageType.TRADE:    //返回了交易明细
                //    return JsonConvert.DeserializeObject<YouzanTradeGetResult>(decodeMsg);
                //case EnumYouzanPushMessageType.ITEM:
                //    return JsonConvert.DeserializeObject<YouzanItemGetResult>(decodeMsg);
                }
            return null;
        }
    }


}
