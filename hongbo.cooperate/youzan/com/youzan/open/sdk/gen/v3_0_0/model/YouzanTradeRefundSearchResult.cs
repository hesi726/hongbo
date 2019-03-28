using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeRefundSearchResult : APIResult
	{



		/// <summary>
		/// 总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<long> total;
		private long? total;


		/// <summary>
		/// 退款列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("refunds")]//) private OpenSafeEsDTO[] refunds;
		private OpenSafeEsDTO[] refunds;

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

		public virtual OpenSafeEsDTO[] Refunds
		{
			set
			{
				this.refunds = value;
			}
			get
			{
				return this.refunds;
			}
		}


		public class OpenSafeEsDTO
		{


			/// <summary>
			/// 退款ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("refund_id")]//) private String refundId;
				internal string refundId;


			/// <summary>
			/// 退款状态:
			/// WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意)，
			/// WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货)，
			/// WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货)，
			/// SELLER_REFUSE_BUYER(卖家拒绝退款)，
			/// CLOSED(退款关闭)，
			/// SUCCESS(退款成功)。
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private String status;
				internal string status;


			/// <summary>
			/// 订单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("tid")]//) private String tid;
				internal string tid;


			/// <summary>
			/// 是否退货:
			/// false（仅退款），true（退货退款）。
			/// </summary>
[Newtonsoft.Json.JsonProperty("return_goods")]//) private Nullable<bool> returnGoods;
				internal bool? returnGoods;


			/// <summary>
			/// 退款原因，
			/// 仅退款-未收到货申请原因:11(质量问题), 12(拍错/多拍/不喜欢), 13(商品描述不符), 14(假货), 15(商家发错货), 16(商品破损/少件), 17(其他); 仅退款-已收到货申请原因:51(多买/买错/不想要), 52(快递无记录), 53(少货/空包裹), 54(未按约定时间发货), 55(快递一直未送达), 56(其他); 退货退款-申请原因:101(商品破损/少件), 102(商家发错货), 103(商品描述不符), 104(拍错/多拍/不喜欢), 105(质量问题), 107(其他);
			/// </summary>
[Newtonsoft.Json.JsonProperty("reason")]//) private Nullable<long> reason;
				internal long? reason;


			/// <summary>
			/// 申请退款的金额 如:0.01元
			/// </summary>
[Newtonsoft.Json.JsonProperty("refund_fee")]//) private Nullable<float> refundFee;
				internal float? refundFee;


			/// <summary>
			/// 退款申请时间 如 2017-01-01 00:00:01
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
				internal DateTime created;


			/// <summary>
			/// 退款申请修改时间 如 2017-01-01 00:00:01
			/// </summary>
[Newtonsoft.Json.JsonProperty("modified")]//) private java.util.Date modified;
				internal DateTime modified;


			/// <summary>
			/// 客满介入状态：
			/// 1（客满未介入），2（客满介入中）。
			/// </summary>
[Newtonsoft.Json.JsonProperty("cs_status")]//) private Nullable<long> csStatus;
				internal long? csStatus;

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


				public virtual string Status
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


				public virtual bool? ReturnGoods
				{
					set
					{
					this.returnGoods = value;
					}
					get
					{
					return this.returnGoods;
					}
				}


				public virtual long? Reason
				{
					set
					{
					this.reason = value;
					}
					get
					{
					return this.reason;
					}
				}


				public virtual float? RefundFee
				{
					set
					{
					this.refundFee = value;
					}
					get
					{
					return this.refundFee;
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


				public virtual DateTime Modified
				{
					set
					{
					this.modified = value;
					}
					get
					{
					return this.modified;
					}
				}


				public virtual long? CsStatus
				{
					set
					{
					this.csStatus = value;
					}
					get
					{
					return this.csStatus;
					}
				}


		}


	}
}