using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeRefundGetResult : APIResult
	{



		/// <summary>
		/// 订单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("tid")]//) private String tid;
		private string tid;


		/// <summary>
		/// 订单商品id
		/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
		private long? itemId;


		/// <summary>
		/// 退款id
		/// </summary>
[Newtonsoft.Json.JsonProperty("refund_id")]//) private String refundId;
		private string refundId;


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
		private string status;


		/// <summary>
		/// 客满介入状态：
		/// 1（客满未介入），2（客满介入中）。
		/// </summary>
[Newtonsoft.Json.JsonProperty("cs_status")]//) private Nullable<long> csStatus;
		private long? csStatus;


		/// <summary>
		/// 是否退货:
		/// false（仅退款），true（退货退款）。
		/// </summary>
[Newtonsoft.Json.JsonProperty("return_goods")]//) private Nullable<bool> returnGoods;
		private bool? returnGoods;


		/// <summary>
		/// 退款申请说明
		/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
		private string desc;


		/// <summary>
		/// 退款申请时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
		private DateTime created;


		/// <summary>
		/// 退款申请修改时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("modified")]//) private java.util.Date modified;
		private DateTime modified;


		/// <summary>
		/// 退款版本号，用于退款的相关操作。
		/// </summary>
[Newtonsoft.Json.JsonProperty("version")]//) private Nullable<long> version;
		private long? version;


		/// <summary>
		/// 仅退款-未收到货申请原因:11(质量问题), 12(拍错/多拍/不喜欢), 13(商品描述不符), 14(假货), 15(商家发错货), 16(商品破损/少件), 17(其他);
		/// 仅退款-已收到货申请原因:51(多买/买错/不想要), 52(快递无记录), 53(少货/空包裹), 54(未按约定时间发货), 55(快递一直未送达), 56(其他);
		/// 退货退款-申请原因:101(商品破损/少件), 102(商家发错货), 103(商品描述不符), 104(拍错/多拍/不喜欢), 105(质量问题), 107(其他);
		/// </summary>
[Newtonsoft.Json.JsonProperty("reason")]//) private Nullable<long> reason;
		private long? reason;


		/// <summary>
		/// 申请退款的金额
		/// </summary>
[Newtonsoft.Json.JsonProperty("refund_fee")]//) private Nullable<float> refundFee;
		private float? refundFee;


		/// <summary>
		/// 退货物流信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("logistics")]//) private TradeRefundLogistics logistics;
		private TradeRefundLogistics logistics;


		/// <summary>
		/// 退款类型：
		/// BUYER_APPLY_REFUND(买家申请退款)，SELLER_REFUND（商家主动退款），SYSTEM_REFUND（一键退款，特殊类型退款）
		/// </summary>
[Newtonsoft.Json.JsonProperty("refund_type")]//) private String refundType;
		private string refundType;


		/// <summary>
		/// 订单明细id
		/// </summary>
[Newtonsoft.Json.JsonProperty("oid")]//) private String oid;
		private string oid;

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

		public virtual string Desc
		{
			set
			{
				this.desc = value;
			}
			get
			{
				return this.desc;
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

		public virtual long? Version
		{
			set
			{
				this.version = value;
			}
			get
			{
				return this.version;
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

		public virtual TradeRefundLogistics Logistics
		{
			set
			{
				this.logistics = value;
			}
			get
			{
				return this.logistics;
			}
		}

		public virtual string RefundType
		{
			set
			{
				this.refundType = value;
			}
			get
			{
				return this.refundType;
			}
		}

		public virtual string Oid
		{
			set
			{
				this.oid = value;
			}
			get
			{
				return this.oid;
			}
		}


		public class TradeRefundLogistics
		{


			/// <summary>
			/// 物流单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("logistics_no")]//) private String logisticsNo;
				internal string logisticsNo;


			/// <summary>
			/// 物流公司编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("company_code")]//) private String companyCode;
				internal string companyCode;


			/// <summary>
			/// 收件人
			/// </summary>
[Newtonsoft.Json.JsonProperty("receiver")]//) private String receiver;
				internal string receiver;


			/// <summary>
			/// 收件人手机号
			/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
				internal string mobile;


			/// <summary>
			/// 收件人座机
			/// </summary>
[Newtonsoft.Json.JsonProperty("telephone")]//) private String telephone;
				internal string telephone;


			/// <summary>
			/// 收货地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("address")]//) private String address;
				internal string address;

				public virtual string LogisticsNo
				{
					set
					{
					this.logisticsNo = value;
					}
					get
					{
					return this.logisticsNo;
					}
				}


				public virtual string CompanyCode
				{
					set
					{
					this.companyCode = value;
					}
					get
					{
					return this.companyCode;
					}
				}


				public virtual string Receiver
				{
					set
					{
					this.receiver = value;
					}
					get
					{
					return this.receiver;
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


				public virtual string Telephone
				{
					set
					{
					this.telephone = value;
					}
					get
					{
					return this.telephone;
					}
				}


				public virtual string Address
				{
					set
					{
					this.address = value;
					}
					get
					{
					return this.address;
					}
				}


		}


	}
}