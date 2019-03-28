namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCardGetResult : APIResult
	{



		/// <summary>
		/// 商家会员卡的唯一标识
		/// </summary>
[Newtonsoft.Json.JsonProperty("card_alias")]//) private String cardAlias;
		private string cardAlias;


		/// <summary>
		/// 会员卡名
		/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
		private string name;


		/// <summary>
		/// 卡背景颜色
		/// </summary>
[Newtonsoft.Json.JsonProperty("color_code")]//) private String colorCode;
		private string colorCode;


		/// <summary>
		/// 使用须知
		/// </summary>
[Newtonsoft.Json.JsonProperty("description")]//) private String description;
		private string description;


		/// <summary>
		/// 客服电话
		/// </summary>
[Newtonsoft.Json.JsonProperty("service_phone")]//) private String servicePhone;
		private string servicePhone;


		/// <summary>
		/// 激活方式，0:不需要激活；1:仅需手机激活；2:手机+填写资料
		/// </summary>
[Newtonsoft.Json.JsonProperty("activate_mode")]//) private Nullable<long> activateMode;
		private long? activateMode;


		/// <summary>
		/// 微信卡包的同步设置
		/// 0:不同步；1:基于卡号核销；2:基于卡号和条形码；3:基于卡号和二维码
		/// </summary>
[Newtonsoft.Json.JsonProperty("sync_weixin_mode")]//) private Nullable<long> syncWeixinMode;
		private long? syncWeixinMode;


		/// <summary>
		/// 会员卡权益
		/// </summary>
[Newtonsoft.Json.JsonProperty("rights")]//) private CardRightsV2DTO[] rights;
		private CardRightsV2DTO[] rights;


		/// <summary>
		/// 生效开始时间，如："2017-03-07 00:00:00"
		/// </summary>
[Newtonsoft.Json.JsonProperty("term_start_time")]//) private String termStartTime;
		private string termStartTime;


		/// <summary>
		/// 生效结束时间，如："2017-03-08 00:00:00"
		/// </summary>
[Newtonsoft.Json.JsonProperty("term_end_time")]//) private String termEndTime;
		private string termEndTime;


		/// <summary>
		/// 生效持续天数
		/// </summary>
[Newtonsoft.Json.JsonProperty("term_days")]//) private Nullable<long> termDays;
		private long? termDays;


		/// <summary>
		/// 生效方式类型，1:从领取开始无期限；2:从固定时刻开始，到固定时刻结束；
		/// 3:从领取开始，持续一段时长(termDays)
		/// </summary>
[Newtonsoft.Json.JsonProperty("term_type")]//) private Nullable<long> termType;
		private long? termType;


		/// <summary>
		/// 失效后，默认转变的会员卡，默认不转变
		/// </summary>
[Newtonsoft.Json.JsonProperty("term_to_card_alias")]//) private String termToCardAlias;
		private string termToCardAlias;


		/// <summary>
		/// 是否允许微信端分享 ，默认允许
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_allow_share")]//) private Nullable<bool> isAllowShare;
		private bool? isAllowShare;


		/// <summary>
		/// 发卡链接
		/// </summary>
[Newtonsoft.Json.JsonProperty("card_url")]//) private String cardUrl;
		private string cardUrl;


		/// <summary>
		/// 同步微信卡状态，1：不同步；2：审核中；3：通过；4：失败
		/// </summary>
[Newtonsoft.Json.JsonProperty("sync_weixin_status")]//) private Nullable<long> syncWeixinStatus;
		private long? syncWeixinStatus;


		/// <summary>
		/// 会员卡状态，1：正常；2：已禁用；3：已删除
		/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
		private long? status;


		/// <summary>
		/// 会员卡等级，没有则为0
		/// </summary>
[Newtonsoft.Json.JsonProperty("level")]//) private Nullable<long> level;
		private long? level;


		/// <summary>
		/// 卡的类型;1:无门槛卡,2:规则卡,3:付费卡
		/// </summary>
[Newtonsoft.Json.JsonProperty("card_type")]//) private Nullable<long> cardType;
		private long? cardType;


		/// <summary>
		/// 当卡为规则卡时卡的发放规则
		/// </summary>
[Newtonsoft.Json.JsonProperty("grant_condition")]//) private GrantCondition grantCondition;
		private GrantCondition grantCondition;

		public virtual string CardAlias
		{
			set
			{
				this.cardAlias = value;
			}
			get
			{
				return this.cardAlias;
			}
		}

		public virtual string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name;
			}
		}

		public virtual string ColorCode
		{
			set
			{
				this.colorCode = value;
			}
			get
			{
				return this.colorCode;
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

		public virtual string ServicePhone
		{
			set
			{
				this.servicePhone = value;
			}
			get
			{
				return this.servicePhone;
			}
		}

		public virtual long? ActivateMode
		{
			set
			{
				this.activateMode = value;
			}
			get
			{
				return this.activateMode;
			}
		}

		public virtual long? SyncWeixinMode
		{
			set
			{
				this.syncWeixinMode = value;
			}
			get
			{
				return this.syncWeixinMode;
			}
		}

		public virtual CardRightsV2DTO[] Rights
		{
			set
			{
				this.rights = value;
			}
			get
			{
				return this.rights;
			}
		}

		public virtual string TermStartTime
		{
			set
			{
				this.termStartTime = value;
			}
			get
			{
				return this.termStartTime;
			}
		}

		public virtual string TermEndTime
		{
			set
			{
				this.termEndTime = value;
			}
			get
			{
				return this.termEndTime;
			}
		}

		public virtual long? TermDays
		{
			set
			{
				this.termDays = value;
			}
			get
			{
				return this.termDays;
			}
		}

		public virtual long? TermType
		{
			set
			{
				this.termType = value;
			}
			get
			{
				return this.termType;
			}
		}

		public virtual string TermToCardAlias
		{
			set
			{
				this.termToCardAlias = value;
			}
			get
			{
				return this.termToCardAlias;
			}
		}

		public virtual bool? IsAllowShare
		{
			set
			{
				this.isAllowShare = value;
			}
			get
			{
				return this.isAllowShare;
			}
		}

		public virtual string CardUrl
		{
			set
			{
				this.cardUrl = value;
			}
			get
			{
				return this.cardUrl;
			}
		}

		public virtual long? SyncWeixinStatus
		{
			set
			{
				this.syncWeixinStatus = value;
			}
			get
			{
				return this.syncWeixinStatus;
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

		public virtual long? Level
		{
			set
			{
				this.level = value;
			}
			get
			{
				return this.level;
			}
		}

		public virtual long? CardType
		{
			set
			{
				this.cardType = value;
			}
			get
			{
				return this.cardType;
			}
		}

		public virtual void setGrantCondition(GrantCondition grantCondition)
		{
			this.grantCondition = grantCondition;
		}

		public virtual GrantCondition getGrantCondition()
		{
			return this.grantCondition;
		}

		public class CouponRightsValueDTO
		{


			/// <summary>
			/// 优惠券ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_id")]//) private Nullable<long> couponId;
				internal long? couponId;


			/// <summary>
			/// 优惠券名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 优惠券数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("number")]//) private Nullable<long> number;
				internal long? number;

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


				public virtual string Name
				{
					set
					{
					this.name = value;
					}
					get
					{
					return this.name;
					}
				}


				public virtual long? Number
				{
					set
					{
					this.number = value;
					}
					get
					{
					return this.number;
					}
				}


		}

		public class CardRightsV2DTO
		{


			/// <summary>
			/// 权益类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 权益名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 是否可用
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_available")]//) private Nullable<bool> isAvailable;
				internal bool? isAvailable;


			/// <summary>
			/// 折扣权益字段，折数 ，1表示0.01折 范围选择：1-100, type为2时必传
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount")]//) private Nullable<long> discount;
				internal long? discount;


			/// <summary>
			/// 积分权益字段，积分数量,type为4时必传
			/// </summary>
[Newtonsoft.Json.JsonProperty("points")]//) private Nullable<long> points;
				internal long? points;


			/// <summary>
			/// 优惠券内容
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon")]//) private CouponRightsValueDTO[] coupon;
				internal CouponRightsValueDTO[] coupon;

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


				public virtual string Name
				{
					set
					{
					this.name = value;
					}
					get
					{
					return this.name;
					}
				}


				public virtual bool? IsAvailable
				{
					set
					{
					this.isAvailable = value;
					}
					get
					{
					return this.isAvailable;
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


				public virtual long? Points
				{
					set
					{
					this.points = value;
					}
					get
					{
					return this.points;
					}
				}


				public virtual CouponRightsValueDTO[] Coupon
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


		}

		public class GrantCondition
		{


			/// <summary>
			/// 累积下单成功次数
			/// </summary>
[Newtonsoft.Json.JsonProperty("trade_limit")]//) private Nullable<long> tradeLimit;
				internal long? tradeLimit;


			/// <summary>
			/// 累积消费金额(金额单位为分)
			/// </summary>
[Newtonsoft.Json.JsonProperty("amount_limit")]//) private Nullable<long> amountLimit;
				internal long? amountLimit;


			/// <summary>
			/// 累积积分
			/// </summary>
[Newtonsoft.Json.JsonProperty("points_limit")]//) private Nullable<long> pointsLimit;
				internal long? pointsLimit;

				public virtual long? TradeLimit
				{
					set
					{
					this.tradeLimit = value;
					}
					get
					{
					return this.tradeLimit;
					}
				}


				public virtual long? AmountLimit
				{
					set
					{
					this.amountLimit = value;
					}
					get
					{
					return this.amountLimit;
					}
				}


				public virtual long? PointsLimit
				{
					set
					{
					this.pointsLimit = value;
					}
					get
					{
					return this.pointsLimit;
					}
				}


		}


	}
}