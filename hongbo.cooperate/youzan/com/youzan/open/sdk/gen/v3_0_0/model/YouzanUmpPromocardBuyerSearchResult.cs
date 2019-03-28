using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpPromocardBuyerSearchResult : APIResult
	{



		/// <summary>
		/// 优惠券列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("cards")]//) private CouponCard[] cards;
		private CouponCard[] cards;

		public virtual CouponCard[] Cards
		{
			set
			{
				this.cards = value;
			}
			get
			{
				return this.cards;
			}
		}


		public class CouponCard
		{


			/// <summary>
			/// 卡ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 店铺ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 活动ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_group_id")]//) private Nullable<long> couponGroupId;
				internal long? couponGroupId;


			/// <summary>
			/// 优惠属性，1：CASH，2：discount
			/// </summary>
[Newtonsoft.Json.JsonProperty("preferential_type")]//) private Nullable<long> preferentialType;
				internal long? preferentialType;


			/// <summary>
			/// 面额（单位：分）
			/// </summary>
[Newtonsoft.Json.JsonProperty("value")]//) private Nullable<long> value;
				internal long? value;


			/// <summary>
			/// 领取到的折扣值（88，8.8折）
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount")]//) private Nullable<long> discount;
				internal long? discount;


			/// <summary>
			/// 是否已使用 1 是 0 否
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_used")]//) private Nullable<long> isUsed;
				internal long? isUsed;


			/// <summary>
			/// 领取时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("take_at")]//) private java.util.Date takeAt;
				internal DateTime takeAt;


			/// <summary>
			/// 实际优惠金额（单位：分）
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_value")]//) private Nullable<long> usedValue;
				internal long? usedValue;


			/// <summary>
			/// 使用时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_at")]//) private java.util.Date usedAt;
				internal DateTime usedAt;


			/// <summary>
			/// 用于订单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_in_order_no")]//) private String usedInOrderNo;
				internal string usedInOrderNo;


			/// <summary>
			/// 优惠开始时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("valid_start_at")]//) private java.util.Date validStartAt;
				internal DateTime validStartAt;


			/// <summary>
			/// 过期时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("expire_at")]//) private java.util.Date expireAt;
				internal DateTime expireAt;


			/// <summary>
			/// 是否已同步卡包 1: 已同步 2:已删除
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_sync_card")]//) private Nullable<long> isSyncCard;
				internal long? isSyncCard;


			/// <summary>
			/// 核销码
			/// </summary>
[Newtonsoft.Json.JsonProperty("verify_code")]//) private String verifyCode;
				internal string verifyCode;

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


				public virtual long? CouponGroupId
				{
					set
					{
					this.couponGroupId = value;
					}
					get
					{
					return this.couponGroupId;
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


				public virtual long? Value
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


				public virtual DateTime TakeAt
				{
					set
					{
					this.takeAt = value;
					}
					get
					{
					return this.takeAt;
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


				public virtual DateTime ValidStartAt
				{
					set
					{
					this.validStartAt = value;
					}
					get
					{
					return this.validStartAt;
					}
				}


				public virtual DateTime ExpireAt
				{
					set
					{
					this.expireAt = value;
					}
					get
					{
					return this.expireAt;
					}
				}


				public virtual long? IsSyncCard
				{
					set
					{
					this.isSyncCard = value;
					}
					get
					{
					return this.isSyncCard;
					}
				}


				public virtual string VerifyCode
				{
					set
					{
					this.verifyCode = value;
					}
					get
					{
					return this.verifyCode;
					}
				}


		}


	}
}