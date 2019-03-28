using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpCouponConsumeFetchlogsGetResult : APIResult
	{



		/// <summary>
		/// 领取记录
		/// </summary>
[Newtonsoft.Json.JsonProperty("fetchlogs")]//) private UmpPromotionFetchlog[] fetchlogs;
		private UmpPromotionFetchlog[] fetchlogs;


		/// <summary>
		/// 领取总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total_results")]//) private Nullable<long> totalResults;
		private long? totalResults;

		public virtual UmpPromotionFetchlog[] Fetchlogs
		{
			set
			{
				this.fetchlogs = value;
			}
			get
			{
				return this.fetchlogs;
			}
		}

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


		public class UmpPromotionFetchlog
		{


			/// <summary>
			/// 优惠券／优惠码活动的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 领取人fans_id
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_id")]//) private Nullable<long> fansId;
				internal long? fansId;


			/// <summary>
			/// 领取人用户类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_type")]//) private Nullable<long> fansType;
				internal long? fansType;


			/// <summary>
			/// 使用的订单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_in_order_no")]//) private String usedInOrderNo;
				internal string usedInOrderNo;


			/// <summary>
			/// 是否已使用 0未使用 1已使用
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_used")]//) private Nullable<long> isUsed;
				internal long? isUsed;


			/// <summary>
			/// 使用时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_at")]//) private java.util.Date usedAt;
				internal DateTime usedAt;


			/// <summary>
			/// 优惠券和通用优惠码的领取时间；若优惠码是用户自行导入的，则为优惠码导入时间。
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private java.util.Date createdAt;
				internal DateTime createdAt;


			/// <summary>
			/// 优惠码ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("promocode_id")]//) private Nullable<long> promocodeId;
				internal long? promocodeId;


			/// <summary>
			/// 优惠券ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("promocard_id")]//) private Nullable<long> promocardId;
				internal long? promocardId;


			/// <summary>
			/// 手机号（若有）
			/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
				internal string mobile;


			/// <summary>
			/// 领取时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("taked_at")]//) private java.util.Date takedAt;
				internal DateTime takedAt;


			/// <summary>
			/// 三方用户ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("open_user_id")]//) private String openUserId;
				internal string openUserId;

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


				public virtual string UsedInOrderNo
				{
					set
					{
					this.usedInOrderNo = value;
					}
					get
					{
					return this.usedInOrderNo;
					}
				}


				public virtual long? IsUsed
				{
					set
					{
					this.isUsed = value;
					}
					get
					{
					return this.isUsed;
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


				public virtual string Mobile
				{
					set
					{
					this.mobile = value;
					}
					get
					{
					return this.mobile;
					}
				}


				public virtual DateTime TakedAt
				{
					set
					{
					this.takedAt = value;
					}
					get
					{
					return this.takedAt;
					}
				}


				public virtual string OpenUserId
				{
					set
					{
					this.openUserId = value;
					}
					get
					{
					return this.openUserId;
					}
				}


		}


	}
}