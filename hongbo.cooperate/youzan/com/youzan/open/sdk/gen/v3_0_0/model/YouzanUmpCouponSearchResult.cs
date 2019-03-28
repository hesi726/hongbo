using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpCouponSearchResult : APIResult
	{



		/// <summary>
		/// 优惠活动组信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("groups")]//) private CouponGroup[] groups;
		private CouponGroup[] groups;


		/// <summary>
		/// 活动数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<long> total;
		private long? total;

		public virtual CouponGroup[] Groups
		{
			set
			{
				this.groups = value;
			}
			get
			{
				return this.groups;
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


		public class CouponGroup
		{


			/// <summary>
			/// 活动ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 店铺ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 优惠券类型 7：优惠券 9：优惠码 - 一卡一码 10：优惠码 - 通用码
			/// </summary>
[Newtonsoft.Json.JsonProperty("group_type")]//) private Nullable<long> groupType;
				internal long? groupType;


			/// <summary>
			/// 优惠券名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 优惠属性，1表示优惠，2表示折扣
			/// </summary>
[Newtonsoft.Json.JsonProperty("preferential_type")]//) private Nullable<long> preferentialType;
				internal long? preferentialType;


			/// <summary>
			/// 面额（单位分）
			/// </summary>
[Newtonsoft.Json.JsonProperty("denominations")]//) private Nullable<long> denominations;
				internal long? denominations;


			/// <summary>
			/// 面值随机上限。不随机为0
			/// </summary>
[Newtonsoft.Json.JsonProperty("value_random_to")]//) private Nullable<long> valueRandomTo;
				internal long? valueRandomTo;


			/// <summary>
			/// 满额条件
			/// </summary>
[Newtonsoft.Json.JsonProperty("condition")]//) private Nullable<long> condition;
				internal long? condition;


			/// <summary>
			/// 折扣（88，8.8折）
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount")]//) private Nullable<long> discount;
				internal long? discount;


			/// <summary>
			/// 是否限制 1：一人一次 0：不限制
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_limit")]//) private Nullable<long> isLimit;
				internal long? isLimit;


			/// <summary>
			/// 是否仅原价购买商品时可用（1:是，0:否）
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_forbid_preference")]//) private Nullable<long> isForbidPreference;
				internal long? isForbidPreference;


			/// <summary>
			/// 会员等级
			/// </summary>
[Newtonsoft.Json.JsonProperty("user_level")]//) private Nullable<long> userLevel;
				internal long? userLevel;


			/// <summary>
			/// 优惠使用时间类型，1表示固定活动时间，2表示延迟类型，几天后几天内有效
			/// </summary>
[Newtonsoft.Json.JsonProperty("date_type")]//) private Nullable<long> dateType;
				internal long? dateType;


			/// <summary>
			/// 固定时长
			/// </summary>
[Newtonsoft.Json.JsonProperty("fixed_term")]//) private Nullable<long> fixedTerm;
				internal long? fixedTerm;


			/// <summary>
			/// 延迟开始的时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("fixed_begin_term")]//) private Nullable<long> fixedBeginTerm;
				internal long? fixedBeginTerm;


			/// <summary>
			/// 有效开始时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("valid_start_time")]//) private java.util.Date validStartTime;
				internal DateTime validStartTime;


			/// <summary>
			/// 有效结束时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("valid_end_time")]//) private java.util.Date validEndTime;
				internal DateTime validEndTime;


			/// <summary>
			/// 总发放量
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_qty")]//) private Nullable<long> totalQty;
				internal long? totalQty;


			/// <summary>
			/// 库存数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock_qty")]//) private Nullable<long> stockQty;
				internal long? stockQty;


			/// <summary>
			/// 使用范围类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("range_type")]//) private String rangeType;
				internal string rangeType;


			/// <summary>
			/// 使用范围值
			/// </summary>
[Newtonsoft.Json.JsonProperty("range_value")]//) private String rangeValue;
				internal string rangeValue;


			/// <summary>
			/// 到期是否提醒 1是 0否
			/// </summary>
[Newtonsoft.Json.JsonProperty("expire_notice")]//) private String expireNotice;
				internal string expireNotice;


			/// <summary>
			/// 使用说明
			/// </summary>
[Newtonsoft.Json.JsonProperty("description")]//) private String description;
				internal string description;


			/// <summary>
			/// 一些额外配置信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("meta_data")]//) private String metaData;
				internal string metaData;


			/// <summary>
			/// 到期是否可分享 1是 0否
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_share")]//) private Nullable<long> isShare;
				internal long? isShare;


			/// <summary>
			/// 是否同步微信卡券 1是 0否
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_sync_weixin")]//) private Nullable<long> isSyncWeixin;
				internal long? isSyncWeixin;


			/// <summary>
			/// 是否失效，默认0为没失效
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_invalid")]//) private Nullable<long> isInvalid;
				internal long? isInvalid;


			/// <summary>
			/// 粉丝领取总人数(去重)
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_fans_taked")]//) private Nullable<long> totalFansTaked;
				internal long? totalFansTaked;


			/// <summary>
			/// 已使用总数
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_used")]//) private Nullable<long> totalUsed;
				internal long? totalUsed;


			/// <summary>
			/// 领取次数
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_take")]//) private Nullable<long> totalTake;
				internal long? totalTake;


			/// <summary>
			/// 创建于
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private java.util.Date createdAt;
				internal DateTime createdAt;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated_at")]//) private java.util.Date updatedAt;
				internal DateTime updatedAt;

				public virtual long? Id
				{
					set
					{
					this.id = value;
					}
					get
					{
					return this.id;
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


				public virtual long? GroupType
				{
					set
					{
					this.groupType = value;
					}
					get
					{
					return this.groupType;
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


				public virtual long? Denominations
				{
					set
					{
					this.denominations = value;
					}
					get
					{
					return this.denominations;
					}
				}


				public virtual long? ValueRandomTo
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


				public virtual long? Condition
				{
					set
					{
					this.condition = value;
					}
					get
					{
					return this.condition;
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


				public virtual long? IsLimit
				{
					set
					{
					this.isLimit = value;
					}
					get
					{
					return this.isLimit;
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


				public virtual long? UserLevel
				{
					set
					{
					this.userLevel = value;
					}
					get
					{
					return this.userLevel;
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


				public virtual DateTime ValidStartTime
				{
					set
					{
					this.validStartTime = value;
					}
					get
					{
					return this.validStartTime;
					}
				}


				public virtual DateTime ValidEndTime
				{
					set
					{
					this.validEndTime = value;
					}
					get
					{
					return this.validEndTime;
					}
				}


				public virtual long? TotalQty
				{
					set
					{
					this.totalQty = value;
					}
					get
					{
					return this.totalQty;
					}
				}


				public virtual long? StockQty
				{
					set
					{
					this.stockQty = value;
					}
					get
					{
					return this.stockQty;
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


				public virtual string RangeValue
				{
					set
					{
					this.rangeValue = value;
					}
					get
					{
					return this.rangeValue;
					}
				}


				public virtual string ExpireNotice
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


				public virtual string MetaData
				{
					set
					{
					this.metaData = value;
					}
					get
					{
					return this.metaData;
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


				public virtual long? IsInvalid
				{
					set
					{
					this.isInvalid = value;
					}
					get
					{
					return this.isInvalid;
					}
				}


				public virtual long? TotalFansTaked
				{
					set
					{
					this.totalFansTaked = value;
					}
					get
					{
					return this.totalFansTaked;
					}
				}


				public virtual long? TotalUsed
				{
					set
					{
					this.totalUsed = value;
					}
					get
					{
					return this.totalUsed;
					}
				}


				public virtual long? TotalTake
				{
					set
					{
					this.totalTake = value;
					}
					get
					{
					return this.totalTake;
					}
				}


				public virtual DateTime CreatedAt
				{
					set
					{
					this.createdAt = value;
					}
					get
					{
					return this.createdAt;
					}
				}


				public virtual DateTime UpdatedAt
				{
					set
					{
					this.updatedAt = value;
					}
					get
					{
					return this.updatedAt;
					}
				}


		}


	}
}