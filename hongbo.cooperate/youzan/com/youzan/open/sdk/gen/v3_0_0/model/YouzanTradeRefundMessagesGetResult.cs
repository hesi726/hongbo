using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeRefundMessagesGetResult : APIResult
	{



		/// <summary>
		/// 退款记录
		/// </summary>
[Newtonsoft.Json.JsonProperty("refund_messages")]//) private RefundMessages[] refundMessages;
		private RefundMessages[] refundMessages;

		public virtual void setRefundMessages(RefundMessages[] refundMessages)
		{
			this.refundMessages = refundMessages;
		}

		public virtual RefundMessages[] getRefundMessages()
		{
			return this.refundMessages;
		}

		public class RefundMessages
		{


			/// <summary>
			/// 角色 2买家 3卖家
			/// </summary>
[Newtonsoft.Json.JsonProperty("owner_role")]//) private Nullable<long> ownerRole;
				internal long? ownerRole;


			/// <summary>
			/// 退款时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
				internal DateTime created;


			/// <summary>
			/// 退款id
			/// </summary>
[Newtonsoft.Json.JsonProperty("refund_id")]//) private String refundId;
				internal string refundId;


			/// <summary>
			/// 描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("content")]//) private String content;
				internal string content;

				public virtual long? OwnerRole
				{
					set
					{
					this.ownerRole = value;
					}
					get
					{
					return this.ownerRole;
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


				public virtual string RefundId
				{
					set
					{
					this.refundId = value;
					}
					get
					{
					return this.refundId;
					}
				}


				public virtual string Content
				{
					set
					{
					this.content = value;
					}
					get
					{
					return this.content;
					}
				}


		}


	}
}