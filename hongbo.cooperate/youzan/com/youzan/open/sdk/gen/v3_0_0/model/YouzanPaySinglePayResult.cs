namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanPaySinglePayResult : APIResult
	{



		/// <summary>
		/// 收单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("acquire_no")]//) private String acquireNo;
		private string acquireNo;


		/// <summary>
		/// 外部订单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("out_biz_no")]//) private String outBizNo;
		private string outBizNo;


		/// <summary>
		/// 支付单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("asset_detail_no")]//) private String assetDetailNo;
		private string assetDetailNo;


		/// <summary>
		/// 三方渠道流水号
		/// </summary>
[Newtonsoft.Json.JsonProperty("channel_settle_no")]//) private String channelSettleNo;
		private string channelSettleNo;


		/// <summary>
		/// 唤起三方支付收银台的信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("deep_link_info")]//) private String deepLinkInfo;
		private string deepLinkInfo;


		/// <summary>
		/// 支付完成时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("payment_dt")]//) private String paymentDt;
		private string paymentDt;


		/// <summary>
		/// 实际支付金额，单位分
		/// </summary>
[Newtonsoft.Json.JsonProperty("pay_amount")]//) private Nullable<long> payAmount;
		private long? payAmount;


		/// <summary>
		/// 支付结果状态
		/// CREATE:已经创建
		/// PAYING:支付中
		/// BUYER_PAIED:买家已经支付
		/// PAID_TO_SELLER:已经打款
		/// SUCCESS:成功
		/// FAIL:失败
		/// CANCEL:取消
		/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private String status;
		private string status;

		public virtual string AcquireNo
		{
			set
			{
				this.acquireNo = value;
			}
			get
			{
				return this.acquireNo;
			}
		}

		public virtual string OutBizNo
		{
			set
			{
				this.outBizNo = value;
			}
			get
			{
				return this.outBizNo;
			}
		}

		public virtual string AssetDetailNo
		{
			set
			{
				this.assetDetailNo = value;
			}
			get
			{
				return this.assetDetailNo;
			}
		}

		public virtual string ChannelSettleNo
		{
			set
			{
				this.channelSettleNo = value;
			}
			get
			{
				return this.channelSettleNo;
			}
		}

		public virtual string DeepLinkInfo
		{
			set
			{
				this.deepLinkInfo = value;
			}
			get
			{
				return this.deepLinkInfo;
			}
		}

		public virtual string PaymentDt
		{
			set
			{
				this.paymentDt = value;
			}
			get
			{
				return this.paymentDt;
			}
		}

		public virtual long? PayAmount
		{
			set
			{
				this.payAmount = value;
			}
			get
			{
				return this.payAmount;
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



	}
}