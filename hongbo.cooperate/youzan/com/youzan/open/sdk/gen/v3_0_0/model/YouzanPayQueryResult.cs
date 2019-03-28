namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanPayQueryResult : APIResult
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


		/// <summary>
		/// 支付金额
		/// </summary>
[Newtonsoft.Json.JsonProperty("pay_amount")]//) private Nullable<long> payAmount;
		private long? payAmount;


		/// <summary>
		/// 币种
		/// </summary>
[Newtonsoft.Json.JsonProperty("currency_code")]//) private String currencyCode;
		private string currencyCode;

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

		public virtual string CurrencyCode
		{
			set
			{
				this.currencyCode = value;
			}
			get
			{
				return this.currencyCode;
			}
		}



	}
}