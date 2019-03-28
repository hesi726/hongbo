using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpPromocodeBuyerSearchResult : APIResult
	{



		/// <summary>
		/// 买家优惠码列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("codes")]//) private CouponCode[] codes;
		private CouponCode[] codes;

		public virtual CouponCode[] Codes
		{
			set
			{
				this.codes = value;
			}
			get
			{
				return this.codes;
			}
		}


		public class CouponCode
		{


			/// <summary>
			/// 卡券ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// kdtId
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 活动ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_group_id")]//) private Nullable<long> couponGroupId;
				internal long? couponGroupId;


			/// <summary>
			/// 优惠券熟悉 1：CASH（代金券）
			/// </summary>
[Newtonsoft.Json.JsonProperty("preferential_type")]//) private Nullable<long> preferentialType;
				internal long? preferentialType;


			/// <summary>
			/// 优惠面额（单位：分）
			/// </summary>
[Newtonsoft.Json.JsonProperty("value")]//) private Nullable<long> value;
				internal long? value;


			/// <summary>
			/// 优惠码（兑换码）
			/// </summary>
[Newtonsoft.Json.JsonProperty("code")]//) private String code;
				internal string code;


			/// <summary>
			/// 是否被使用 0：否 1：是
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_used")]//) private Nullable<long> isUsed;
				internal long? isUsed;


			/// <summary>
			/// 是否被领取 0：否 1：是
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_take")]//) private Nullable<long> isTake;
				internal long? isTake;


			/// <summary>
			/// 领取时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("take_at")]//) private java.util.Date takeAt;
				internal DateTime takeAt;


			/// <summary>
			/// 订单中优惠面值（单位：分）
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_value")]//) private Nullable<long> usedValue;
				internal long? usedValue;


			/// <summary>
			/// 使用时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_at")]//) private java.util.Date usedAt;
				internal DateTime usedAt;


			/// <summary>
			/// 使用订单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("used_in_order_no")]//) private String usedInOrderNo;
				internal string usedInOrderNo;


			/// <summary>
			/// 卡券有效开始时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("valid_start_at")]//) private java.util.Date validStartAt;
				internal DateTime validStartAt;


			/// <summary>
			/// 卡券有效过期时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("expire_at")]//) private java.util.Date expireAt;
				internal DateTime expireAt;


			/// <summary>
			/// 是否同步微信卡券 0：否 1：是
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_sync_card")]//) private Nullable<long> isSyncCard;
				internal long? isSyncCard;


			/// <summary>
			/// 核销码（卡券被用户使用时提供）
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


				public virtual long? IsTake
				{
					set
					{
					this.isTake = value;
					}
					get
					{
					return this.isTake;
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