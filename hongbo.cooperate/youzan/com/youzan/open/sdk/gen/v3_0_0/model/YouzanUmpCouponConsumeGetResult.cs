using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpCouponConsumeGetResult : APIResult
	{



		/// <summary>
		/// 核销码
		/// </summary>
[Newtonsoft.Json.JsonProperty("code")]//) private String code;
		private string code;


		/// <summary>
		/// 核销状态，0表示未核销，1表示已核销
		/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
		private long? status;


		/// <summary>
		/// 核销时间，格式，如果未核销，则为空 
		/// </summary>
[Newtonsoft.Json.JsonProperty("consume_at")]//) private java.util.Date consumeAt;
		private DateTime consumeAt;


		/// <summary>
		/// 核销编号。如果卡券已被独立核销，值为核销编号；如果卡券在商城的交易中被核销、或者未核销，值为空 
		/// </summary>
[Newtonsoft.Json.JsonProperty("consume_id")]//) private String consumeId;
		private string consumeId;


		/// <summary>
		/// 优惠券/优惠码信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("coupon")]//) private UmpCoupon coupon;
		private UmpCoupon coupon;


		/// <summary>
		/// 优惠码ID
		/// </summary>
[Newtonsoft.Json.JsonProperty("promocode_id")]//) private Nullable<long> promocodeId;
		private long? promocodeId;


		/// <summary>
		/// 优惠码。如果卡券是优惠码类型展示优惠码。
		/// </summary>
[Newtonsoft.Json.JsonProperty("promocode")]//) private String promocode;
		private string promocode;


		/// <summary>
		/// 优惠券ID
		/// </summary>
[Newtonsoft.Json.JsonProperty("promocard_id")]//) private Nullable<long> promocardId;
		private long? promocardId;


		/// <summary>
		/// 实际核销金额,单位为分
		/// </summary>
[Newtonsoft.Json.JsonProperty("used_value")]//) private Nullable<long> usedValue;
		private long? usedValue;

		public virtual string Code
		{
			set
			{
				this.code = value;
			}
			get
			{
				return this.code;
			}
		}

		public virtual long? Status
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

		public virtual DateTime ConsumeAt
		{
			set
			{
				this.consumeAt = value;
			}
			get
			{
				return this.consumeAt;
			}
		}

		public virtual string ConsumeId
		{
			set
			{
				this.consumeId = value;
			}
			get
			{
				return this.consumeId;
			}
		}

		public virtual UmpCoupon Coupon
		{
			set
			{
				this.coupon = value;
			}
			get
			{
				return this.coupon;
			}
		}

		public virtual long? PromocodeId
		{
			set
			{
				this.promocodeId = value;
			}
			get
			{
				return this.promocodeId;
			}
		}

		public virtual string Promocode
		{
			set
			{
				this.promocode = value;
			}
			get
			{
				return this.promocode;
			}
		}

		public virtual long? PromocardId
		{
			set
			{
				this.promocardId = value;
			}
			get
			{
				return this.promocardId;
			}
		}

		public virtual long? UsedValue
		{
			set
			{
				this.usedValue = value;
			}
			get
			{
				return this.usedValue;
			}
		}


		public class UmpCoupon
		{


			/// <summary>
			/// 优惠的ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("group_id")]//) private Nullable<long> groupId;
				internal long? groupId;


			/// <summary>
			/// 优惠的类型。可选值：PROMOCARD（优惠券）、PROMOCODE（优惠码）
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_type")]//) private String couponType;
				internal string couponType;


			/// <summary>
			/// 可用范围的类型，可选值：
			/// <br>PART（部分商品可用，或指定商品可用）
			/// <br>ALL（全部商品可用）
			/// </summary>
[Newtonsoft.Json.JsonProperty("range_type")]//) private String rangeType;
				internal string rangeType;


			/// <summary>
			/// 优惠标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 优惠面额。如果 is_random 为 1，则该字段表示随机金额的下限。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("value")]//) private Nullable<float> value;
				internal float? value;


			/// <summary>
			/// 是否是随机优惠，0 表示不随机，1 表示随机
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_random")]//) private Nullable<long> isRandom;
				internal long? isRandom;


			/// <summary>
			/// 如果 is_random 为 1，则该字段表示随机金额的上限。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("value_random_to")]//) private Nullable<float> valueRandomTo;
				internal float? valueRandomTo;


			/// <summary>
			/// 是否限制领用者的等级，0 表示不限制，大于 0 表示领用者必须是这个等级ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("need_user_level")]//) private Nullable<long> needUserLevel;
				internal long? needUserLevel;


			/// <summary>
			/// 限制领用者等级的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("user_level_name")]//) private String userLevelName;
				internal string userLevelName;


			/// <summary>
			/// 每人限领个数，为 0 则表示不限制
			/// </summary>
[Newtonsoft.Json.JsonProperty("quota")]//) private Nullable<long> quota;
				internal long? quota;


			/// <summary>
			/// 是否设置满多少元可用，0 表示不限制，1 表示限制
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_at_least")]//) private Nullable<long> isAtLeast;
				internal long? isAtLeast;


			/// <summary>
			/// 如果 is_at_least 为 1，该字段表示订单必须满这个价格，优惠才可用。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("at_least")]//) private Nullable<float> atLeast;
				internal float? atLeast;


			/// <summary>
			/// 总库存
			/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<long> total;
				internal long? total;


			/// <summary>
			/// 剩余可用库存
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock")]//) private Nullable<long> stock;
				internal long? stock;


			/// <summary>
			/// 优惠生效时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("start_at")]//) private java.util.Date startAt;
				internal DateTime startAt;


			/// <summary>
			/// 优惠结束时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("end_at")]//) private java.util.Date endAt;
				internal DateTime endAt;


			/// <summary>
			/// 是否到期前4天发送提醒，0 表示不发送，1 表示发送
			/// </summary>
[Newtonsoft.Json.JsonProperty("expire_notice")]//) private Nullable<long> expireNotice;
				internal long? expireNotice;


			/// <summary>
			/// 使用说明
			/// </summary>
[Newtonsoft.Json.JsonProperty("description")]//) private String description;
				internal string description;


			/// <summary>
			/// 是否仅原价购买商品时可用，0 表示否，1 表示是
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_forbid_preference")]//) private Nullable<long> isForbidPreference;
				internal long? isForbidPreference;


			/// <summary>
			/// 是否同步微信卡券，0 表示否，1 表示是
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_sync_weixin")]//) private Nullable<long> isSyncWeixin;
				internal long? isSyncWeixin;


			/// <summary>
			/// 微信卡券ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("weixin_card_id")]//) private String weixinCardId;
				internal string weixinCardId;


			/// <summary>
			/// 优惠状态，0 表示有效，1 表示失效，2 表示微信卡券审核中
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
				internal long? status;


			/// <summary>
			/// 是否可分享领取链接，0 表示否，1 表示是
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_share")]//) private Nullable<long> isShare;
				internal long? isShare;


			/// <summary>
			/// 优惠领取链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("fetch_url")]//) private String fetchUrl;
				internal string fetchUrl;


			/// <summary>
			/// 领取优惠的人数
			/// </summary>
[Newtonsoft.Json.JsonProperty("stat_fetch_user_num")]//) private Nullable<long> statFetchUserNum;
				internal long? statFetchUserNum;


			/// <summary>
			/// 领取优惠的次数
			/// </summary>
[Newtonsoft.Json.JsonProperty("stat_fetch_num")]//) private Nullable<long> statFetchNum;
				internal long? statFetchNum;


			/// <summary>
			/// 使用优惠的次数
			/// </summary>
[Newtonsoft.Json.JsonProperty("stat_use_num")]//) private Nullable<long> statUseNum;
				internal long? statUseNum;


			/// <summary>
			/// 优惠创建时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
				internal DateTime created;


			/// <summary>
			/// 优惠券更新时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated")]//) private java.util.Date updated;
				internal DateTime updated;


			/// <summary>
			/// 1表示优惠,2表示折扣
			/// </summary>
[Newtonsoft.Json.JsonProperty("preferential_type")]//) private Nullable<long> preferentialType;
				internal long? preferentialType;


			/// <summary>
			/// 领取到的折扣值
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount")]//) private Nullable<long> discount;
				internal long? discount;


			/// <summary>
			/// 优惠使用时间类型, 1表示固定活动时间，2表示动态类型,几天后几天内有效
			/// </summary>
[Newtonsoft.Json.JsonProperty("date_type")]//) private Nullable<long> dateType;
				internal long? dateType;


			/// <summary>
			/// 优惠有效固定时长
			/// </summary>
[Newtonsoft.Json.JsonProperty("fixed_term")]//) private Nullable<long> fixedTerm;
				internal long? fixedTerm;


			/// <summary>
			/// 延迟开始的时间, 延迟几天生效
			/// </summary>
[Newtonsoft.Json.JsonProperty("fixed_begin_term")]//) private Nullable<long> fixedBeginTerm;
				internal long? fixedBeginTerm;

				public virtual long? GroupId
				{
					set
					{
					this.groupId = value;
					}
					get
					{
					return this.groupId;
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


				public virtual string RangeType
				{
					set
					{
					this.rangeType = value;
					}
					get
					{
					return this.rangeType;
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


				public virtual float? Value
				{
					set
					{
					this.value = value;
					}
					get
					{
					return this.value;
					}
				}


				public virtual long? IsRandom
				{
					set
					{
					this.isRandom = value;
					}
					get
					{
					return this.isRandom;
					}
				}


				public virtual float? ValueRandomTo
				{
					set
					{
					this.valueRandomTo = value;
					}
					get
					{
					return this.valueRandomTo;
					}
				}


				public virtual long? NeedUserLevel
				{
					set
					{
					this.needUserLevel = value;
					}
					get
					{
					return this.needUserLevel;
					}
				}


				public virtual string UserLevelName
				{
					set
					{
					this.userLevelName = value;
					}
					get
					{
					return this.userLevelName;
					}
				}


				public virtual long? Quota
				{
					set
					{
					this.quota = value;
					}
					get
					{
					return this.quota;
					}
				}


				public virtual long? IsAtLeast
				{
					set
					{
					this.isAtLeast = value;
					}
					get
					{
					return this.isAtLeast;
					}
				}


				public virtual float? AtLeast
				{
					set
					{
					this.atLeast = value;
					}
					get
					{
					return this.atLeast;
					}
				}


				public virtual long? Total
				{
					set
					{
					this.total = value;
					}
					get
					{
					return this.total;
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


				public virtual DateTime StartAt
				{
					set
					{
					this.startAt = value;
					}
					get
					{
					return this.startAt;
					}
				}


				public virtual DateTime EndAt
				{
					set
					{
					this.endAt = value;
					}
					get
					{
					return this.endAt;
					}
				}


				public virtual long? ExpireNotice
				{
					set
					{
					this.expireNotice = value;
					}
					get
					{
					return this.expireNotice;
					}
				}


				public virtual string Description
				{
					set
					{
					this.description = value;
					}
					get
					{
					return this.description;
					}
				}


				public virtual long? IsForbidPreference
				{
					set
					{
					this.isForbidPreference = value;
					}
					get
					{
					return this.isForbidPreference;
					}
				}


				public virtual long? IsSyncWeixin
				{
					set
					{
					this.isSyncWeixin = value;
					}
					get
					{
					return this.isSyncWeixin;
					}
				}


				public virtual string WeixinCardId
				{
					set
					{
					this.weixinCardId = value;
					}
					get
					{
					return this.weixinCardId;
					}
				}


				public virtual long? Status
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


				public virtual long? IsShare
				{
					set
					{
					this.isShare = value;
					}
					get
					{
					return this.isShare;
					}
				}


				public virtual string FetchUrl
				{
					set
					{
					this.fetchUrl = value;
					}
					get
					{
					return this.fetchUrl;
					}
				}


				public virtual long? StatFetchUserNum
				{
					set
					{
					this.statFetchUserNum = value;
					}
					get
					{
					return this.statFetchUserNum;
					}
				}


				public virtual long? StatFetchNum
				{
					set
					{
					this.statFetchNum = value;
					}
					get
					{
					return this.statFetchNum;
					}
				}


				public virtual long? StatUseNum
				{
					set
					{
					this.statUseNum = value;
					}
					get
					{
					return this.statUseNum;
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


				public virtual DateTime Updated
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


				public virtual long? PreferentialType
				{
					set
					{
					this.preferentialType = value;
					}
					get
					{
					return this.preferentialType;
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


				public virtual long? DateType
				{
					set
					{
					this.dateType = value;
					}
					get
					{
					return this.dateType;
					}
				}


				public virtual long? FixedTerm
				{
					set
					{
					this.fixedTerm = value;
					}
					get
					{
					return this.fixedTerm;
					}
				}


				public virtual long? FixedBeginTerm
				{
					set
					{
					this.fixedBeginTerm = value;
					}
					get
					{
					return this.fixedBeginTerm;
					}
				}


		}


	}
}