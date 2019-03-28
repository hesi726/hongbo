using System;

namespace com.youzan.open.sdk.gen.v4_0_0.model
{

    //	\\//using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;

    //	//////using Maps = com.google.common.collect.Maps;


    //	////using Multimap = com.google.common.collect.Multimap;

    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;

    public class YouzanTradeGetResult : APIResult
    {

        

                /// <summary>
        /// 交易基础信息结构体
        /// </summary>
[Newtonsoft.Json.JsonProperty("full_order_info")]//) private StructurizationTradeOrderInfo fullOrderInfo;
        private StructurizationTradeOrderInfo fullOrderInfo;
        

                /// <summary>
        /// 订单退款信息结构体
        /// </summary>
[Newtonsoft.Json.JsonProperty("refund_order")]//) private StructurizationTradeRefundInfoDetail[] refundOrder;
        private StructurizationTradeRefundInfoDetail[] refundOrder;
        

                /// <summary>
        /// 订单发货详情结构体
        /// </summary>
[Newtonsoft.Json.JsonProperty("delivery_order")]//) private StructurizationTradeDeliveryDetail[] deliveryOrder;
        private StructurizationTradeDeliveryDetail[] deliveryOrder;
        

                /// <summary>
        /// 订单优惠详情结构体
        /// </summary>
[Newtonsoft.Json.JsonProperty("order_promotion")]//) private StructurizationTradePromotionInfoDetail orderPromotion;
        private StructurizationTradePromotionInfoDetail orderPromotion;

        public virtual StructurizationTradeOrderInfo FullOrderInfo
        {
            set
            {
                this.fullOrderInfo = value;
            }
            get
            {
                return this.fullOrderInfo;
            }
        }

        public virtual StructurizationTradeRefundInfoDetail[] RefundOrder
        {
            set
            {
                this.refundOrder = value;
            }
            get
            {
                return this.refundOrder;
            }
        }

        public virtual StructurizationTradeDeliveryDetail[] DeliveryOrder
        {
            set
            {
                this.deliveryOrder = value;
            }
            get
            {
                return this.deliveryOrder;
            }
        }

        public virtual StructurizationTradePromotionInfoDetail OrderPromotion
        {
            set
            {
                this.orderPromotion = value;
            }
            get
            {
                return this.orderPromotion;
            }
        }


        public class StructurizationOrderInfoDetailExtra
        {
            

                        /// <summary>
            /// 是否来自购物车 是：true 不是：false
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_from_cart")]//) private String isFromCart;
            internal string isFromCart;
            

                        /// <summary>
            /// 收银员id
            /// </summary>
[Newtonsoft.Json.JsonProperty("cashier_id")]//) private String cashierId;
            internal string cashierId;
            

                        /// <summary>
            /// 收银员名字
            /// </summary>
[Newtonsoft.Json.JsonProperty("cashier_name")]//) private String cashierName;
            internal string cashierName;
            

                        /// <summary>
            /// 发票抬头
            /// </summary>
[Newtonsoft.Json.JsonProperty("invoice_title")]//) private String invoiceTitle;
            internal string invoiceTitle;
            

                        /// <summary>
            /// 结算时间
            /// </summary>
[Newtonsoft.Json.JsonProperty("settle_time")]//) private String settleTime;
            internal string settleTime;
            

                        /// <summary>
            /// 是否父单(分销合并订单) 是：1 其他：null
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_parent_order")]//) private String isParentOrder;
            internal string isParentOrder;
            

                        /// <summary>
            /// 是否子单(分销买家订单) 是：1 其他：null
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_sub_order")]//) private String isSubOrder;
            internal string isSubOrder;
            

                        /// <summary>
            /// 分销单订单号
            /// </summary>
[Newtonsoft.Json.JsonProperty("fx_order_no")]//) private String fxOrderNo;
            internal string fxOrderNo;
            

                        /// <summary>
            /// 分销店铺id
            /// </summary>
[Newtonsoft.Json.JsonProperty("fx_kdt_id")]//) private String fxKdtId;
            internal string fxKdtId;
            

                        /// <summary>
            /// 父单号
            /// </summary>
[Newtonsoft.Json.JsonProperty("parent_order_no")]//) private String parentOrderNo;
            internal string parentOrderNo;
            

                        /// <summary>
            /// 采购单订单号
            /// </summary>
[Newtonsoft.Json.JsonProperty("purchase_order_no")]//) private String purchaseOrderNo;
            internal string purchaseOrderNo;
            

                        /// <summary>
            /// 美业分店id
            /// </summary>
[Newtonsoft.Json.JsonProperty("dept_id")]//) private String deptId;
            internal string deptId;
            

                        /// <summary>
            /// 下单设备号
            /// </summary>
[Newtonsoft.Json.JsonProperty("create_device_id")]//) private String createDeviceId;
            internal string createDeviceId;

            public virtual string IsFromCart
            {
                set
                {
                    this.isFromCart = value;
                }
                get
                {
                    return this.isFromCart;
                }
            }


            public virtual string CashierId
            {
                set
                {
                    this.cashierId = value;
                }
                get
                {
                    return this.cashierId;
                }
            }


            public virtual string CashierName
            {
                set
                {
                    this.cashierName = value;
                }
                get
                {
                    return this.cashierName;
                }
            }


            public virtual string InvoiceTitle
            {
                set
                {
                    this.invoiceTitle = value;
                }
                get
                {
                    return this.invoiceTitle;
                }
            }


            public virtual string SettleTime
            {
                set
                {
                    this.settleTime = value;
                }
                get
                {
                    return this.settleTime;
                }
            }


            public virtual string IsParentOrder
            {
                set
                {
                    this.isParentOrder = value;
                }
                get
                {
                    return this.isParentOrder;
                }
            }


            public virtual string IsSubOrder
            {
                set
                {
                    this.isSubOrder = value;
                }
                get
                {
                    return this.isSubOrder;
                }
            }


            public virtual string FxOrderNo
            {
                set
                {
                    this.fxOrderNo = value;
                }
                get
                {
                    return this.fxOrderNo;
                }
            }


            public virtual string FxKdtId
            {
                set
                {
                    this.fxKdtId = value;
                }
                get
                {
                    return this.fxKdtId;
                }
            }


            public virtual string ParentOrderNo
            {
                set
                {
                    this.parentOrderNo = value;
                }
                get
                {
                    return this.parentOrderNo;
                }
            }


            public virtual string PurchaseOrderNo
            {
                set
                {
                    this.purchaseOrderNo = value;
                }
                get
                {
                    return this.purchaseOrderNo;
                }
            }


            public virtual string DeptId
            {
                set
                {
                    this.deptId = value;
                }
                get
                {
                    return this.deptId;
                }
            }


            public virtual string CreateDeviceId
            {
                set
                {
                    this.createDeviceId = value;
                }
                get
                {
                    return this.createDeviceId;
                }
            }


        }

        public class StructurizationTradeBuyerInfoDetail
        {
            

                        /// <summary>
            /// 买家id
            /// </summary>
[Newtonsoft.Json.JsonProperty("buyer_id")]//) private Nullable<long> buyerId;
            internal long? buyerId;
            

                        /// <summary>
            /// 买家手机号
            /// </summary>
[Newtonsoft.Json.JsonProperty("buyer_phone")]//) private String buyerPhone;
            internal string buyerPhone;
            

                        /// <summary>
            /// 粉丝类型
            /// 1:自有粉丝; 9:代销粉丝
            /// </summary>
[Newtonsoft.Json.JsonProperty("fans_type")]//) private Nullable<long> fansType;
            internal long? fansType;
            

                        /// <summary>
            /// 粉丝id
            /// </summary>
[Newtonsoft.Json.JsonProperty("fans_id")]//) private Nullable<long> fansId;
            internal long? fansId;
            

                        /// <summary>
            /// 粉丝昵称
            /// </summary>
[Newtonsoft.Json.JsonProperty("fans_nickname")]//) private String fansNickname;
            internal string fansNickname;

            public virtual long? BuyerId
            {
                set
                {
                    this.buyerId = value;
                }
                get
                {
                    return this.buyerId;
                }
            }


            public virtual string BuyerPhone
            {
                set
                {
                    this.buyerPhone = value;
                }
                get
                {
                    return this.buyerPhone;
                }
            }


            public virtual long? FansType
            {
                set
                {
                    this.fansType = value;
                }
                get
                {
                    return this.fansType;
                }
            }


            public virtual long? FansId
            {
                set
                {
                    this.fansId = value;
                }
                get
                {
                    return this.fansId;
                }
            }


            public virtual string FansNickname
            {
                set
                {
                    this.fansNickname = value;
                }
                get
                {
                    return this.fansNickname;
                }
            }


        }

        public class StructurizationTradeRefundInfoDetail
        {
            

                        /// <summary>
            /// 退款类型
            /// 1:退款 - 买家申请退款; 2:退款 - 商家主动退款; 3:退款 - 一键退款
            /// </summary>
[Newtonsoft.Json.JsonProperty("refund_type")]//) private Nullable<long> refundType;
            internal long? refundType;
            

                        /// <summary>
            /// 退款金额
            /// </summary>
[Newtonsoft.Json.JsonProperty("refund_fee")]//) private Nullable<float> refundFee;
            internal float? refundFee;
            

                        /// <summary>
            /// 退款id
            /// </summary>
[Newtonsoft.Json.JsonProperty("refund_id")]//) private String refundId;
            internal string refundId;
            

                        /// <summary>
            /// 退款状态
            /// 1:买家已经申请退款，等待卖家同意;  10:卖家拒绝退款;  20:卖家已经同意退货，等待买家退货;  30:买家已经退货，等待卖家确认收货;  40:卖家未收到货,拒绝退款;  50:退款关闭;  60:退款成功;
            /// </summary>
[Newtonsoft.Json.JsonProperty("refund_state")]//) private Nullable<long> refundState;
            internal long? refundState;
            

                        /// <summary>
            /// 退款交易明细信息
            /// </summary>
[Newtonsoft.Json.JsonProperty("oids")]//) private StructurizationTradeRefundItemDetail[] oids;
            internal StructurizationTradeRefundItemDetail[] oids;

            public virtual long? RefundType
            {
                set
                {
                    this.refundType = value;
                }
                get
                {
                    return this.refundType;
                }
            }


            public virtual float? RefundFee
            {
                set
                {
                    this.refundFee = value;
                }
                get
                {
                    return this.refundFee;
                }
            }


            public virtual string RefundId
            {
                set
                {
                    this.refundId = value;
                }
                get
                {
                    return this.refundId;
                }
            }


            public virtual long? RefundState
            {
                set
                {
                    this.refundState = value;
                }
                get
                {
                    return this.refundState;
                }
            }


            public virtual StructurizationTradeRefundItemDetail[] Oids
            {
                set
                {
                    this.oids = value;
                }
                get
                {
                    return this.oids;
                }
            }


        }

        public class StructurizationTradeDeliveryItemDetail
        {
            

                        /// <summary>
            /// 交易明细id
            /// </summary>
[Newtonsoft.Json.JsonProperty("oid")]//) private String oid;
            internal string oid;

            public virtual string Oid
            {
                set
                {
                    this.oid = value;
                }
                get
                {
                    return this.oid;
                }
            }


        }

        public class StructurizationTradeDeliveryDetail
        {
            

                        /// <summary>
            /// 包裹id
            /// </summary>
[Newtonsoft.Json.JsonProperty("pk_id")]//) private Nullable<long> pkId;
            internal long? pkId;
            

                        /// <summary>
            /// 物流状态
            /// 0:待发货; 1:已发货
            /// </summary>
[Newtonsoft.Json.JsonProperty("express_state")]//) private Nullable<long> expressState;
            internal long? expressState;
            

                        /// <summary>
            /// 物流类型
            /// 0:手动发货; 1:系统自动发货
            /// </summary>
[Newtonsoft.Json.JsonProperty("express_type")]//) private Nullable<long> expressType;
            internal long? expressType;
            

                        /// <summary>
            /// 交易明细发货信息
            /// </summary>
[Newtonsoft.Json.JsonProperty("oids")]//) private StructurizationTradeDeliveryItemDetail[] oids;
            internal StructurizationTradeDeliveryItemDetail[] oids;

            public virtual long? PkId
            {
                set
                {
                    this.pkId = value;
                }
                get
                {
                    return this.pkId;
                }
            }


            public virtual long? ExpressState
            {
                set
                {
                    this.expressState = value;
                }
                get
                {
                    return this.expressState;
                }
            }


            public virtual long? ExpressType
            {
                set
                {
                    this.expressType = value;
                }
                get
                {
                    return this.expressType;
                }
            }


            public virtual StructurizationTradeDeliveryItemDetail[] Oids
            {
                set
                {
                    this.oids = value;
                }
                get
                {
                    return this.oids;
                }
            }


        }

        public class StructurizationTradePromotionInfoDetail
        {
            

                        /// <summary>
            /// 订单商品级优惠结构结构体
            /// </summary>
[Newtonsoft.Json.JsonProperty("item")]//) private StructurizationTradePromotionItemDetail[] item;
            internal StructurizationTradePromotionItemDetail[] item;
            

                        /// <summary>
            /// 优惠明细结构体
            /// </summary>
[Newtonsoft.Json.JsonProperty("order")]//) private StructurizationTradePromotionDetail[] order;
            internal StructurizationTradePromotionDetail[] order;
            

                        /// <summary>
            /// 商品优惠总金额
            /// </summary>
[Newtonsoft.Json.JsonProperty("item_discount_fee")]//) private Nullable<float> itemDiscountFee;
            internal float? itemDiscountFee;
            

                        /// <summary>
            /// 订单优惠总金额
            /// </summary>
[Newtonsoft.Json.JsonProperty("order_discount_fee")]//) private Nullable<float> orderDiscountFee;
            internal float? orderDiscountFee;

            public virtual StructurizationTradePromotionItemDetail[] Item
            {
                set
                {
                    this.item = value;
                }
                get
                {
                    return this.item;
                }
            }


            public virtual StructurizationTradePromotionDetail[] Order
            {
                set
                {
                    this.order = value;
                }
                get
                {
                    return this.order;
                }
            }


            public virtual float? ItemDiscountFee
            {
                set
                {
                    this.itemDiscountFee = value;
                }
                get
                {
                    return this.itemDiscountFee;
                }
            }


            public virtual float? OrderDiscountFee
            {
                set
                {
                    this.orderDiscountFee = value;
                }
                get
                {
                    return this.orderDiscountFee;
                }
            }


        }

        public class StructurizationTradeRemarkInfoDetail
        {
            

                        /// <summary>
            /// 订单买家留言
            /// </summary>
[Newtonsoft.Json.JsonProperty("buyer_message")]//) private String buyerMessage;
            internal string buyerMessage;
            

                        /// <summary>
            /// 订单标星等级 0-5
            /// </summary>
[Newtonsoft.Json.JsonProperty("star")]//) private Nullable<long> star;
            internal long? star;
            

                        /// <summary>
            /// 订单商家备注
            /// </summary>
[Newtonsoft.Json.JsonProperty("trade_memo")]//) private String tradeMemo;
            internal string tradeMemo;

            public virtual string BuyerMessage
            {
                set
                {
                    this.buyerMessage = value;
                }
                get
                {
                    return this.buyerMessage;
                }
            }


            public virtual long? Star
            {
                set
                {
                    this.star = value;
                }
                get
                {
                    return this.star;
                }
            }


            public virtual string TradeMemo
            {
                set
                {
                    this.tradeMemo = value;
                }
                get
                {
                    return this.tradeMemo;
                }
            }


        }

        public class StructurizationTradeSourceInfo
        {
            

                        /// <summary>
            /// 是否来自线下订单
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_offline_order")]//) private Nullable<bool> isOfflineOrder;
            internal bool? isOfflineOrder;
            

                        /// <summary>
            /// 订单来源平台
            /// </summary>
[Newtonsoft.Json.JsonProperty("source")]//) private StructurizationTradeSource source;
            internal StructurizationTradeSource source;

            public virtual bool? IsOfflineOrder
            {
                set
                {
                    this.isOfflineOrder = value;
                }
                get
                {
                    return this.isOfflineOrder;
                }
            }


            public virtual StructurizationTradeSource Source
            {
                set
                {
                    this.source = value;
                }
                get
                {
                    return this.source;
                }
            }


        }

        public class StructurizationTradeItemDetail
        {
            

                        /// <summary>
            /// 订单明细id
            /// </summary>
[Newtonsoft.Json.JsonProperty("oid")]//) private String oid;
            internal string oid;
            

                        /// <summary>
            /// 订单类型
            /// 0:普通类型商品; 1:拍卖商品; 5:餐饮商品; 10:分销商品; 20:会员卡商品; 21:礼品卡商品; 23:有赞会议商品; 24:周期购; 30:收银台商品; 31:知识付费商品; 35:酒店商品; 40:普通服务类商品; 182:普通虚拟商品; 183:电子卡券商品; 201:外部会员卡商品; 202:外部直接收款商品; 203:外部普通商品; 205:mock不存在商品; 206:小程序二维码
            /// </summary>
[Newtonsoft.Json.JsonProperty("item_type")]//) private Nullable<long> itemType;
            internal long? itemType;
            

                        /// <summary>
            /// 商品名称
            /// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
            internal string title;
            

                        /// <summary>
            /// 商品数量
            /// </summary>
[Newtonsoft.Json.JsonProperty("num")]//) private Nullable<long> num;
            internal long? num;
            

                        /// <summary>
            /// 商家编码
            /// </summary>
[Newtonsoft.Json.JsonProperty("outer_sku_id")]//) private String outerSkuId;
            internal string outerSkuId;
            

                        /// <summary>
            /// 商品留言
            /// </summary>
[Newtonsoft.Json.JsonProperty("buyer_messages")]//) private String buyerMessages;
            internal string buyerMessages;
            

                        /// <summary>
            /// 单商品原价
            /// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<float> price;
            internal float? price;
            

                        /// <summary>
            /// 商品优惠后总价
            /// </summary>
[Newtonsoft.Json.JsonProperty("total_fee")]//) private Nullable<float> totalFee;
            internal float? totalFee;
            

                        /// <summary>
            /// 商品最终均摊价
            /// </summary>
[Newtonsoft.Json.JsonProperty("payment")]//) private Nullable<float> payment;
            internal float? payment;
            

                        /// <summary>
            /// 商品id
            /// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
            internal long? itemId;
            

                        /// <summary>
            /// 规格id（无规格商品也会有值）
            /// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
            internal long? skuId;
            

                        /// <summary>
            /// 规格信息（无规格商品为空）
            /// </summary>
[Newtonsoft.Json.JsonProperty("sku_properties_name")]//) private String skuPropertiesName;
            internal string skuPropertiesName;
            

                        /// <summary>
            /// 商品编码
            /// </summary>
[Newtonsoft.Json.JsonProperty("outer_item_id")]//) private String outerItemId;
            internal string outerItemId;
            

                        /// <summary>
            /// 商品积分价（非积分商品则为0）
            /// </summary>
[Newtonsoft.Json.JsonProperty("points_price")]//) private String pointsPrice;
            internal string pointsPrice;
            

                        /// <summary>
            /// 商品图片地址
            /// </summary>
[Newtonsoft.Json.JsonProperty("pic_path")]//) private String picPath;
            internal string picPath;

            public virtual string Oid
            {
                set
                {
                    this.oid = value;
                }
                get
                {
                    return this.oid;
                }
            }


            public virtual long? ItemType
            {
                set
                {
                    this.itemType = value;
                }
                get
                {
                    return this.itemType;
                }
            }


            public virtual string Title
            {
                set
                {
                    this.title = value;
                }
                get
                {
                    return this.title;
                }
            }


            public virtual long? Num
            {
                set
                {
                    this.num = value;
                }
                get
                {
                    return this.num;
                }
            }


            public virtual string OuterSkuId
            {
                set
                {
                    this.outerSkuId = value;
                }
                get
                {
                    return this.outerSkuId;
                }
            }


            public virtual string BuyerMessages
            {
                set
                {
                    this.buyerMessages = value;
                }
                get
                {
                    return this.buyerMessages;
                }
            }


            public virtual float? Price
            {
                set
                {
                    this.price = value;
                }
                get
                {
                    return this.price;
                }
            }


            public virtual float? TotalFee
            {
                set
                {
                    this.totalFee = value;
                }
                get
                {
                    return this.totalFee;
                }
            }


            public virtual float? Payment
            {
                set
                {
                    this.payment = value;
                }
                get
                {
                    return this.payment;
                }
            }


            public virtual long? ItemId
            {
                set
                {
                    this.itemId = value;
                }
                get
                {
                    return this.itemId;
                }
            }


            public virtual long? SkuId
            {
                set
                {
                    this.skuId = value;
                }
                get
                {
                    return this.skuId;
                }
            }


            public virtual string SkuPropertiesName
            {
                set
                {
                    this.skuPropertiesName = value;
                }
                get
                {
                    return this.skuPropertiesName;
                }
            }


            public virtual string OuterItemId
            {
                set
                {
                    this.outerItemId = value;
                }
                get
                {
                    return this.outerItemId;
                }
            }


            public virtual string PointsPrice
            {
                set
                {
                    this.pointsPrice = value;
                }
                get
                {
                    return this.pointsPrice;
                }
            }


            public virtual string PicPath
            {
                set
                {
                    this.picPath = value;
                }
                get
                {
                    return this.picPath;
                }
            }


        }

        public class StructurizationTradePromotionDetail
        {
            

                        /// <summary>
            /// 优惠类型
            /// tuan:团购返现
            /// auction:降价拍
            /// groupOn:多人拼团
            /// pointsExchange:积分抵扣
            /// seckill:秒杀
            /// packageBuy:优惠套餐
            /// presentExchange:赠品领取
            /// goodsScan:商品扫码
            /// customerDiscount:会员折扣
            /// timelimitedDiscount:限时折扣
            /// paidPromotion:支付有礼
            /// periodBuy:周期购
            /// scanReduce:收款码优惠
            /// meetReduce:满减送
            /// cashBack:订单返现
            /// supplierMeetReduce:供货商满包邮
            /// bale:打包一口价
            /// coupon:优惠卡券
            /// entireDiscount:整单优惠
            /// groupOnHeaderDiscount:团长优惠
            /// customerPostageFree:会员包邮
            /// periodBuyPostageFree:周期购包邮
            /// ignoreOddChange:抹零
            /// pfGuideMarketing:引导促销
            /// </summary>
[Newtonsoft.Json.JsonProperty("promotion_type")]//) private String promotionType;
            internal string promotionType;
            

                        /// <summary>
            /// 优惠别名
            /// </summary>
[Newtonsoft.Json.JsonProperty("promotion_title")]//) private String promotionTitle;
            internal string promotionTitle;
            

                        /// <summary>
            /// 优惠类型描述
            /// </summary>
[Newtonsoft.Json.JsonProperty("promotion_type_name")]//) private String promotionTypeName;
            internal string promotionTypeName;
            

                        /// <summary>
            /// 优惠类型id
            /// </summary>
[Newtonsoft.Json.JsonProperty("promotion_type_id")]//) private Nullable<long> promotionTypeId;
            internal long? promotionTypeId;
            

                        /// <summary>
            /// 优惠金额
            /// </summary>
[Newtonsoft.Json.JsonProperty("discount_fee")]//) private Nullable<float> discountFee;
            internal float? discountFee;
            

                        /// <summary>
            /// 优惠描述
            /// </summary>
[Newtonsoft.Json.JsonProperty("promotion_condition")]//) private String promotionCondition;
            internal string promotionCondition;
            

                        /// <summary>
            /// 优惠活动别名
            /// </summary>
[Newtonsoft.Json.JsonProperty("promotion_content")]//) private String promotionContent;
            internal string promotionContent;
            

                        /// <summary>
            /// 优惠id
            /// </summary>
[Newtonsoft.Json.JsonProperty("promotion_id")]//) private Nullable<long> promotionId;
            internal long? promotionId;

            public virtual string PromotionType
            {
                set
                {
                    this.promotionType = value;
                }
                get
                {
                    return this.promotionType;
                }
            }


            public virtual string PromotionTitle
            {
                set
                {
                    this.promotionTitle = value;
                }
                get
                {
                    return this.promotionTitle;
                }
            }


            public virtual string PromotionTypeName
            {
                set
                {
                    this.promotionTypeName = value;
                }
                get
                {
                    return this.promotionTypeName;
                }
            }


            public virtual long? PromotionTypeId
            {
                set
                {
                    this.promotionTypeId = value;
                }
                get
                {
                    return this.promotionTypeId;
                }
            }


            public virtual float? DiscountFee
            {
                set
                {
                    this.discountFee = value;
                }
                get
                {
                    return this.discountFee;
                }
            }


            public virtual string PromotionCondition
            {
                set
                {
                    this.promotionCondition = value;
                }
                get
                {
                    return this.promotionCondition;
                }
            }


            public virtual string PromotionContent
            {
                set
                {
                    this.promotionContent = value;
                }
                get
                {
                    return this.promotionContent;
                }
            }


            public virtual long? PromotionId
            {
                set
                {
                    this.promotionId = value;
                }
                get
                {
                    return this.promotionId;
                }
            }


        }

        public class StructurizationTradeOrderInfo
        {
            

                        /// <summary>
            /// 交易明细详情
            /// </summary>
[Newtonsoft.Json.JsonProperty("order_info")]//) private StructurizationOrderInfoDetail orderInfo;
            internal StructurizationOrderInfoDetail orderInfo;
            

                        /// <summary>
            /// 订单来源
            /// </summary>
[Newtonsoft.Json.JsonProperty("source_info")]//) private StructurizationTradeSourceInfo sourceInfo;
            internal StructurizationTradeSourceInfo sourceInfo;
            

                        /// <summary>
            /// 订单买家信息结构体
            /// </summary>
[Newtonsoft.Json.JsonProperty("buyer_info")]//) private StructurizationTradeBuyerInfoDetail buyerInfo;
            internal StructurizationTradeBuyerInfoDetail buyerInfo;
            

                        /// <summary>
            /// 交易支付信息结构体
            /// </summary>
[Newtonsoft.Json.JsonProperty("pay_info")]//) private StructurizationTradePayInfoDetail payInfo;
            internal StructurizationTradePayInfoDetail payInfo;
            

                        /// <summary>
            /// 订单标记信息结构体
            /// </summary>
[Newtonsoft.Json.JsonProperty("remark_info")]//) private StructurizationTradeRemarkInfoDetail remarkInfo;
            internal StructurizationTradeRemarkInfoDetail remarkInfo;
            

                        /// <summary>
            /// 订单收货地址信息结构体
            /// </summary>
[Newtonsoft.Json.JsonProperty("address_info")]//) private StructurizationTradeAddressInfoDetail addressInfo;
            internal StructurizationTradeAddressInfoDetail addressInfo;
            

                        /// <summary>
            /// 订单明细结构体
            /// </summary>
[Newtonsoft.Json.JsonProperty("orders")]//) private StructurizationTradeItemDetail[] orders;
            internal StructurizationTradeItemDetail[] orders;

            public virtual StructurizationOrderInfoDetail OrderInfo
            {
                set
                {
                    this.orderInfo = value;
                }
                get
                {
                    return this.orderInfo;
                }
            }


            public virtual StructurizationTradeSourceInfo SourceInfo
            {
                set
                {
                    this.sourceInfo = value;
                }
                get
                {
                    return this.sourceInfo;
                }
            }


            public virtual StructurizationTradeBuyerInfoDetail BuyerInfo
            {
                set
                {
                    this.buyerInfo = value;
                }
                get
                {
                    return this.buyerInfo;
                }
            }


            public virtual StructurizationTradePayInfoDetail PayInfo
            {
                set
                {
                    this.payInfo = value;
                }
                get
                {
                    return this.payInfo;
                }
            }


            public virtual StructurizationTradeRemarkInfoDetail RemarkInfo
            {
                set
                {
                    this.remarkInfo = value;
                }
                get
                {
                    return this.remarkInfo;
                }
            }


            public virtual StructurizationTradeAddressInfoDetail AddressInfo
            {
                set
                {
                    this.addressInfo = value;
                }
                get
                {
                    return this.addressInfo;
                }
            }


            public virtual StructurizationTradeItemDetail[] Orders
            {
                set
                {
                    this.orders = value;
                }
                get
                {
                    return this.orders;
                }
            }


        }

        public class StructurizationTradeSource
        {
            

                        /// <summary>
            /// 平台
            /// wx:微信; merchant_3rd:商家自有app; buyer_v:买家版; browser:系统浏览器; alipay:支付宝;qq:腾讯QQ; wb:微博; other:其他
            /// </summary>
[Newtonsoft.Json.JsonProperty("platform")]//) private String platform;
            internal string platform;
            

                        /// <summary>
            /// 微信平台细分
            /// wx_gzh:微信公众号; yzdh:有赞大号; merchant_xcx:商家小程序; yzdh_xcx:有赞大号小程序; direct_buy:直接购买
            /// </summary>
[Newtonsoft.Json.JsonProperty("wx_entrance")]//) private String wxEntrance;
            internal string wxEntrance;

            public virtual string Platform
            {
                set
                {
                    this.platform = value;
                }
                get
                {
                    return this.platform;
                }
            }


            public virtual string WxEntrance
            {
                set
                {
                    this.wxEntrance = value;
                }
                get
                {
                    return this.wxEntrance;
                }
            }


        }

        public class StructurizationTradePayInfoDetail
        {
            

                        /// <summary>
            /// 优惠前商品总价
            /// </summary>
[Newtonsoft.Json.JsonProperty("total_fee")]//) private Nullable<float> totalFee;
            internal float? totalFee;
            

                        /// <summary>
            /// 邮费
            /// </summary>
[Newtonsoft.Json.JsonProperty("post_fee")]//) private Nullable<float> postFee;
            internal float? postFee;
            

                        /// <summary>
            /// 最终支付价格
            /// payment=orders.payment的总和
            /// </summary>
[Newtonsoft.Json.JsonProperty("payment")]//) private Nullable<float> payment;
            internal float? payment;
            

                        /// <summary>
            /// 有赞支付流水号
            /// </summary>
[Newtonsoft.Json.JsonProperty("transaction")]//) private String[] transaction;
            internal string[] transaction;
            

                        /// <summary>
            /// 外部支付单号
            /// </summary>
[Newtonsoft.Json.JsonProperty("outer_transactions")]//) private String[] outerTransactions;
            internal string[] outerTransactions;

            public virtual float? TotalFee
            {
                set
                {
                    this.totalFee = value;
                }
                get
                {
                    return this.totalFee;
                }
            }


            public virtual float? PostFee
            {
                set
                {
                    this.postFee = value;
                }
                get
                {
                    return this.postFee;
                }
            }


            public virtual float? Payment
            {
                set
                {
                    this.payment = value;
                }
                get
                {
                    return this.payment;
                }
            }


            public virtual string[] Transaction
            {
                set
                {
                    this.transaction = value;
                }
                get
                {
                    return this.transaction;
                }
            }


            public virtual string[] OuterTransactions
            {
                set
                {
                    this.outerTransactions = value;
                }
                get
                {
                    return this.outerTransactions;
                }
            }


        }

        public class StructurizationTradeRefundItemDetail
        {
            

                        /// <summary>
            /// 交易明细id
            /// </summary>
[Newtonsoft.Json.JsonProperty("oid")]//) private String oid;
            internal string oid;

            public virtual string Oid
            {
                set
                {
                    this.oid = value;
                }
                get
                {
                    return this.oid;
                }
            }


        }

        public class StructurizationOrderInfoDetailTags
        {
            

                        /// <summary>
            /// 是否虚拟订单
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_virtual")]//) private Nullable<bool> isVirtual;
            internal bool? isVirtual;
            

                        /// <summary>
            /// 是否采购单
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_purchase_order")]//) private Nullable<bool> isPurchaseOrder;
            internal bool? isPurchaseOrder;
            

                        /// <summary>
            /// 是否分销单
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_fenxiao_order")]//) private Nullable<bool> isFenxiaoOrder;
            internal bool? isFenxiaoOrder;
            

                        /// <summary>
            /// 是否会员订单
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_member")]//) private Nullable<bool> isMember;
            internal bool? isMember;
            

                        /// <summary>
            /// 是否预订单
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_preorder")]//) private Nullable<bool> isPreorder;
            internal bool? isPreorder;
            

                        /// <summary>
            /// 是否线下订单
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_offline_order")]//) private Nullable<bool> isOfflineOrder;
            internal bool? isOfflineOrder;
            

                        /// <summary>
            /// 是否多门店订单
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_multi_store")]//) private Nullable<bool> isMultiStore;
            internal bool? isMultiStore;
            

                        /// <summary>
            /// 是否结算
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_settle")]//) private Nullable<bool> isSettle;
            internal bool? isSettle;
            

                        /// <summary>
            /// 是否支付
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_payed")]//) private Nullable<bool> isPayed;
            internal bool? isPayed;
            

                        /// <summary>
            /// 是否担保交易
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_secured_transactions")]//) private Nullable<bool> isSecuredTransactions;
            internal bool? isSecuredTransactions;
            

                        /// <summary>
            /// 是否享受免邮
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_postage_free")]//) private Nullable<bool> isPostageFree;
            internal bool? isPostageFree;
            

                        /// <summary>
            /// 是否有维权
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_feedback")]//) private Nullable<bool> isFeedback;
            internal bool? isFeedback;
            

                        /// <summary>
            /// 是否有退款
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_refund")]//) private Nullable<bool> isRefund;
            internal bool? isRefund;

            public virtual bool? IsVirtual
            {
                set
                {
                    this.isVirtual = value;
                }
                get
                {
                    return this.isVirtual;
                }
            }


            public virtual bool? IsPurchaseOrder
            {
                set
                {
                    this.isPurchaseOrder = value;
                }
                get
                {
                    return this.isPurchaseOrder;
                }
            }


            public virtual bool? IsFenxiaoOrder
            {
                set
                {
                    this.isFenxiaoOrder = value;
                }
                get
                {
                    return this.isFenxiaoOrder;
                }
            }


            public virtual bool? IsMember
            {
                set
                {
                    this.isMember = value;
                }
                get
                {
                    return this.isMember;
                }
            }


            public virtual bool? IsPreorder
            {
                set
                {
                    this.isPreorder = value;
                }
                get
                {
                    return this.isPreorder;
                }
            }


            public virtual bool? IsOfflineOrder
            {
                set
                {
                    this.isOfflineOrder = value;
                }
                get
                {
                    return this.isOfflineOrder;
                }
            }


            public virtual bool? IsMultiStore
            {
                set
                {
                    this.isMultiStore = value;
                }
                get
                {
                    return this.isMultiStore;
                }
            }


            public virtual bool? IsSettle
            {
                set
                {
                    this.isSettle = value;
                }
                get
                {
                    return this.isSettle;
                }
            }


            public virtual bool? IsPayed
            {
                set
                {
                    this.isPayed = value;
                }
                get
                {
                    return this.isPayed;
                }
            }


            public virtual bool? IsSecuredTransactions
            {
                set
                {
                    this.isSecuredTransactions = value;
                }
                get
                {
                    return this.isSecuredTransactions;
                }
            }


            public virtual bool? IsPostageFree
            {
                set
                {
                    this.isPostageFree = value;
                }
                get
                {
                    return this.isPostageFree;
                }
            }


            public virtual bool? IsFeedback
            {
                set
                {
                    this.isFeedback = value;
                }
                get
                {
                    return this.isFeedback;
                }
            }


            public virtual bool? IsRefund
            {
                set
                {
                    this.isRefund = value;
                }
                get
                {
                    return this.isRefund;
                }
            }


        }

        public class StructurizationTradeAddressInfoDetail
        {
            

                        /// <summary>
            /// 收货人姓名
            /// </summary>
[Newtonsoft.Json.JsonProperty("receiver_name")]//) private String receiverName;
            internal string receiverName;
            

                        /// <summary>
            /// 收货人手机号
            /// </summary>
[Newtonsoft.Json.JsonProperty("receiver_tel")]//) private String receiverTel;
            internal string receiverTel;
            

                        /// <summary>
            /// 省
            /// </summary>
[Newtonsoft.Json.JsonProperty("delivery_province")]//) private String deliveryProvince;
            internal string deliveryProvince;
            

                        /// <summary>
            /// 市
            /// </summary>
[Newtonsoft.Json.JsonProperty("delivery_city")]//) private String deliveryCity;
            internal string deliveryCity;
            

                        /// <summary>
            /// 区
            /// </summary>
[Newtonsoft.Json.JsonProperty("delivery_district")]//) private String deliveryDistrict;
            internal string deliveryDistrict;
            

                        /// <summary>
            /// 详细地址
            /// </summary>
[Newtonsoft.Json.JsonProperty("delivery_address")]//) private String deliveryAddress;
            internal string deliveryAddress;
            

                        /// <summary>
            /// 字段为json格式，需要开发者自行解析
            /// lng、lon（经纬度）；
            /// checkOutTime（酒店退房时间）；
            /// recipients（入住人）；
            /// checkInTime（酒店入住时间）；
            /// idCardNumber（海淘身份证信息）；
            /// areaCode（邮政编码）
            /// </summary>
[Newtonsoft.Json.JsonProperty("address_extra")]//) private String addressExtra;
            internal string addressExtra;
            

                        /// <summary>
            /// 邮政编码
            /// </summary>
[Newtonsoft.Json.JsonProperty("delivery_postal_code")]//) private String deliveryPostalCode;
            internal string deliveryPostalCode;
            

                        /// <summary>
            /// 到店自提信息 json格式
            /// </summary>
[Newtonsoft.Json.JsonProperty("self_fetch_info")]//) private String selfFetchInfo;
            internal string selfFetchInfo;

            public virtual string ReceiverName
            {
                set
                {
                    this.receiverName = value;
                }
                get
                {
                    return this.receiverName;
                }
            }


            public virtual string ReceiverTel
            {
                set
                {
                    this.receiverTel = value;
                }
                get
                {
                    return this.receiverTel;
                }
            }


            public virtual string DeliveryProvince
            {
                set
                {
                    this.deliveryProvince = value;
                }
                get
                {
                    return this.deliveryProvince;
                }
            }


            public virtual string DeliveryCity
            {
                set
                {
                    this.deliveryCity = value;
                }
                get
                {
                    return this.deliveryCity;
                }
            }


            public virtual string DeliveryDistrict
            {
                set
                {
                    this.deliveryDistrict = value;
                }
                get
                {
                    return this.deliveryDistrict;
                }
            }


            public virtual string DeliveryAddress
            {
                set
                {
                    this.deliveryAddress = value;
                }
                get
                {
                    return this.deliveryAddress;
                }
            }


            public virtual string AddressExtra
            {
                set
                {
                    this.addressExtra = value;
                }
                get
                {
                    return this.addressExtra;
                }
            }


            public virtual string DeliveryPostalCode
            {
                set
                {
                    this.deliveryPostalCode = value;
                }
                get
                {
                    return this.deliveryPostalCode;
                }
            }


            public virtual string SelfFetchInfo
            {
                set
                {
                    this.selfFetchInfo = value;
                }
                get
                {
                    return this.selfFetchInfo;
                }
            }


        }

        public class StructurizationTradePromotionItemDetail
        {
            

                        /// <summary>
            /// 是否赠品
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_present")]//) private Nullable<bool> isPresent;
            internal bool? isPresent;
            

                        /// <summary>
            /// 交易明细id
            /// </summary>
[Newtonsoft.Json.JsonProperty("oid")]//) private String oid;
            internal string oid;
            

                        /// <summary>
            /// 商品id
            /// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
            internal long? itemId;
            

                        /// <summary>
            /// 规格id
            /// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
            internal long? skuId;
            

                        /// <summary>
            /// 优惠明细结构体
            /// </summary>
[Newtonsoft.Json.JsonProperty("promotions")]//) private StructurizationTradePromotionDetail[] promotions;
            internal StructurizationTradePromotionDetail[] promotions;

            public virtual bool? IsPresent
            {
                set
                {
                    this.isPresent = value;
                }
                get
                {
                    return this.isPresent;
                }
            }


            public virtual string Oid
            {
                set
                {
                    this.oid = value;
                }
                get
                {
                    return this.oid;
                }
            }


            public virtual long? ItemId
            {
                set
                {
                    this.itemId = value;
                }
                get
                {
                    return this.itemId;
                }
            }


            public virtual long? SkuId
            {
                set
                {
                    this.skuId = value;
                }
                get
                {
                    return this.skuId;
                }
            }


            public virtual StructurizationTradePromotionDetail[] Promotions
            {
                set
                {
                    this.promotions = value;
                }
                get
                {
                    return this.promotions;
                }
            }


        }

        public class StructurizationOrderInfoDetail
        {
            

                        /// <summary>
            /// 主订单状态
            /// WAIT_BUYER_PAY （等待买家付款）；
            /// WAIT_CONFIRM（待确认，包含待成团、待接单等等。即：买家已付款，等待成团或等待接单）；
            /// WAIT_SELLER_SEND_GOODS（等待卖家发货，即：买家已付款）；
            /// WAIT_BUYER_CONFIRM_GOODS (等待买家确认收货，即：卖家已发货) ；
            /// TRADE_SUCCESS（买家已签收以及订单成功）；
            /// TRADE_CLOSED（交易关闭）；
            /// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private String status;
            internal string status;
            

                        /// <summary>
            /// 主订单类型
            /// 0:普通订单; 1:送礼订单; 2:代付; 3:分销采购单; 4:赠品; 5:心愿单; 6:二维码订单; 7:合并付货款; 8:1分钱实名认证; 9:品鉴; 10:拼团; 15:返利; 35:酒店; 40:外卖; 41:堂食点餐; 46:外卖买单; 51:全员开店; 52:保证金; 61:线下收银台订单; 71:美业预约单; 72:美业服务单; 75:知识付费; 81:礼品卡; 100:批发
            /// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
            internal long? type;
            

                        /// <summary>
            /// 订单号
            /// </summary>
[Newtonsoft.Json.JsonProperty("tid")]//) private String tid;
            internal string tid;
            

                        /// <summary>
            /// 主订单状态描述
            /// </summary>
[Newtonsoft.Json.JsonProperty("status_str")]//) private String statusStr;
            internal string statusStr;
            

                        /// <summary>
            /// 支付类型
            /// 0:默认值,未支付; 1:微信自有支付; 2:支付宝wap; 3:支付宝wap; 5:财付通; 7:代付; 8:联动优势; 9:货到付款; 10:大账号代销; 11:受理模式; 12:百付宝; 13:sdk支付; 14:合并付货款; 15:赠品; 16:优惠兑换; 17:自动付货款; 18:爱学贷; 19:微信wap; 20:微信红包支付; 21:返利; 22:ump红包; 24:易宝支付; 25:储值卡; 27:qq支付; 28:有赞E卡支付; 29:微信条码; 30:支付宝条码; 33:礼品卡支付; 35:会员余额; 72:微信扫码二维码支付; 100:代收账户; 300:储值账户; 400:保证金账户; 101:收款码; 102:微信; 103:支付宝; 104:刷卡; 105:二维码台卡; 106:储值卡; 107:有赞E卡; 110:标记收款-自有微信支付; 111:标记收款-自有支付宝; 112:标记收款-自有POS刷卡; 113:通联刷卡支付; 200:记账账户; 201:现金
            /// </summary>
[Newtonsoft.Json.JsonProperty("pay_type")]//) private Nullable<long> payType;
            internal long? payType;
            

                        /// <summary>
            /// 店铺类型
            /// 0:微商城; 1:微小店; 2:爱学贷微商城; 3:批发店铺; 4:批发商城; 5:外卖; 6:美业; 7:超级门店; 8:收银; 9:收银加微商城; 10:零售总部; 99:有赞开放平台平台型应用创建的店铺
            /// </summary>
[Newtonsoft.Json.JsonProperty("team_type")]//) private Nullable<long> teamType;
            internal long? teamType;
            

                        /// <summary>
            /// 关闭类型
            /// 0:未关闭; 1:过期关闭; 2:标记退款; 3:订单取消; 4:买家取消; 5:卖家取消; 6:部分退款; 10:无法联系上买家; 11:买家误拍或重拍了; 12:买家无诚意完成交易; 13:已通过银行线下汇款; 14:已通过同城见面交易; 15:已通过货到付款交易; 16:已通过网上银行直接汇款; 17:已经缺货无法交易
            /// </summary>
[Newtonsoft.Json.JsonProperty("close_type")]//) private Nullable<long> closeType;
            internal long? closeType;
            

                        /// <summary>
            /// 物流类型
            /// 0:快递发货; 1:到店自提; 2:同城配送; 9:无需发货（虚拟商品订单）
            /// </summary>
[Newtonsoft.Json.JsonProperty("express_type")]//) private Nullable<long> expressType;
            internal long? expressType;
            

                        /// <summary>
            /// 订单信息打标
            /// </summary>
[Newtonsoft.Json.JsonProperty("order_tags")]//) private StructurizationOrderInfoDetailTags orderTags;
            internal StructurizationOrderInfoDetailTags orderTags;
            

                        /// <summary>
            /// 订单扩展字段
            /// </summary>
[Newtonsoft.Json.JsonProperty("order_extra")]//) private StructurizationOrderInfoDetailExtra orderExtra;
            internal StructurizationOrderInfoDetailExtra orderExtra;
            

                        /// <summary>
            /// 订单创建时间
            /// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
            internal DateTime created;
            

                        /// <summary>
            /// 订单更新时间
            /// </summary>
[Newtonsoft.Json.JsonProperty("update_time")]//) private java.util.Date updateTime;
            internal DateTime updateTime;
            

                        /// <summary>
            /// 订单过期时间（未付款将自动关单）
            /// </summary>
[Newtonsoft.Json.JsonProperty("expired_time")]//) private java.util.Date expiredTime;
            internal DateTime expiredTime;
            

                        /// <summary>
            /// 订单支付时间
            /// </summary>
[Newtonsoft.Json.JsonProperty("pay_time")]//) private java.util.Date payTime;
            internal DateTime payTime;
            

                        /// <summary>
            /// 订单发货时间（当所有商品发货后才会更新）
            /// </summary>
[Newtonsoft.Json.JsonProperty("consign_time")]//) private java.util.Date consignTime;
            internal DateTime consignTime;
            

                        /// <summary>
            /// 订单确认时间（多人拼团成团）
            /// </summary>
[Newtonsoft.Json.JsonProperty("confirm_time")]//) private java.util.Date confirmTime;
            internal DateTime confirmTime;
            

                        /// <summary>
            /// 退款状态
            /// 0:未退款; 1:部分退款中; 2:部分退款成功; 11:全额退款中; 12:全额退款成功
            /// </summary>
[Newtonsoft.Json.JsonProperty("refund_state")]//) private Nullable<long> refundState;
            internal long? refundState;
            

                        /// <summary>
            /// 是否零售订单
            /// </summary>
[Newtonsoft.Json.JsonProperty("is_retail_order")]//) private Nullable<bool> isRetailOrder;
            internal bool? isRetailOrder;
            

                        /// <summary>
            /// 订单成功时间
            /// </summary>
[Newtonsoft.Json.JsonProperty("success_time")]//) private java.util.Date successTime;
            internal DateTime successTime;
            

                        /// <summary>
            /// 网点id
            /// </summary>
[Newtonsoft.Json.JsonProperty("offline_id")]//) private Nullable<long> offlineId;
            internal long? offlineId;

            public virtual string Status
            {
                set
                {
                    this.status = value;
                }
                get
                {
                    return this.status;
                }
            }


            public virtual long? Type
            {
                set
                {
                    this.type = value;
                }
                get
                {
                    return this.type;
                }
            }


            public virtual string Tid
            {
                set
                {
                    this.tid = value;
                }
                get
                {
                    return this.tid;
                }
            }


            public virtual string StatusStr
            {
                set
                {
                    this.statusStr = value;
                }
                get
                {
                    return this.statusStr;
                }
            }


            public virtual long? PayType
            {
                set
                {
                    this.payType = value;
                }
                get
                {
                    return this.payType;
                }
            }


            public virtual long? TeamType
            {
                set
                {
                    this.teamType = value;
                }
                get
                {
                    return this.teamType;
                }
            }


            public virtual long? CloseType
            {
                set
                {
                    this.closeType = value;
                }
                get
                {
                    return this.closeType;
                }
            }


            public virtual long? ExpressType
            {
                set
                {
                    this.expressType = value;
                }
                get
                {
                    return this.expressType;
                }
            }


            public virtual StructurizationOrderInfoDetailTags OrderTags
            {
                set
                {
                    this.orderTags = value;
                }
                get
                {
                    return this.orderTags;
                }
            }


            public virtual StructurizationOrderInfoDetailExtra OrderExtra
            {
                set
                {
                    this.orderExtra = value;
                }
                get
                {
                    return this.orderExtra;
                }
            }


            public virtual DateTime Created
            {
                set
                {
                    this.created = value;
                }
                get
                {
                    return this.created;
                }
            }


            public virtual DateTime UpdateTime
            {
                set
                {
                    this.updateTime = value;
                }
                get
                {
                    return this.updateTime;
                }
            }


            public virtual DateTime ExpiredTime
            {
                set
                {
                    this.expiredTime = value;
                }
                get
                {
                    return this.expiredTime;
                }
            }


            public virtual DateTime PayTime
            {
                set
                {
                    this.payTime = value;
                }
                get
                {
                    return this.payTime;
                }
            }


            public virtual DateTime ConsignTime
            {
                set
                {
                    this.consignTime = value;
                }
                get
                {
                    return this.consignTime;
                }
            }


            public virtual DateTime ConfirmTime
            {
                set
                {
                    this.confirmTime = value;
                }
                get
                {
                    return this.confirmTime;
                }
            }


            public virtual long? RefundState
            {
                set
                {
                    this.refundState = value;
                }
                get
                {
                    return this.refundState;
                }
            }


            public virtual bool? IsRetailOrder
            {
                set
                {
                    this.isRetailOrder = value;
                }
                get
                {
                    return this.isRetailOrder;
                }
            }


            public virtual DateTime SuccessTime
            {
                set
                {
                    this.successTime = value;
                }
                get
                {
                    return this.successTime;
                }
            }


            public virtual long? OfflineId
            {
                set
                {
                    this.offlineId = value;
                }
                get
                {
                    return this.offlineId;
                }
            }


        }


    }
}