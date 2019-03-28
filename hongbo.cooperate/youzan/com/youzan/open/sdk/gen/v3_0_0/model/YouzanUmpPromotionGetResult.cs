using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpPromotionGetResult : APIResult
	{



		/// <summary>
		/// 商品级优惠信息，没有优惠则为null
		/// </summary>
[Newtonsoft.Json.JsonProperty("item_promotion")]//) private UmpPromotionItem itemPromotion;
		private UmpPromotionItem itemPromotion;


		/// <summary>
		/// 订单级优惠信息，没有优惠则为空数组
		/// </summary>
[Newtonsoft.Json.JsonProperty("order_promotions")]//) private UmpPromotionOrder[] orderPromotions;
		private UmpPromotionOrder[] orderPromotions;


		/// <summary>
		/// 商品参与积分抵扣活动优惠信息，没有参与则为null
		/// </summary>
[Newtonsoft.Json.JsonProperty("goods_points")]//) private UmpPromotionPointsexchange goodsPoints;
		private UmpPromotionPointsexchange goodsPoints;


		/// <summary>
		/// 商品参与的优惠套餐活动优惠信息，没有参与则为null
		/// </summary>
[Newtonsoft.Json.JsonProperty("package_buy")]//) private UmpPromotionPackagebuyDetail packageBuy;
		private UmpPromotionPackagebuyDetail packageBuy;

		public virtual UmpPromotionItem ItemPromotion
		{
			set
			{
				this.itemPromotion = value;
			}
			get
			{
				return this.itemPromotion;
			}
		}

		public virtual UmpPromotionOrder[] OrderPromotions
		{
			set
			{
				this.orderPromotions = value;
			}
			get
			{
				return this.orderPromotions;
			}
		}

		public virtual UmpPromotionPointsexchange GoodsPoints
		{
			set
			{
				this.goodsPoints = value;
			}
			get
			{
				return this.goodsPoints;
			}
		}

		public virtual UmpPromotionPackagebuyDetail PackageBuy
		{
			set
			{
				this.packageBuy = value;
			}
			get
			{
				return this.packageBuy;
			}
		}


		public class UmpPromotionItem
		{


			/// <summary>
			/// 优惠活动类型编码：
			/// <br>2：团购
			/// <br>3：降价拍
			/// <br>4：多人拼团
			/// <br>6：秒杀
			/// <br>10：会员折扣
			/// <br>11：限时折扣
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_type_id")]//) private Nullable<long> promotionTypeId;
				internal long? promotionTypeId;


			/// <summary>
			/// 优惠活动编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_id")]//) private Nullable<long> promotionId;
				internal long? promotionId;


			/// <summary>
			/// 优惠活动别名
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_alias")]//) private String promotionAlias;
				internal string promotionAlias;


			/// <summary>
			/// 优惠活动名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_name")]//) private String promotionName;
				internal string promotionName;


			/// <summary>
			/// 优惠活动描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;


			/// <summary>
			/// 优惠活动开始时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("start_date")]//) private java.util.Date startDate;
				internal DateTime startDate;


			/// <summary>
			/// 优惠活动结束时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("end_date")]//) private java.util.Date endDate;
				internal DateTime endDate;


			/// <summary>
			/// sku的id，以半角","号分隔（同sku_price_list的顺序保持一一对应关系）
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id_list")]//) private String skuIdList;
				internal string skuIdList;


			/// <summary>
			/// sku优惠后的价格，原位元，精确到分，以半角","号分隔（同sku_id_list的顺序保持一一对应关系）
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_price_list")]//) private String skuPriceList;
				internal string skuPriceList;


			/// <summary>
			/// 优惠活动独立库存，为-1表示没有独立库存。如秒杀、降价拍，都有各自的独立库存
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock")]//) private Nullable<long> stock;
				internal long? stock;


			/// <summary>
			/// 该优惠活动商品是否能够加购物车
			/// </summary>
[Newtonsoft.Json.JsonProperty("can_join_cart")]//) private Nullable<bool> canJoinCart;
				internal bool? canJoinCart;

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


				public virtual string PromotionAlias
				{
					set
					{
					this.promotionAlias = value;
					}
					get
					{
					return this.promotionAlias;
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


				public virtual string Desc
				{
					set
					{
					this.desc = value;
					}
					get
					{
					return this.desc;
					}
				}


				public virtual DateTime StartDate
				{
					set
					{
					this.startDate = value;
					}
					get
					{
					return this.startDate;
					}
				}


				public virtual DateTime EndDate
				{
					set
					{
					this.endDate = value;
					}
					get
					{
					return this.endDate;
					}
				}


				public virtual string SkuIdList
				{
					set
					{
					this.skuIdList = value;
					}
					get
					{
					return this.skuIdList;
					}
				}


				public virtual string SkuPriceList
				{
					set
					{
					this.skuPriceList = value;
					}
					get
					{
					return this.skuPriceList;
					}
				}


				public virtual long? Stock
				{
					set
					{
					this.stock = value;
					}
					get
					{
					return this.stock;
					}
				}


				public virtual bool? CanJoinCart
				{
					set
					{
					this.canJoinCart = value;
					}
					get
					{
					return this.canJoinCart;
					}
				}


		}

		public class UmpPromotionPackagebuyDetail
		{


			/// <summary>
			/// 优惠套餐活动类型编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_type_id")]//) private Nullable<long> promotionTypeId;
				internal long? promotionTypeId;


			/// <summary>
			/// 优惠活动编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_id")]//) private Nullable<long> promotionId;
				internal long? promotionId;


			/// <summary>
			/// 优惠活动名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_name")]//) private String promotionName;
				internal string promotionName;


			/// <summary>
			/// 优惠活动描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;


			/// <summary>
			/// 优惠活动开始时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("start_date")]//) private java.util.Date startDate;
				internal DateTime startDate;


			/// <summary>
			/// 优惠活动结束时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("end_date")]//) private java.util.Date endDate;
				internal DateTime endDate;


			/// <summary>
			/// 优惠套餐商品数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_list")]//) private UmpPromotionPackagebuyGoods[] goodsList;
				internal UmpPromotionPackagebuyGoods[] goodsList;

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


				public virtual string Desc
				{
					set
					{
					this.desc = value;
					}
					get
					{
					return this.desc;
					}
				}


				public virtual DateTime StartDate
				{
					set
					{
					this.startDate = value;
					}
					get
					{
					return this.startDate;
					}
				}


				public virtual DateTime EndDate
				{
					set
					{
					this.endDate = value;
					}
					get
					{
					return this.endDate;
					}
				}


				public virtual UmpPromotionPackagebuyGoods[] GoodsList
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

		public class UmpPromotionPackagebuyGoods
		{


			/// <summary>
			/// 商品标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 商品价格，格式：5.00；单位：元；精确到：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<float> price;
				internal float? price;


			/// <summary>
			/// 商品主图片地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("pic_url")]//) private String picUrl;
				internal string picUrl;


			/// <summary>
			/// 商品主图片缩略图地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("pic_thumb_url")]//) private String picThumbUrl;
				internal string picThumbUrl;

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


				public virtual string PicUrl
				{
					set
					{
					this.picUrl = value;
					}
					get
					{
					return this.picUrl;
					}
				}


				public virtual string PicThumbUrl
				{
					set
					{
					this.picThumbUrl = value;
					}
					get
					{
					return this.picThumbUrl;
					}
				}


		}

		public class UmpPromotionPointsexchange
		{


			/// <summary>
			/// 积分兑换活动类型编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_type_id")]//) private Nullable<long> promotionTypeId;
				internal long? promotionTypeId;


			/// <summary>
			/// 优惠活动编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_id")]//) private Nullable<long> promotionId;
				internal long? promotionId;


			/// <summary>
			/// 优惠活动名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_name")]//) private String promotionName;
				internal string promotionName;


			/// <summary>
			/// 兑换所需积分
			/// </summary>
[Newtonsoft.Json.JsonProperty("exchange_points")]//) private Nullable<long> exchangePoints;
				internal long? exchangePoints;


			/// <summary>
			/// 兑换所需价格，格式：5.00；单位：元；精确到：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("exchange_price")]//) private Nullable<float> exchangePrice;
				internal float? exchangePrice;


			/// <summary>
			/// 优惠活动开始时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("start_date")]//) private java.util.Date startDate;
				internal DateTime startDate;


			/// <summary>
			/// 优惠活动结束时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("end_date")]//) private java.util.Date endDate;
				internal DateTime endDate;

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


				public virtual long? ExchangePoints
				{
					set
					{
					this.exchangePoints = value;
					}
					get
					{
					return this.exchangePoints;
					}
				}


				public virtual float? ExchangePrice
				{
					set
					{
					this.exchangePrice = value;
					}
					get
					{
					return this.exchangePrice;
					}
				}


				public virtual DateTime StartDate
				{
					set
					{
					this.startDate = value;
					}
					get
					{
					return this.startDate;
					}
				}


				public virtual DateTime EndDate
				{
					set
					{
					this.endDate = value;
					}
					get
					{
					return this.endDate;
					}
				}


		}

		public class UmpPromotionOrder
		{


			/// <summary>
			/// 优惠活动类型编码：
			/// <br>101：满减送
			/// <br>102：订单返现
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_type_id")]//) private Nullable<long> promotionTypeId;
				internal long? promotionTypeId;


			/// <summary>
			/// 优惠活动编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_id")]//) private Nullable<long> promotionId;
				internal long? promotionId;


			/// <summary>
			/// 优惠活动名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_name")]//) private String promotionName;
				internal string promotionName;


			/// <summary>
			/// 优惠活动描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;


			/// <summary>
			/// 优惠活动开始时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("start_date")]//) private java.util.Date startDate;
				internal DateTime startDate;


			/// <summary>
			/// 优惠活动结束时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("end_date")]//) private java.util.Date endDate;
				internal DateTime endDate;

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


				public virtual string Desc
				{
					set
					{
					this.desc = value;
					}
					get
					{
					return this.desc;
					}
				}


				public virtual DateTime StartDate
				{
					set
					{
					this.startDate = value;
					}
					get
					{
					return this.startDate;
					}
				}


				public virtual DateTime EndDate
				{
					set
					{
					this.endDate = value;
					}
					get
					{
					return this.endDate;
					}
				}


		}


	}
}