namespace youzan.com.youzan.push
{
    /// <summary>
    /// 有赞推送的消息类型枚举，但注意是字符串，避免未定义的消息类型导致接收消息出错;
    /// https://www.youzanyun.com/docs/guide/3401/3449
    /// </summary>
    public class EnumYouzanPushMessageType
    {
        /// <summary>
        /// 订单状态事件 TRADE_ORDER_STATE
        /// </summary>
        public const string  TRADE_ORDER_STATE = "TRADE_ORDER_STATE";

        /// <summary>
        /// 订单备注事件 TRADE_ORDER_REMARK
        /// </summary>
        public const string TRADE_ORDER_REMARK = "TRADE_ORDER_REMARK";

        /// <summary>
        /// 退款事件 TRADE_ORDER_REFUND
        /// </summary>
        public const string TRADE_ORDER_REFUND = "TRADE_ORDER_REFUND";

        /// <summary>
        /// 物流事件 TRADE_ORDER_EXPRESS
        /// </summary>
        public const string TRADE_ORDER_EXPRESS = "TRADE_ORDER_EXPRESS";

        /// <summary>
        /// 商品状态事件 ITEM_STATE
        /// 商品消息推送的是商品简要信息，非所有字段，所有推送的字段没法满足使用需求，可以配合订单详情接口 https://www.youzanyun.com/apilist/detail/group_item/item/youzan.item.get使用。 包括其他会员、积分等信息也是一样情况。
        /// </summary>
        public const string ITEM_STATE = "ITEM_STATE";

        ///<sumary>
        ///商品基础信息事件 ITEM_INFO
        ///</sumary>
        public const string ITEM_INFO = "ITEM_INFO";

        ///<sumary>
        ///商品规格信息事件 ITEM_SKU_INFO
        ///</sumary>
        public const string ITEM_SKU_INFO = "ITEM_SKU_INFO";

        /// <summary>
        /// TRADE-交易V1， 但是根据文档，此消息可能不会再推送了
        /// </summary>
        public const string TRADE = "TRADE";

        /// <summary>
        /// ITEM-商品V1， 但是根据文档，此消息可能不会再推送了
        /// </summary>
        public const string ITEM = "ITEM";

        /// <summary>
        /// 客户变化通知 -- 微信用户、淘宝用户 等等用户;
        /// </summary>
        public const string SCRM_CUSTOMER_EVENT = "SCRM_CUSTOMER_EVENT";



    }

    /// <summary>
    /// 商品状态事件	status 值
    /// </summary>
    public class EnumYouzan_TradeOrderState_Status
    {
        ///<sumary>
        ///等待买家付款
        ///</sumary>
        public const string WAIT_BUYER_PAY = "WAIT_BUYER_PAY";

        ///<sumary>
        ///待确认，包括（待成团：拼团订单、待接单：外卖订单）
        ///</sumary>
        public const string WAIT_CONFIRM = "WAIT_CONFIRM";

        ///<sumary>
        ///等待卖家发货，即:买家已付款
        ///</sumary>
        public const string WAIT_SELLER_SEND_GOODS = "WAIT_SELLER_SEND_GOODS";

        ///<sumary>
        ///等待买家确认收货,即:卖家已发货
        ///</sumary>
        public const string WAIT_BUYER_CONFIRM_GOODS = "WAIT_BUYER_CONFIRM_GOODS";

        ///<sumary>
        ///买家已签收
        ///</sumary>
        public const string TRADE_BUYER_SIGNED = "TRADE_BUYER_SIGNED";

        ///<sumary>
        ///交易成功
        ///</sumary>
        public const string TRADE_SUCCESS = "TRADE_SUCCESS";

        ///<sumary>
        ///交易关闭
        ///</sumary>
        public const string TRADE_CLOSED = "TRADE_CLOSED";
    }

    /// <summary>
    /// 商品状态事件	status 值
    /// </summary>
    public class EnumYouzan_Item_Status
    {
        ///<sumary>
        ///商品删除
        ///</sumary>
        public const string TRADE_ORDER_STATE_ITEM_DELETE = "ITEM_DELETE";

        ///<sumary>
        ///部分售罄（多sku商品某sku售罄）
        ///</sumary>
        public const string TRADE_ORDER_STATE_SOLD_OUT_PART = "SOLD_OUT_PART";

        ///<sumary>
        ///全部售罄
        ///</sumary>
        public const string TRADE_ORDER_STATE_SOLD_OUT_ALL = "SOLD_OUT_ALL";

        ///<sumary>
        ///售罄恢复
        ///</sumary>
        public const string TRADE_ORDER_STATE_SOLD_OUT_REVERT = "SOLD_OUT_REVERT";

        ///<sumary>
        ///商品上架
        ///</sumary>
        public const string TRADE_ORDER_STATE_ITEM_SALE_UP = "ITEM_SALE_UP";

        ///<sumary>
        ///商品下架
        ///</sumary>
        public const string TRADE_ORDER_STATE_ITEM_SALE_DOWN = "ITEM_SALE_DOWN";

        ///<sumary>
        ///商品编辑, 不需要处理，因为还会发送 EnumYouzanItemInfoStatus.ITEM_UPDATE 消息过来
        ///</sumary>
        public const string ITEM_UPDATE = "ITEM_UPDATE";

    }

    /// <summary>
    /// 商品基础信息事件 ITEM_INFO
    /// </summary>
    public class EnumYouzan_ItemInfo_Status
    {
        ///<sumary>
        ///商品新增	
        ///</sumary>
        public const string ITEM_CREATE = "ITEM_CREATE";

        ///<sumary>
        ///商品编辑	
        ///</sumary>
        public const string ITEM_UPDATE = "ITEM_UPDATE";
    }

    /// <summary>
    /// 商品规格信息事件 ITEM_SKU_INFO
    /// </summary>
    public class EnumYouzan_ItemSkuInfo_Status
    {
        ///<sumary>
        ///商品规格新增	
        ///</sumary>
        public const string SKU_CREATE = "SKU_CREATE";

        ///<sumary>
        ///商品规格删除	
        ///</sumary>
        public const string SKU_DELETE = "SKU_DELETE";

        ///<sumary>
        ///商品规格编辑	
        ///</sumary>
        public const string SKU_UPDATE = "SKU_UPDATE";
    }
}
