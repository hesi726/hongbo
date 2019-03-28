using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpCouponTakeResult : APIResult
	{



		/// <summary>
		/// 值：1.PROMOCODE（表示优惠码） 2.PROMOCARD（表示优惠券）
		/// </summary>
[Newtonsoft.Json.JsonProperty("coupon_type")]//) private String couponType;
		private string couponType;


		/// <summary>
		/// 用户领取优惠码详情
		/// </summary>
[Newtonsoft.Json.JsonProperty("promocode")]//) private UmpPromocodeUserTakedetail promocode;
		private UmpPromocodeUserTakedetail promocode;


		/// <summary>
		/// 用户领取优惠券详情（优惠码or优惠券详情只返回其一） 
		/// </summary>
[Newtonsoft.Json.JsonProperty("promocard")]//) private UmpPromocardUserTakedetail promocard;
		private UmpPromocardUserTakedetail promocard;

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

		public virtual UmpPromocodeUserTakedetail Promocode
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

		public virtual UmpPromocardUserTakedetail Promocard
		{
			set
			{
				this.promocard = value;
			}
			get
			{
				return this.promocard;
			}
		}


		public class UmpPromocodeUserTakedetail
		{


			/// <summary>
			/// 优惠码id
			/// </summary>
[Newtonsoft.Json.JsonProperty("promocode_id")]//) private Nullable<long> promocodeId;
				internal long? promocodeId;


			/// <summary>
			/// 优惠码标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 优惠码编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("code")]//) private String code;
				internal string code;


			/// <summary>
			/// 优惠码面额
			/// </summary>
[Newtonsoft.Json.JsonProperty("value")]//) private Nullable<float> value;
				internal float? value;


			/// <summary>
			/// 优惠码满额条件
			/// </summary>
[Newtonsoft.Json.JsonProperty("condition")]//) private String condition;
				internal string condition;


			/// <summary>
			/// 优惠码生效时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("start_at")]//) private java.util.Date startAt;
				internal DateTime startAt;


			/// <summary>
			/// 优惠码结束时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("end_at")]//) private java.util.Date endAt;
				internal DateTime endAt;


			/// <summary>
			/// 优惠码是否已使用，0 表示未使用，1 表示已使用
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_used")]//) private Nullable<long> isUsed;
				internal long? isUsed;


			/// <summary>
			/// 优惠码是否已实效，0 表示未实效，1 表示已实效
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_invalid")]//) private Nullable<long> isInvalid;
				internal long? isInvalid;


			/// <summary>
			/// 优惠码是否已过期，0 表示未过期，1 表示已过期
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_expired")]//) private Nullable<long> isExpired;
				internal long? isExpired;


			/// <summary>
			/// 优惠码背景颜色
			/// </summary>
[Newtonsoft.Json.JsonProperty("background_color")]//) private String backgroundColor;
				internal string backgroundColor;


			/// <summary>
			/// 优惠码详情链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("detail_url")]//) private String detailUrl;
				internal string detailUrl;


			/// <summary>
			/// 优惠券核销码
			/// </summary>
[Newtonsoft.Json.JsonProperty("verify_code")]//) private String verifyCode;
				internal string verifyCode;

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


				public virtual string Condition
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


				public virtual long? IsExpired
				{
					set
					{
					this.isExpired = value;
					}
					get
					{
					return this.isExpired;
					}
				}


				public virtual string BackgroundColor
				{
					set
					{
					this.backgroundColor = value;
					}
					get
					{
					return this.backgroundColor;
					}
				}


				public virtual string DetailUrl
				{
					set
					{
					this.detailUrl = value;
					}
					get
					{
					return this.detailUrl;
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

		public class UmpPromocardUserTakedetail
		{


			/// <summary>
			/// 优惠券Id
			/// </summary>
[Newtonsoft.Json.JsonProperty("promocard_id")]//) private Nullable<long> promocardId;
				internal long? promocardId;


			/// <summary>
			/// 优惠券标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 优惠券面额
			/// </summary>
[Newtonsoft.Json.JsonProperty("value")]//) private Nullable<float> value;
				internal float? value;


			/// <summary>
			/// 优惠券满额条件
			/// </summary>
[Newtonsoft.Json.JsonProperty("condition")]//) private String condition;
				internal string condition;


			/// <summary>
			/// 优惠券生效时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("start_at")]//) private java.util.Date startAt;
				internal DateTime startAt;


			/// <summary>
			/// 优惠券结束时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("end_at")]//) private java.util.Date endAt;
				internal DateTime endAt;


			/// <summary>
			/// 优惠券是否已使用，0 表示未使用，1 表示已使用
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_used")]//) private Nullable<long> isUsed;
				internal long? isUsed;


			/// <summary>
			/// 优惠券是否已实效，0 表示未实效，1 表示已实效
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_invalid")]//) private Nullable<long> isInvalid;
				internal long? isInvalid;


			/// <summary>
			/// 优惠券是否已过期，0 表示未过期，1 表示已过期
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_expired")]//) private Nullable<long> isExpired;
				internal long? isExpired;


			/// <summary>
			/// 优惠券背景颜色
			/// </summary>
[Newtonsoft.Json.JsonProperty("background_color")]//) private String backgroundColor;
				internal string backgroundColor;


			/// <summary>
			/// 优惠券详情链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("detail_url")]//) private String detailUrl;
				internal string detailUrl;


			/// <summary>
			/// 优惠券核销码
			/// </summary>
[Newtonsoft.Json.JsonProperty("verify_code")]//) private String verifyCode;
				internal string verifyCode;

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


				public virtual string Condition
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


				public virtual long? IsExpired
				{
					set
					{
					this.isExpired = value;
					}
					get
					{
					return this.isExpired;
					}
				}


				public virtual string BackgroundColor
				{
					set
					{
					this.backgroundColor = value;
					}
					get
					{
					return this.backgroundColor;
					}
				}


				public virtual string DetailUrl
				{
					set
					{
					this.detailUrl = value;
					}
					get
					{
					return this.detailUrl;
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