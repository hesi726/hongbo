using System;

namespace com.youzan.open.sdk.gen.v1_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpGrouponOrdergroupdetailsGetResult : APIResult
	{



		/// <summary>
		/// 订单拼团详情
		/// </summary>
[Newtonsoft.Json.JsonProperty("order_group_detail")]//) private OrderGroupDetail[] orderGroupDetail;
		private OrderGroupDetail[] orderGroupDetail;

		public virtual void setOrderGroupDetail(OrderGroupDetail[] orderGroupDetail)
		{
			this.orderGroupDetail = orderGroupDetail;
		}

		public virtual OrderGroupDetail[] getOrderGroupDetail()
		{
			return this.orderGroupDetail;
		}

		public class GroupOnGroupJoin
		{


			/// <summary>
			/// 唯一标示
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 订单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("tid")]//) private String tid;
				internal string tid;


			/// <summary>
			/// 店铺ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("sid")]//) private Nullable<long> sid;
				internal long? sid;


			/// <summary>
			/// 拼团活动ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("activity_id")]//) private Nullable<long> activityId;
				internal long? activityId;


			/// <summary>
			/// 成团活动ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("group_id")]//) private Nullable<long> groupId;
				internal long? groupId;


			/// <summary>
			/// 粉丝ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_id")]//) private Nullable<long> fansId;
				internal long? fansId;


			/// <summary>
			/// 买家ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("buyer_id")]//) private Nullable<long> buyerId;
				internal long? buyerId;


			/// <summary>
			/// 退款状态；0：没有退款、1：退款成功、2：退款失败
			/// </summary>
[Newtonsoft.Json.JsonProperty("refund_state")]//) private Nullable<long> refundState;
				internal long? refundState;


			/// <summary>
			/// 退款原因
			/// </summary>
[Newtonsoft.Json.JsonProperty("refund_reason")]//) private String refundReason;
				internal string refundReason;


			/// <summary>
			/// 退款失败原因
			/// </summary>
[Newtonsoft.Json.JsonProperty("refund_fail_msg")]//) private String refundFailMsg;
				internal string refundFailMsg;


			/// <summary>
			/// 支付状态；0：未支付；1：支付成功
			/// </summary>
[Newtonsoft.Json.JsonProperty("pay_state")]//) private Nullable<long> payState;
				internal long? payState;


			/// <summary>
			/// 支付成功时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("pay_time")]//) private java.util.Date payTime;
				internal DateTime payTime;


			/// <summary>
			/// 商品编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// SKU编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// 拼团优惠金额，单位：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount_fee")]//) private Nullable<long> discountFee;
				internal long? discountFee;


			/// <summary>
			/// 团长额外优惠金额，单位：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("head_extra_discount_fee")]//) private Nullable<long> headExtraDiscountFee;
				internal long? headExtraDiscountFee;


			/// <summary>
			/// 是否代收
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_agency_receive")]//) private Nullable<bool> isAgencyReceive;
				internal bool? isAgencyReceive;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_time")]//) private java.util.Date createdTime;
				internal DateTime createdTime;

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


				public virtual string Tid
				{
					set
					{
					this.tid = value;
					}
					get
					{
					return this.tid;
					}
				}


				public virtual long? Sid
				{
					set
					{
					this.sid = value;
					}
					get
					{
					return this.sid;
					}
				}


				public virtual long? ActivityId
				{
					set
					{
					this.activityId = value;
					}
					get
					{
					return this.activityId;
					}
				}


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


				public virtual long? BuyerId
				{
					set
					{
					this.buyerId = value;
					}
					get
					{
					return this.buyerId;
					}
				}


				public virtual long? RefundState
				{
					set
					{
					this.refundState = value;
					}
					get
					{
					return this.refundState;
					}
				}


				public virtual string RefundReason
				{
					set
					{
					this.refundReason = value;
					}
					get
					{
					return this.refundReason;
					}
				}


				public virtual string RefundFailMsg
				{
					set
					{
					this.refundFailMsg = value;
					}
					get
					{
					return this.refundFailMsg;
					}
				}


				public virtual long? PayState
				{
					set
					{
					this.payState = value;
					}
					get
					{
					return this.payState;
					}
				}


				public virtual DateTime PayTime
				{
					set
					{
					this.payTime = value;
					}
					get
					{
					return this.payTime;
					}
				}


				public virtual long? ItemId
				{
					set
					{
					this.itemId = value;
					}
					get
					{
					return this.itemId;
					}
				}


				public virtual long? SkuId
				{
					set
					{
					this.skuId = value;
					}
					get
					{
					return this.skuId;
					}
				}


				public virtual long? DiscountFee
				{
					set
					{
					this.discountFee = value;
					}
					get
					{
					return this.discountFee;
					}
				}


				public virtual long? HeadExtraDiscountFee
				{
					set
					{
					this.headExtraDiscountFee = value;
					}
					get
					{
					return this.headExtraDiscountFee;
					}
				}


				public virtual bool? IsAgencyReceive
				{
					set
					{
					this.isAgencyReceive = value;
					}
					get
					{
					return this.isAgencyReceive;
					}
				}


				public virtual DateTime CreatedTime
				{
					set
					{
					this.createdTime = value;
					}
					get
					{
					return this.createdTime;
					}
				}


		}

		public class OrderGroupDetail
		{


			/// <summary>
			/// 拼团团信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("group")]//) private GroupOnGroup group;
				internal GroupOnGroup group;


			/// <summary>
			/// 参团订单信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("group_join")]//) private GroupOnGroupJoin groupJoin;
				internal GroupOnGroupJoin groupJoin;

				public virtual GroupOnGroup Group
				{
					set
					{
					this.group = value;
					}
					get
					{
					return this.group;
					}
				}


				public virtual GroupOnGroupJoin GroupJoin
				{
					set
					{
					this.groupJoin = value;
					}
					get
					{
					return this.groupJoin;
					}
				}


		}

		public class GroupOnGroup
		{


			/// <summary>
			/// 团ID，唯一标示
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 团编号，唯一
			/// </summary>
[Newtonsoft.Json.JsonProperty("group_no")]//) private String groupNo;
				internal string groupNo;


			/// <summary>
			/// 成团订单编号，即团长订单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("tid")]//) private String tid;
				internal string tid;


			/// <summary>
			/// 店铺ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("sid")]//) private Nullable<long> sid;
				internal long? sid;


			/// <summary>
			/// 商家创建的拼团活动ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("activity_id")]//) private Nullable<long> activityId;
				internal long? activityId;


			/// <summary>
			/// 拼团状态；0：进行中、1：成功、2：失败
			/// </summary>
[Newtonsoft.Json.JsonProperty("state")]//) private Nullable<long> state;
				internal long? state;


			/// <summary>
			/// 成团别名，即邀请码
			/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
				internal string alias;


			/// <summary>
			/// 已参团的人数
			/// </summary>
[Newtonsoft.Json.JsonProperty("join_num")]//) private Nullable<long> joinNum;
				internal long? joinNum;


			/// <summary>
			/// 成团开始时间戳
			/// </summary>
[Newtonsoft.Json.JsonProperty("start_time")]//) private java.util.Date startTime;
				internal DateTime startTime;


			/// <summary>
			/// 团代收状态。0：不代收；1：可选代收；2：强制代收
			/// </summary>
[Newtonsoft.Json.JsonProperty("receive_state")]//) private Nullable<long> receiveState;
				internal long? receiveState;


			/// <summary>
			/// 拼团成功剩余的人数
			/// </summary>
[Newtonsoft.Json.JsonProperty("remain_join_num")]//) private Nullable<long> remainJoinNum;
				internal long? remainJoinNum;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_time")]//) private java.util.Date createdTime;
				internal DateTime createdTime;

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


				public virtual string GroupNo
				{
					set
					{
					this.groupNo = value;
					}
					get
					{
					return this.groupNo;
					}
				}


				public virtual string Tid
				{
					set
					{
					this.tid = value;
					}
					get
					{
					return this.tid;
					}
				}


				public virtual long? Sid
				{
					set
					{
					this.sid = value;
					}
					get
					{
					return this.sid;
					}
				}


				public virtual long? ActivityId
				{
					set
					{
					this.activityId = value;
					}
					get
					{
					return this.activityId;
					}
				}


				public virtual long? State
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


				public virtual string Alias
				{
					set
					{
					this.alias = value;
					}
					get
					{
					return this.alias;
					}
				}


				public virtual long? JoinNum
				{
					set
					{
					this.joinNum = value;
					}
					get
					{
					return this.joinNum;
					}
				}


				public virtual DateTime StartTime
				{
					set
					{
					this.startTime = value;
					}
					get
					{
					return this.startTime;
					}
				}


				public virtual long? ReceiveState
				{
					set
					{
					this.receiveState = value;
					}
					get
					{
					return this.receiveState;
					}
				}


				public virtual long? RemainJoinNum
				{
					set
					{
					this.remainJoinNum = value;
					}
					get
					{
					return this.remainJoinNum;
					}
				}


				public virtual DateTime CreatedTime
				{
					set
					{
					this.createdTime = value;
					}
					get
					{
					return this.createdTime;
					}
				}


		}


	}
}