using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradesSoldGetResult : APIResult
	{



		/// <summary>
		/// 搜索到的交易总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total_results")]//) private Nullable<long> totalResults;
		private long? totalResults;


		/// <summary>
		/// 搜索到的交易列表
		/// 
		/// </summary>
[Newtonsoft.Json.JsonProperty("trades")]//) private TradeDetailV2[] trades;
		private TradeDetailV2[] trades;


		/// <summary>
		/// 是否存在下一页
		/// 
		/// </summary>
[Newtonsoft.Json.JsonProperty("has_next")]//) private Nullable<bool> hasNext;
		private bool? hasNext;

		public virtual long? TotalResults
		{
			set
			{
				this.totalResults = value;
			}
			get
			{
				return this.totalResults;
			}
		}

		public virtual TradeDetailV2[] Trades
		{
			set
			{
				this.trades = value;
			}
			get
			{
				return this.trades;
			}
		}

		public virtual bool? HasNext
		{
			set
			{
				this.hasNext = value;
			}
			get
			{
				return this.hasNext;
			}
		}


		public class HotelInfo
		{


			/// <summary>
			/// 入住时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("check_in_time")]//) private String checkInTime;
				internal string checkInTime;


			/// <summary>
			/// 退房时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("check_out_time")]//) private String checkOutTime;
				internal string checkOutTime;


			/// <summary>
			/// 入住人信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("accommodates")]//) private String[] accommodates;
				internal string[] accommodates;

				public virtual string CheckInTime
				{
					set
					{
					this.checkInTime = value;
					}
					get
					{
					return this.checkInTime;
					}
				}


				public virtual string CheckOutTime
				{
					set
					{
					this.checkOutTime = value;
					}
					get
					{
					return this.checkOutTime;
					}
				}


				public virtual string[] Accommodates
				{
					set
					{
					this.accommodates = value;
					}
					get
					{
					return this.accommodates;
					}
				}


		}

		public class TradeDetailV2
		{


			/// <summary>
			/// 交易编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("tid")]//) private String tid;
				internal string tid;


			/// <summary>
			/// 商品购买数量。当一个trade对应多个order的时候，值为所有商品购买数量之和
			/// </summary>
[Newtonsoft.Json.JsonProperty("num")]//) private Nullable<long> num;
				internal long? num;


			/// <summary>
			/// 商品数字编号。当一个trade对应多个order的时候，值为第一个交易明细中的商品的编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// 商品价格。精确到2位小数；单位：元。当一个trade对应多个order的时候，值为第一个交易明细中的商品的价格
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<float> price;
				internal float? price;


			/// <summary>
			/// 商品主图片地址。当一个trade对应多个order的时候，值为第一个交易明细中的商品的图片地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("pic_path")]//) private String picPath;
				internal string picPath;


			/// <summary>
			/// 商品主图片缩略图地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("pic_thumb_path")]//) private String picThumbPath;
				internal string picThumbPath;


			/// <summary>
			/// 交易标题，以首个商品标题作为此标题的值
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 交易类型。取值范围：<br>
			/// FIXED （一口价）<br>
			/// GIFT （送礼）<br>
			/// BULK_PURCHASE（来自分销商的采购）<br>
			/// PRESENT （赠品领取）<br>
			/// GROUP （拼团订单）<br>
			/// PIFA （批发订单）<br>
			/// COD （货到付款）<br>
			/// PEER （代付）<br>
			/// QRCODE（扫码商家二维码直接支付的交易）<br>
			/// QRCODE_3RD（线下收银台二维码交易)
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private String type;
				internal string type;


			/// <summary>
			/// 买家购买附言
			/// </summary>
[Newtonsoft.Json.JsonProperty("buyer_message")]//) private String buyerMessage;
				internal string buyerMessage;


			/// <summary>
			/// 卖家备注星标，取值范围 1、2、3、4、5；<br>如果为0，表示没有备注星标
			/// </summary>
[Newtonsoft.Json.JsonProperty("seller_flag")]//) private Nullable<long> sellerFlag;
				internal long? sellerFlag;


			/// <summary>
			/// 卖家对该交易的备注
			/// </summary>
[Newtonsoft.Json.JsonProperty("trade_memo")]//) private String tradeMemo;
				internal string tradeMemo;


			/// <summary>
			/// 收货人的所在城市。<br>
			/// PS：如果订单类型是送礼订单，收货地址在sub_trades字段中；如果物流方式是到店自提，收货地址在fetch_detail字段中
			/// </summary>
[Newtonsoft.Json.JsonProperty("receiver_city")]//) private String receiverCity;
				internal string receiverCity;


			/// <summary>
			/// 收货人的所在地区
			/// </summary>
[Newtonsoft.Json.JsonProperty("receiver_district")]//) private String receiverDistrict;
				internal string receiverDistrict;


			/// <summary>
			/// 收货人的姓名
			/// </summary>
[Newtonsoft.Json.JsonProperty("receiver_name")]//) private String receiverName;
				internal string receiverName;


			/// <summary>
			/// 收货人的所在省份
			/// </summary>
[Newtonsoft.Json.JsonProperty("receiver_state")]//) private String receiverState;
				internal string receiverState;


			/// <summary>
			/// 收货人的详细地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("receiver_address")]//) private String receiverAddress;
				internal string receiverAddress;


			/// <summary>
			/// 收货人的邮编
			/// </summary>
[Newtonsoft.Json.JsonProperty("receiver_zip")]//) private String receiverZip;
				internal string receiverZip;


			/// <summary>
			/// 收货人的手机号码
			/// </summary>
[Newtonsoft.Json.JsonProperty("receiver_mobile")]//) private String receiverMobile;
				internal string receiverMobile;


			/// <summary>
			/// 交易维权状态。<br>
			/// 0 无维权，1 顾客发起维权，2 顾客拒绝商家的处理结果，3 顾客接受商家的处理结果，9 商家正在处理,101 维权处理中,110 维权结束。<br>
			///  备注：1到10的状态码是微信维权状态码，100以上的状态码是有赞维权状态码
			/// </summary>
[Newtonsoft.Json.JsonProperty("feedback")]//) private Nullable<long> feedback;
				internal long? feedback;


			/// <summary>
			/// 退款状态。取值范围：<br>
			/// NO_REFUND（无退款）<br>
			/// PARTIAL_REFUNDING（部分退款中）<br>
			/// PARTIAL_REFUNDED（已部分退款）<br>
			/// PARTIAL_REFUND_FAILED（部分退款失败）<br>
			/// FULL_REFUNDING（全额退款中）<br>
			/// FULL_REFUNDED（已全额退款）<br>
			/// FULL_REFUND_FAILED（全额退款失败）<br>
			/// </summary>
[Newtonsoft.Json.JsonProperty("refund_state")]//) private String refundState;
				internal string refundState;


			/// <summary>
			/// 外部交易编号。比如，如果支付方式是微信支付，就是财付通的交易单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("outer_tid")]//) private String outerTid;
				internal string outerTid;


			/// <summary>
			/// 支付流水号
			/// </summary>
[Newtonsoft.Json.JsonProperty("transaction_tid")]//) private String transactionTid;
				internal string transactionTid;


			/// <summary>
			/// 交易状态。取值范围：<br>
			/// TRADE_NO_CREATE_PAY (没有创建支付交易) <br>
			/// WAIT_BUYER_PAY (等待买家付款) <br>
			/// WAIT_PAY_RETURN (等待支付确认) <br>
			/// WAIT_GROUP（等待成团，即：买家已付款，等待成团）<br>
			/// WAIT_SELLER_SEND_GOODS (等待卖家发货，即：买家已付款) <br>
			/// WAIT_BUYER_CONFIRM_GOODS (等待买家确认收货，即：卖家已发货) <br>
			/// TRADE_BUYER_SIGNED (买家已签收) <br>
			/// TRADE_CLOSED (付款以后用户退款成功，交易自动关
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private String status;
				internal string status;


			/// <summary>
			/// 创建交易时的物流方式。取值范围：express（快递），fetch（到店自提），local（同城配送）
			/// </summary>
[Newtonsoft.Json.JsonProperty("shipping_type")]//) private String shippingType;
				internal string shippingType;


			/// <summary>
			/// 运费。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("post_fee")]//) private Nullable<float> postFee;
				internal float? postFee;


			/// <summary>
			/// 商品总价（商品价格乘以数量的总金额）。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_fee")]//) private Nullable<float> totalFee;
				internal float? totalFee;


			/// <summary>
			/// 交易完成后退款的金额。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("refunded_fee")]//) private Nullable<float> refundedFee;
				internal float? refundedFee;


			/// <summary>
			/// 交易优惠金额（不包含交易明细中的优惠金额）。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount_fee")]//) private Nullable<float> discountFee;
				internal float? discountFee;


			/// <summary>
			/// 实付金额。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("payment")]//) private Nullable<float> payment;
				internal float? payment;


			/// <summary>
			/// 交易创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
				internal DateTime created;


			/// <summary>
			/// 交易更新时间。当交易的：状态改变、备注更改、星标更改 等情况下都会刷新更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("update_time")]//) private java.util.Date updateTime;
				internal DateTime updateTime;


			/// <summary>
			/// 买家付款时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("pay_time")]//) private java.util.Date payTime;
				internal DateTime payTime;


			/// <summary>
			/// 支付类型。取值范围：
			/// WEIXIN (微信自有支付)
			/// WEIXIN_DAIXIAO (微信代销支付)
			/// ALIPAY (支付宝支付)
			/// BANKCARDPAY (银行卡支付)
			/// PEERPAY (代付)
			/// CODPAY (货到付款)
			/// BAIDUPAY (百度钱包支付)
			/// PRESENTTAKE (直接领取赠品)
			/// COUPONPAY(优惠券/码全额抵扣)
			/// BULKPURCHASE(来自分销商的采购)
			/// MERGEDPAY(合并付货款)
			/// ECARD(有赞E卡支付)
			/// PURCHASE_PAY (采购单支付)
			/// MARKPAY (标记收款)
			/// OFCASH (现金支付)
			/// PREPAIDCARD (储值卡余额支付)
			/// </summary>
[Newtonsoft.Json.JsonProperty("pay_type")]//) private String payType;
				internal string payType;


			/// <summary>
			/// 卖家发货时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("consign_time")]//) private java.util.Date consignTime;
				internal DateTime consignTime;


			/// <summary>
			/// 买家签收时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("sign_time")]//) private java.util.Date signTime;
				internal DateTime signTime;


			/// <summary>
			/// 买家下单的地区
			/// </summary>
[Newtonsoft.Json.JsonProperty("buyer_area")]//) private String buyerArea;
				internal string buyerArea;


			/// <summary>
			/// 交易明细数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("orders")]//) private TradeOrderV2[] orders;
				internal TradeOrderV2[] orders;


			/// <summary>
			/// 到店自提详情
			/// </summary>
[Newtonsoft.Json.JsonProperty("fetch_detail")]//) private TradeFetch fetchDetail;
				internal TradeFetch fetchDetail;


			/// <summary>
			/// 订单中使用到的卡券的数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_details")]//) private UmpTradeCoupon[] couponDetails;
				internal UmpTradeCoupon[] couponDetails;


			/// <summary>
			/// 用户信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_info")]//) private FansInfo fansInfo;
				internal FansInfo fansInfo;


			/// <summary>
			/// 酒店入住信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("hotel_info")]//) private HotelInfo hotelInfo;
				internal HotelInfo hotelInfo;


			/// <summary>
			/// 订单中使用到的优惠活动的数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_details")]//) private TradePromotion[] promotionDetails;
				internal TradePromotion[] promotionDetails;


			/// <summary>
			/// 改价信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("adjust_fee")]//) private AdjustFee adjustFee;
				internal AdjustFee adjustFee;


			/// <summary>
			/// 交易中包含的子交易，目前：仅在送礼订单中会有子交易
			/// </summary>
[Newtonsoft.Json.JsonProperty("sub_trades")]//) private TradeDetailV2[] subTrades;
				internal TradeDetailV2[] subTrades;


			/// <summary>
			/// 分销/采购单:source:采购单;fenxiao:分销单 空串则为非分销/采购单
			/// </summary>
[Newtonsoft.Json.JsonProperty("relation_type")]//) private String relationType;
				internal string relationType;


			/// <summary>
			/// relation_type返回source时,为分销订单号列表<br>
			/// 返回fenxiao时,为供应商订单号列表<br>
			/// 返回空时,列表返回空
			/// </summary>
[Newtonsoft.Json.JsonProperty("relations")]//) private String[] relations;
				internal string[] relations;


			/// <summary>
			/// 代付订单外部交易号列表,非代付订单类型返回空
			/// </summary>
[Newtonsoft.Json.JsonProperty("out_trade_no")]//) private String[] outTradeNo;
				internal string[] outTradeNo;


			/// <summary>
			/// 利润（分销订单特有）。格式：5.20；单位：元；精确到：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("profit")]//) private Nullable<float> profit;
				internal float? profit;


			/// <summary>
			/// 结算状态（分销订单特有）。1：已结算，0：未结算
			/// </summary>
[Newtonsoft.Json.JsonProperty("handled")]//) private Nullable<long> handled;
				internal long? handled;


			/// <summary>
			/// 三方APP用户id
			/// </summary>
[Newtonsoft.Json.JsonProperty("outer_user_id")]//) private String outerUserId;
				internal string outerUserId;


			/// <summary>
			/// 多门店订单的门店id 非多门店订单则默认为0
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_id")]//) private Nullable<long> shopId;
				internal long? shopId;


			/// <summary>
			/// 表示线下网点id，包含自提点和门店
			/// </summary>
[Newtonsoft.Json.JsonProperty("offline_id")]//) private Nullable<long> offlineId;
				internal long? offlineId;


			/// <summary>
			/// 积分兑换订单，数值代表消耗的积分 非积分兑换订单默认为0
			/// </summary>
[Newtonsoft.Json.JsonProperty("points_price")]//) private Nullable<long> pointsPrice;
				internal long? pointsPrice;


			/// <summary>
			/// 拼团订单对应的团编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("tuan_no")]//) private String tuanNo;
				internal string tuanNo;


			/// <summary>
			/// 是否为团长订单 1 团长订单 0 非拼团订单 或 非团长订单
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_tuan_head")]//) private Nullable<long> isTuanHead;
				internal long? isTuanHead;


			/// <summary>
			/// 收银台订单的二维码id号
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_id")]//) private Nullable<long> qrId;
				internal long? qrId;


			/// <summary>
			/// 同城送订单送达时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_time_display")]//) private String deliveryTimeDisplay;
				internal string deliveryTimeDisplay;


			/// <summary>
			/// 海淘订单身份证信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("id_card_number")]//) private String idCardNumber;
				internal string idCardNumber;


			/// <summary>
			/// 周期购信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("period_order_detail")]//) private TradePeriodBuy periodOrderDetail;
				internal TradePeriodBuy periodOrderDetail;


			/// <summary>
			/// 纬度
			/// </summary>
[Newtonsoft.Json.JsonProperty("lat")]//) private String lat;
				internal string lat;


			/// <summary>
			/// 经度
			/// </summary>
[Newtonsoft.Json.JsonProperty("lng")]//) private String lng;
				internal string lng;


			/// <summary>
			/// 餐盒费
			/// </summary>
[Newtonsoft.Json.JsonProperty("box_price")]//) private Nullable<float> boxPrice;
				internal float? boxPrice;


			/// <summary>
			/// 发票抬头
			/// </summary>
[Newtonsoft.Json.JsonProperty("invoice_title")]//) private String invoiceTitle;
				internal string invoiceTitle;


			/// <summary>
			/// 订单状态描述:
			/// 待付款,待发货,待成团,待接单,已接单,已发货,已完成,已关闭
			/// </summary>
[Newtonsoft.Json.JsonProperty("status_str")]//) private String statusStr;
				internal string statusStr;

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


				public virtual string PicThumbPath
				{
					set
					{
					this.picThumbPath = value;
					}
					get
					{
					return this.picThumbPath;
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


				public virtual string Type
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


				public virtual long? SellerFlag
				{
					set
					{
					this.sellerFlag = value;
					}
					get
					{
					return this.sellerFlag;
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


				public virtual string ReceiverCity
				{
					set
					{
					this.receiverCity = value;
					}
					get
					{
					return this.receiverCity;
					}
				}


				public virtual string ReceiverDistrict
				{
					set
					{
					this.receiverDistrict = value;
					}
					get
					{
					return this.receiverDistrict;
					}
				}


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


				public virtual string ReceiverState
				{
					set
					{
					this.receiverState = value;
					}
					get
					{
					return this.receiverState;
					}
				}


				public virtual string ReceiverAddress
				{
					set
					{
					this.receiverAddress = value;
					}
					get
					{
					return this.receiverAddress;
					}
				}


				public virtual string ReceiverZip
				{
					set
					{
					this.receiverZip = value;
					}
					get
					{
					return this.receiverZip;
					}
				}


				public virtual string ReceiverMobile
				{
					set
					{
					this.receiverMobile = value;
					}
					get
					{
					return this.receiverMobile;
					}
				}


				public virtual long? Feedback
				{
					set
					{
					this.feedback = value;
					}
					get
					{
					return this.feedback;
					}
				}


				public virtual string RefundState
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


				public virtual string OuterTid
				{
					set
					{
					this.outerTid = value;
					}
					get
					{
					return this.outerTid;
					}
				}


				public virtual string TransactionTid
				{
					set
					{
					this.transactionTid = value;
					}
					get
					{
					return this.transactionTid;
					}
				}


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


				public virtual string ShippingType
				{
					set
					{
					this.shippingType = value;
					}
					get
					{
					return this.shippingType;
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


				public virtual float? RefundedFee
				{
					set
					{
					this.refundedFee = value;
					}
					get
					{
					return this.refundedFee;
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


				public virtual string PayType
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


				public virtual DateTime SignTime
				{
					set
					{
					this.signTime = value;
					}
					get
					{
					return this.signTime;
					}
				}


				public virtual string BuyerArea
				{
					set
					{
					this.buyerArea = value;
					}
					get
					{
					return this.buyerArea;
					}
				}


				public virtual TradeOrderV2[] Orders
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


				public virtual TradeFetch FetchDetail
				{
					set
					{
					this.fetchDetail = value;
					}
					get
					{
					return this.fetchDetail;
					}
				}


				public virtual UmpTradeCoupon[] CouponDetails
				{
					set
					{
					this.couponDetails = value;
					}
					get
					{
					return this.couponDetails;
					}
				}


				public virtual FansInfo FansInfo
				{
					set
					{
					this.fansInfo = value;
					}
					get
					{
					return this.fansInfo;
					}
				}


				public virtual HotelInfo HotelInfo
				{
					set
					{
					this.hotelInfo = value;
					}
					get
					{
					return this.hotelInfo;
					}
				}


				public virtual TradePromotion[] PromotionDetails
				{
					set
					{
					this.promotionDetails = value;
					}
					get
					{
					return this.promotionDetails;
					}
				}


				public virtual AdjustFee AdjustFee
				{
					set
					{
					this.adjustFee = value;
					}
					get
					{
					return this.adjustFee;
					}
				}


				public virtual TradeDetailV2[] SubTrades
				{
					set
					{
					this.subTrades = value;
					}
					get
					{
					return this.subTrades;
					}
				}


				public virtual string RelationType
				{
					set
					{
					this.relationType = value;
					}
					get
					{
					return this.relationType;
					}
				}


				public virtual string[] Relations
				{
					set
					{
					this.relations = value;
					}
					get
					{
					return this.relations;
					}
				}


				public virtual string[] OutTradeNo
				{
					set
					{
					this.outTradeNo = value;
					}
					get
					{
					return this.outTradeNo;
					}
				}


				public virtual float? Profit
				{
					set
					{
					this.profit = value;
					}
					get
					{
					return this.profit;
					}
				}


				public virtual long? Handled
				{
					set
					{
					this.handled = value;
					}
					get
					{
					return this.handled;
					}
				}


				public virtual string OuterUserId
				{
					set
					{
					this.outerUserId = value;
					}
					get
					{
					return this.outerUserId;
					}
				}


				public virtual long? ShopId
				{
					set
					{
					this.shopId = value;
					}
					get
					{
					return this.shopId;
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


				public virtual long? PointsPrice
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


				public virtual string TuanNo
				{
					set
					{
					this.tuanNo = value;
					}
					get
					{
					return this.tuanNo;
					}
				}


				public virtual long? IsTuanHead
				{
					set
					{
					this.isTuanHead = value;
					}
					get
					{
					return this.isTuanHead;
					}
				}


				public virtual long? QrId
				{
					set
					{
					this.qrId = value;
					}
					get
					{
					return this.qrId;
					}
				}


				public virtual string DeliveryTimeDisplay
				{
					set
					{
					this.deliveryTimeDisplay = value;
					}
					get
					{
					return this.deliveryTimeDisplay;
					}
				}


				public virtual string IdCardNumber
				{
					set
					{
					this.idCardNumber = value;
					}
					get
					{
					return this.idCardNumber;
					}
				}


				public virtual TradePeriodBuy PeriodOrderDetail
				{
					set
					{
					this.periodOrderDetail = value;
					}
					get
					{
					return this.periodOrderDetail;
					}
				}


				public virtual string Lat
				{
					set
					{
					this.lat = value;
					}
					get
					{
					return this.lat;
					}
				}


				public virtual string Lng
				{
					set
					{
					this.lng = value;
					}
					get
					{
					return this.lng;
					}
				}


				public virtual float? BoxPrice
				{
					set
					{
					this.boxPrice = value;
					}
					get
					{
					return this.boxPrice;
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


		}

		public class TradeFetch
		{


			/// <summary>
			/// 领取人（即：预约人）的姓名
			/// </summary>
[Newtonsoft.Json.JsonProperty("fetcher_name")]//) private String fetcherName;
				internal string fetcherName;


			/// <summary>
			/// 领取人的手机号
			/// </summary>
[Newtonsoft.Json.JsonProperty("fetcher_mobile")]//) private String fetcherMobile;
				internal string fetcherMobile;


			/// <summary>
			/// 预约的领取时间。新版到店自提的数据格式:<br>
			/// 1: 2016-04-18 17:00-17:15<br>
			/// 2: 尽快到店提货
			/// </summary>
[Newtonsoft.Json.JsonProperty("fetch_time")]//) private String fetchTime;
				internal string fetchTime;


			/// <summary>
			/// 自提点id
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_id")]//) private Nullable<long> shopId;
				internal long? shopId;


			/// <summary>
			/// 自提点名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_name")]//) private String shopName;
				internal string shopName;


			/// <summary>
			/// 自提点联系方式
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_mobile")]//) private String shopMobile;
				internal string shopMobile;


			/// <summary>
			/// 自提点所在省份
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_state")]//) private String shopState;
				internal string shopState;


			/// <summary>
			/// 自提点所在城市
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_city")]//) private String shopCity;
				internal string shopCity;


			/// <summary>
			/// 自提点所在地区
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_district")]//) private String shopDistrict;
				internal string shopDistrict;


			/// <summary>
			/// 自提点详细地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_address")]//) private String shopAddress;
				internal string shopAddress;

				public virtual string FetcherName
				{
					set
					{
					this.fetcherName = value;
					}
					get
					{
					return this.fetcherName;
					}
				}


				public virtual string FetcherMobile
				{
					set
					{
					this.fetcherMobile = value;
					}
					get
					{
					return this.fetcherMobile;
					}
				}


				public virtual string FetchTime
				{
					set
					{
					this.fetchTime = value;
					}
					get
					{
					return this.fetchTime;
					}
				}


				public virtual long? ShopId
				{
					set
					{
					this.shopId = value;
					}
					get
					{
					return this.shopId;
					}
				}


				public virtual string ShopName
				{
					set
					{
					this.shopName = value;
					}
					get
					{
					return this.shopName;
					}
				}


				public virtual string ShopMobile
				{
					set
					{
					this.shopMobile = value;
					}
					get
					{
					return this.shopMobile;
					}
				}


				public virtual string ShopState
				{
					set
					{
					this.shopState = value;
					}
					get
					{
					return this.shopState;
					}
				}


				public virtual string ShopCity
				{
					set
					{
					this.shopCity = value;
					}
					get
					{
					return this.shopCity;
					}
				}


				public virtual string ShopDistrict
				{
					set
					{
					this.shopDistrict = value;
					}
					get
					{
					return this.shopDistrict;
					}
				}


				public virtual string ShopAddress
				{
					set
					{
					this.shopAddress = value;
					}
					get
					{
					return this.shopAddress;
					}
				}


		}

		public class TradePromotion
		{


			/// <summary>
			/// 该优惠活动的ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_id")]//) private Nullable<long> promotionId;
				internal long? promotionId;


			/// <summary>
			/// 该优惠活动的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_name")]//) private String promotionName;
				internal string promotionName;


			/// <summary>
			/// 优惠的类型。可选值：<br> FULLREDUCE（满减满送）<br> ORDERCASHBACK（订单返现）<br> GROUPBUYING（商品团购）<br> GROUPON（多人拼团）<br> SECKILL（秒杀）<br> AUCTION（降价拍）
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_type")]//) private String promotionType;
				internal string promotionType;


			/// <summary>
			/// 优惠使用条件说明
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_condition")]//) private String promotionCondition;
				internal string promotionCondition;


			/// <summary>
			/// 使用时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_at")]//) private java.util.Date usedAt;
				internal DateTime usedAt;


			/// <summary>
			/// 优惠的金额，单位：元，精确到小数点后两位
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount_fee")]//) private Nullable<float> discountFee;
				internal float? discountFee;

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


				public virtual string PromotionName
				{
					set
					{
					this.promotionName = value;
					}
					get
					{
					return this.promotionName;
					}
				}


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


				public virtual DateTime UsedAt
				{
					set
					{
					this.usedAt = value;
					}
					get
					{
					return this.usedAt;
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


		}

		public class TradeBuyerMessage
		{


			/// <summary>
			/// 留言的标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 留言的内容
			/// </summary>
[Newtonsoft.Json.JsonProperty("content")]//) private String content;
				internal string content;

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


				public virtual string Content
				{
					set
					{
					this.content = value;
					}
					get
					{
					return this.content;
					}
				}


		}

		public class TradePeriodBuy
		{


			/// <summary>
			/// 当前待配送期次
			/// </summary>
[Newtonsoft.Json.JsonProperty("issue")]//) private Nullable<long> issue;
				internal long? issue;


			/// <summary>
			/// 当前待配送期次的具体配送日期
			/// </summary>
[Newtonsoft.Json.JsonProperty("plan_time")]//) private java.util.Date planTime;
				internal DateTime planTime;

				public virtual long? Issue
				{
					set
					{
					this.issue = value;
					}
					get
					{
					return this.issue;
					}
				}


				public virtual DateTime PlanTime
				{
					set
					{
					this.planTime = value;
					}
					get
					{
					return this.planTime;
					}
				}


		}

		public class FansInfo
		{


			/// <summary>
			/// 粉丝昵称 订单信息中存在三方(例如微信)粉丝昵称则取粉丝昵称;取不到粉丝昵称时则使用买家手机号;以上两点未满足时取买家收货人信息;无收货人信息时返回[匿名]
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_nickname")]//) private String fansNickname;
				internal string fansNickname;


			/// <summary>
			/// 粉丝id
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_id")]//) private Nullable<long> fansId;
				internal long? fansId;


			/// <summary>
			/// 有赞买家ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("buyer_id")]//) private Nullable<long> buyerId;
				internal long? buyerId;


			/// <summary>
			/// 0:未知、1:微信自有粉丝
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_type")]//) private Nullable<long> fansType;
				internal long? fansType;


			/// <summary>
			/// 微信openid
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_weixin_openid")]//) private String fansWeixinOpenid;
				internal string fansWeixinOpenid;

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


				public virtual string FansWeixinOpenid
				{
					set
					{
					this.fansWeixinOpenid = value;
					}
					get
					{
					return this.fansWeixinOpenid;
					}
				}


		}

		public class UmpTradeCoupon
		{


			/// <summary>
			/// 该组卡券的ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_id")]//) private Nullable<long> couponId;
				internal long? couponId;


			/// <summary>
			/// 该组卡券的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_name")]//) private String couponName;
				internal string couponName;


			/// <summary>
			/// 卡券的类型。可选值：PROMOCARD（优惠券）、PROMOCODE（优惠码）
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_type")]//) private String couponType;
				internal string couponType;


			/// <summary>
			/// 卡券内容。当卡券类型为优惠码时，值为优惠码字符串
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_content")]//) private String couponContent;
				internal string couponContent;


			/// <summary>
			/// 卡券的说明
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_description")]//) private String couponDescription;
				internal string couponDescription;


			/// <summary>
			/// 卡券使用条件说明
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_condition")]//) private String couponCondition;
				internal string couponCondition;


			/// <summary>
			/// 使用时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_at")]//) private java.util.Date usedAt;
				internal DateTime usedAt;


			/// <summary>
			/// 优惠的金额，单位：元，精确到小数点后两位
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount_fee")]//) private Nullable<float> discountFee;
				internal float? discountFee;

				public virtual long? CouponId
				{
					set
					{
					this.couponId = value;
					}
					get
					{
					return this.couponId;
					}
				}


				public virtual string CouponName
				{
					set
					{
					this.couponName = value;
					}
					get
					{
					return this.couponName;
					}
				}


				public virtual string CouponType
				{
					set
					{
					this.couponType = value;
					}
					get
					{
					return this.couponType;
					}
				}


				public virtual string CouponContent
				{
					set
					{
					this.couponContent = value;
					}
					get
					{
					return this.couponContent;
					}
				}


				public virtual string CouponDescription
				{
					set
					{
					this.couponDescription = value;
					}
					get
					{
					return this.couponDescription;
					}
				}


				public virtual string CouponCondition
				{
					set
					{
					this.couponCondition = value;
					}
					get
					{
					return this.couponCondition;
					}
				}


				public virtual DateTime UsedAt
				{
					set
					{
					this.usedAt = value;
					}
					get
					{
					return this.usedAt;
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


		}

		public class TradeOrderV2
		{


			/// <summary>
			/// 交易明细编号。该编号并不唯一，只用于区分交易内的多条明细记录
			/// </summary>
[Newtonsoft.Json.JsonProperty("oid")]//) private Nullable<long> oid;
				internal long? oid;


			/// <summary>
			/// 商品数字编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// Sku的ID，sku_id 在系统里<span style="color: #ff0000;">并不是唯一的</span>，结合商品ID一起使用才是唯一的。
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// Sku在系统中的唯一编号，可以在开发者的系统中用作 Sku 的唯一ID，但不能用于调用接口
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_unique_code")]//) private String skuUniqueCode;
				internal string skuUniqueCode;


			/// <summary>
			/// 商品购买数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("num")]//) private Nullable<long> num;
				internal long? num;


			/// <summary>
			/// 商家编码（商家为Sku设置的外部编号）
			/// </summary>
[Newtonsoft.Json.JsonProperty("outer_sku_id")]//) private String outerSkuId;
				internal string outerSkuId;


			/// <summary>
			/// 商品货号（商家为商品设置的外部编号）
			/// </summary>
[Newtonsoft.Json.JsonProperty("outer_item_id")]//) private String outerItemId;
				internal string outerItemId;


			/// <summary>
			/// 商品标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 卖家昵称
			/// </summary>
[Newtonsoft.Json.JsonProperty("seller_nick")]//) private String sellerNick;
				internal string sellerNick;


			/// <summary>
			/// 商品在分销商那边的出售价格。精确到2位小数；单位：元。如果是采购单才有值，否则值为 0
			/// </summary>
[Newtonsoft.Json.JsonProperty("fenxiao_price")]//) private Nullable<float> fenxiaoPrice;
				internal float? fenxiaoPrice;


			/// <summary>
			/// 商品在分销商那边的实付金额。精确到2位小数；单位：元。如果是采购单才有值，否则值为 0
			/// </summary>
[Newtonsoft.Json.JsonProperty("fenxiao_payment")]//) private Nullable<float> fenxiaoPayment;
				internal float? fenxiaoPayment;


			/// <summary>
			/// 商品价格。精确到2位小数；单位：元
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<float> price;
				internal float? price;


			/// <summary>
			/// 应付金额（商品价格乘以数量的总金额）
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_fee")]//) private Nullable<float> totalFee;
				internal float? totalFee;


			/// <summary>
			/// 交易明细内的优惠金额。精确到2位小数，单位：元
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount_fee")]//) private Nullable<float> discountFee;
				internal float? discountFee;


			/// <summary>
			/// 实付金额。精确到2位小数，单位：元
			/// </summary>
[Newtonsoft.Json.JsonProperty("payment")]//) private Nullable<float> payment;
				internal float? payment;


			/// <summary>
			/// SKU的值，即：商品的规格。如：机身颜色:黑色;手机套餐:官方标配
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_properties_name")]//) private String skuPropertiesName;
				internal string skuPropertiesName;


			/// <summary>
			/// 商品主图片地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("pic_path")]//) private String picPath;
				internal string picPath;


			/// <summary>
			/// 商品主图片缩略图地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("pic_thumb_path")]//) private String picThumbPath;
				internal string picThumbPath;


			/// <summary>
			/// 商品类型。<br>0：普通商品；<br>10：分销商品;
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_type")]//) private Nullable<long> itemType;
				internal long? itemType;


			/// <summary>
			/// 交易明细中买家留言的数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("buyer_messages")]//) private TradeBuyerMessage[] buyerMessages;
				internal TradeBuyerMessage[] buyerMessages;


			/// <summary>
			/// 交易明细中的优惠信息的数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("order_promotion_details")]//) private TradeOrderPromotion[] orderPromotionDetails;
				internal TradeOrderPromotion[] orderPromotionDetails;


			/// <summary>
			/// 商品状态
			/// </summary>
[Newtonsoft.Json.JsonProperty("state_str")]//) private String stateStr;
				internal string stateStr;


			/// <summary>
			/// 商品退款状态
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_refund_state")]//) private String itemRefundState;
				internal string itemRefundState;


			/// <summary>
			/// 1 虚拟商品 0 非虚拟商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_virtual")]//) private Nullable<long> isVirtual;
				internal long? isVirtual;


			/// <summary>
			/// 1 赠品商品 0 普通商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_present")]//) private Nullable<long> isPresent;
				internal long? isPresent;


			/// <summary>
			/// 退款金额
			/// </summary>
[Newtonsoft.Json.JsonProperty("refunded_fee")]//) private Nullable<float> refundedFee;
				internal float? refundedFee;


			/// <summary>
			/// 是否允许发货  1 可以发货 0 不能发货
			/// </summary>
[Newtonsoft.Json.JsonProperty("allow_send")]//) private Nullable<long> allowSend;
				internal long? allowSend;


			/// <summary>
			/// 是否发货 1 已发货 0 未发货
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_send")]//) private String isSend;
				internal string isSend;

				public virtual long? Oid
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


				public virtual string SkuUniqueCode
				{
					set
					{
					this.skuUniqueCode = value;
					}
					get
					{
					return this.skuUniqueCode;
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


				public virtual string SellerNick
				{
					set
					{
					this.sellerNick = value;
					}
					get
					{
					return this.sellerNick;
					}
				}


				public virtual float? FenxiaoPrice
				{
					set
					{
					this.fenxiaoPrice = value;
					}
					get
					{
					return this.fenxiaoPrice;
					}
				}


				public virtual float? FenxiaoPayment
				{
					set
					{
					this.fenxiaoPayment = value;
					}
					get
					{
					return this.fenxiaoPayment;
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


				public virtual string PicThumbPath
				{
					set
					{
					this.picThumbPath = value;
					}
					get
					{
					return this.picThumbPath;
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


				public virtual TradeBuyerMessage[] BuyerMessages
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


				public virtual TradeOrderPromotion[] OrderPromotionDetails
				{
					set
					{
					this.orderPromotionDetails = value;
					}
					get
					{
					return this.orderPromotionDetails;
					}
				}


				public virtual string StateStr
				{
					set
					{
					this.stateStr = value;
					}
					get
					{
					return this.stateStr;
					}
				}


				public virtual string ItemRefundState
				{
					set
					{
					this.itemRefundState = value;
					}
					get
					{
					return this.itemRefundState;
					}
				}


				public virtual long? IsVirtual
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


				public virtual long? IsPresent
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


				public virtual float? RefundedFee
				{
					set
					{
					this.refundedFee = value;
					}
					get
					{
					return this.refundedFee;
					}
				}


				public virtual long? AllowSend
				{
					set
					{
					this.allowSend = value;
					}
					get
					{
					return this.allowSend;
					}
				}


				public virtual string IsSend
				{
					set
					{
					this.isSend = value;
					}
					get
					{
					return this.isSend;
					}
				}


		}

		public class AdjustFee
		{


			/// <summary>
			/// 总改价金额
			/// </summary>
[Newtonsoft.Json.JsonProperty("change")]//) private Nullable<float> change;
				internal float? change;


			/// <summary>
			/// 订单改价
			/// </summary>
[Newtonsoft.Json.JsonProperty("pay_change")]//) private Nullable<float> payChange;
				internal float? payChange;


			/// <summary>
			/// 邮费改价
			/// </summary>
[Newtonsoft.Json.JsonProperty("post_change")]//) private Nullable<float> postChange;
				internal float? postChange;

				public virtual float? Change
				{
					set
					{
					this.change = value;
					}
					get
					{
					return this.change;
					}
				}


				public virtual float? PayChange
				{
					set
					{
					this.payChange = value;
					}
					get
					{
					return this.payChange;
					}
				}


				public virtual float? PostChange
				{
					set
					{
					this.postChange = value;
					}
					get
					{
					return this.postChange;
					}
				}


		}

		public class TradeOrderPromotion
		{


			/// <summary>
			/// 优惠的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_name")]//) private String promotionName;
				internal string promotionName;


			/// <summary>
			/// 优惠的类型。可选值：<br>MEMBER_CARD_DISCOUNT（会员卡折扣）
			/// <br>SCAN_DISCOUNT（扫码折扣）
			/// <br>SCAN_DECREASE（扫码减额优惠）
			/// <br>TIMELIMITED_DISCOUNT（限时折扣）
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_type")]//) private String promotionType;
				internal string promotionType;


			/// <summary>
			/// 应用优惠的时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("apply_at")]//) private java.util.Date applyAt;
				internal DateTime applyAt;


			/// <summary>
			/// 优惠的金额，单位：元，精确到小数点后两位
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount_fee")]//) private Nullable<float> discountFee;
				internal float? discountFee;

				public virtual string PromotionName
				{
					set
					{
					this.promotionName = value;
					}
					get
					{
					return this.promotionName;
					}
				}


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


				public virtual DateTime ApplyAt
				{
					set
					{
					this.applyAt = value;
					}
					get
					{
					return this.applyAt;
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


		}


	}
}