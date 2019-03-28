namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeCartListResult : APIResult
	{



		/// <summary>
		/// 操作是否成功，true为成功，false为失败
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private Nullable<bool> isSuccess;
		private bool? isSuccess;


		/// <summary>
		/// 购物车中商品列表信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("data")]//) private CartFormat[] data;
		private CartFormat[] data;

		public virtual bool? IsSuccess
		{
			set
			{
				this.isSuccess = value;
			}
			get
			{
				return this.isSuccess;
			}
		}

		public virtual CartFormat[] Data
		{
			set
			{
				this.data = value;
			}
			get
			{
				return this.data;
			}
		}


		public class CartFormat
		{


			/// <summary>
			/// 门店id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 购物车显示商品信息列表中的goodsList
			/// </summary>
[Newtonsoft.Json.JsonProperty("unavailable_goods_list")]//) private CartGoodsListFormat[] unavailableGoodsList;
				internal CartGoodsListFormat[] unavailableGoodsList;


			/// <summary>
			/// 购物车显示商品信息列表中的goodsList
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_list")]//) private CartGoodsListFormat[] goodsList;
				internal CartGoodsListFormat[] goodsList;

				public virtual long? KdtId
				{
					set
					{
					this.kdtId = value;
					}
					get
					{
					return this.kdtId;
					}
				}


				public virtual CartGoodsListFormat[] UnavailableGoodsList
				{
					set
					{
					this.unavailableGoodsList = value;
					}
					get
					{
					return this.unavailableGoodsList;
					}
				}


				public virtual CartGoodsListFormat[] GoodsList
				{
					set
					{
					this.goodsList = value;
					}
					get
					{
					return this.goodsList;
					}
				}


		}

		public class CartGoodsListFormat
		{


			/// <summary>
			/// 附件url
			/// </summary>
[Newtonsoft.Json.JsonProperty("attachment_url")]//) private String attachmentUrl;
				internal string attachmentUrl;


			/// <summary>
			/// 商品sku id
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// 门店id
			/// </summary>
[Newtonsoft.Json.JsonProperty("store_id")]//) private Nullable<long> storeId;
				internal long? storeId;


			/// <summary>
			/// 折扣名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount_price")]//) private Nullable<long> discountPrice;
				internal long? discountPrice;


			/// <summary>
			/// 商品购买数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("num")]//) private Nullable<long> num;
				internal long? num;


			/// <summary>
			/// 买家购买附言
			/// </summary>
[Newtonsoft.Json.JsonProperty("message")]//) private String message;
				internal string message;


			/// <summary>
			/// 商品支付价格
			/// </summary>
[Newtonsoft.Json.JsonProperty("pay_price")]//) private Nullable<long> payPrice;
				internal long? payPrice;


			/// <summary>
			/// 商品类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_type")]//) private Nullable<long> goodsType;
				internal long? goodsType;


			/// <summary>
			/// 商品sku信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku")]//) private String sku;
				internal string sku;


			/// <summary>
			/// 库存数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock_num")]//) private Nullable<long> stockNum;
				internal long? stockNum;


			/// <summary>
			/// 商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_id")]//) private Nullable<long> goodsId;
				internal long? goodsId;


			/// <summary>
			/// 商品别名
			/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
				internal string alias;


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 商品优惠信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("ext")]//) private String ext;
				internal string ext;


			/// <summary>
			/// 错误信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("error_msg")]//) private String errorMsg;
				internal string errorMsg;


			/// <summary>
			/// 商品来源
			/// </summary>
[Newtonsoft.Json.JsonProperty("platform")]//) private String platform;
				internal string platform;


			/// <summary>
			/// 服务类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("service_type")]//) private Nullable<long> serviceType;
				internal long? serviceType;


			/// <summary>
			/// 商品在购物车中的更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated")]//) private Nullable<long> updated;
				internal long? updated;


			/// <summary>
			/// 商品优惠活动名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("activity_alias")]//) private String activityAlias;
				internal string activityAlias;


			/// <summary>
			/// 会话key
			/// </summary>
[Newtonsoft.Json.JsonProperty("nobody")]//) private String nobody;
				internal string nobody;


			/// <summary>
			/// 支持的快递类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("support_express_type")]//) private String supportExpressType;
				internal string supportExpressType;


			/// <summary>
			/// 商品折扣
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount")]//) private Nullable<long> discount;
				internal long? discount;


			/// <summary>
			/// 限购数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("thumb_url")]//) private String thumbUrl;
				internal string thumbUrl;
			/// 


[Newtonsoft.Json.JsonProperty("sub_type")]//) private Nullable<long> subType;
				internal long? subType;
			/// 


[Newtonsoft.Json.JsonProperty("limit_num")]//) private Nullable<long> limitNum;
				internal long? limitNum;


			/// <summary>
			/// 商品名
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 商品放入购物车时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("channel_id")]//) private Nullable<long> channelId;
				internal long? channelId;
			/// 


[Newtonsoft.Json.JsonProperty("direct_seller")]//) private Nullable<long> directSeller;
				internal long? directSeller;
			/// 


[Newtonsoft.Json.JsonProperty("create_time")]//) private Nullable<long> createTime;
				internal long? createTime;

				public virtual string AttachmentUrl
				{
					set
					{
					this.attachmentUrl = value;
					}
					get
					{
					return this.attachmentUrl;
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


				public virtual long? StoreId
				{
					set
					{
					this.storeId = value;
					}
					get
					{
					return this.storeId;
					}
				}


				public virtual long? DiscountPrice
				{
					set
					{
					this.discountPrice = value;
					}
					get
					{
					return this.discountPrice;
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


				public virtual string Message
				{
					set
					{
					this.message = value;
					}
					get
					{
					return this.message;
					}
				}


				public virtual long? PayPrice
				{
					set
					{
					this.payPrice = value;
					}
					get
					{
					return this.payPrice;
					}
				}


				public virtual long? GoodsType
				{
					set
					{
					this.goodsType = value;
					}
					get
					{
					return this.goodsType;
					}
				}


				public virtual string Sku
				{
					set
					{
					this.sku = value;
					}
					get
					{
					return this.sku;
					}
				}


				public virtual long? StockNum
				{
					set
					{
					this.stockNum = value;
					}
					get
					{
					return this.stockNum;
					}
				}


				public virtual long? GoodsId
				{
					set
					{
					this.goodsId = value;
					}
					get
					{
					return this.goodsId;
					}
				}


				public virtual string Alias
				{
					set
					{
					this.alias = value;
					}
					get
					{
					return this.alias;
					}
				}


				public virtual long? KdtId
				{
					set
					{
					this.kdtId = value;
					}
					get
					{
					return this.kdtId;
					}
				}


				public virtual string Ext
				{
					set
					{
					this.ext = value;
					}
					get
					{
					return this.ext;
					}
				}


				public virtual string ErrorMsg
				{
					set
					{
					this.errorMsg = value;
					}
					get
					{
					return this.errorMsg;
					}
				}


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


				public virtual long? ServiceType
				{
					set
					{
					this.serviceType = value;
					}
					get
					{
					return this.serviceType;
					}
				}


				public virtual long? Updated
				{
					set
					{
					this.updated = value;
					}
					get
					{
					return this.updated;
					}
				}


				public virtual string ActivityAlias
				{
					set
					{
					this.activityAlias = value;
					}
					get
					{
					return this.activityAlias;
					}
				}


				public virtual string Nobody
				{
					set
					{
					this.nobody = value;
					}
					get
					{
					return this.nobody;
					}
				}


				public virtual string SupportExpressType
				{
					set
					{
					this.supportExpressType = value;
					}
					get
					{
					return this.supportExpressType;
					}
				}


				public virtual long? Discount
				{
					set
					{
					this.discount = value;
					}
					get
					{
					return this.discount;
					}
				}


				public virtual string ThumbUrl
				{
					set
					{
					this.thumbUrl = value;
					}
					get
					{
					return this.thumbUrl;
					}
				}


				public virtual long? SubType
				{
					set
					{
					this.subType = value;
					}
					get
					{
					return this.subType;
					}
				}


				public virtual long? LimitNum
				{
					set
					{
					this.limitNum = value;
					}
					get
					{
					return this.limitNum;
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


				public virtual long? ChannelId
				{
					set
					{
					this.channelId = value;
					}
					get
					{
					return this.channelId;
					}
				}


				public virtual long? DirectSeller
				{
					set
					{
					this.directSeller = value;
					}
					get
					{
					return this.directSeller;
					}
				}


				public virtual long? CreateTime
				{
					set
					{
					this.createTime = value;
					}
					get
					{
					return this.createTime;
					}
				}


		}


	}
}