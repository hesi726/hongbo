using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpCouponConsumeVerifylogsGetResult : APIResult
	{



		/// <summary>
		/// 验证列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("verifylogs")]//) private UmpPromotionVerifylog[] verifylogs;
		private UmpPromotionVerifylog[] verifylogs;

		public virtual UmpPromotionVerifylog[] Verifylogs
		{
			set
			{
				this.verifylogs = value;
			}
			get
			{
				return this.verifylogs;
			}
		}


		public class UmpPromotionVerifylog
		{


			/// <summary>
			/// 记录的ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private String id;
				internal string id;


			/// <summary>
			/// 优惠的ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("group_id")]//) private String groupId;
				internal string groupId;


			/// <summary>
			/// 优惠券／优惠码的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 面额。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("value")]//) private String value;
				internal string value;


			/// <summary>
			/// 满额条件。单位：元，精确到分
			/// </summary>
[Newtonsoft.Json.JsonProperty("condition")]//) private String condition;
				internal string condition;


			/// <summary>
			/// 使用说明
			/// </summary>
[Newtonsoft.Json.JsonProperty("description")]//) private String description;
				internal string description;


			/// <summary>
			/// 验证方式 1扫码 2输入id
			/// </summary>
[Newtonsoft.Json.JsonProperty("verify_type")]//) private String verifyType;
				internal string verifyType;


			/// <summary>
			/// 核销号码
			/// </summary>
[Newtonsoft.Json.JsonProperty("verify_code")]//) private String verifyCode;
				internal string verifyCode;


			/// <summary>
			/// 交易号
			/// </summary>
[Newtonsoft.Json.JsonProperty("trade_no")]//) private String tradeNo;
				internal string tradeNo;


			/// <summary>
			/// 状态
			/// </summary>
[Newtonsoft.Json.JsonProperty("state")]//) private String state;
				internal string state;


			/// <summary>
			/// 验证人员
			/// </summary>
[Newtonsoft.Json.JsonProperty("admin_nickname")]//) private String adminNickname;
				internal string adminNickname;


			/// <summary>
			/// 验证时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private java.util.Date createdAt;
				internal DateTime createdAt;


			/// <summary>
			/// 优惠券ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("promocard_id")]//) private String promocardId;
				internal string promocardId;


			/// <summary>
			/// 优惠码ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("promocode_id")]//) private String promocodeId;
				internal string promocodeId;

				public virtual string Id
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


				public virtual string GroupId
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


				public virtual string Value
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


				public virtual string VerifyType
				{
					set
					{
					this.verifyType = value;
					}
					get
					{
					return this.verifyType;
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


				public virtual string TradeNo
				{
					set
					{
					this.tradeNo = value;
					}
					get
					{
					return this.tradeNo;
					}
				}


				public virtual string State
				{
					set
					{
					this.state = value;
					}
					get
					{
					return this.state;
					}
				}


				public virtual string AdminNickname
				{
					set
					{
					this.adminNickname = value;
					}
					get
					{
					return this.adminNickname;
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


				public virtual string PromocardId
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


				public virtual string PromocodeId
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


		}


	}
}