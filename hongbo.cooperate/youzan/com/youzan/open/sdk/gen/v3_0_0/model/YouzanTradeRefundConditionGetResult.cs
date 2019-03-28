namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeRefundConditionGetResult : APIResult
	{



		/// <summary>
		/// 是否只能申请全额退款，是为true，否为false
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_full_refund")]//) private Nullable<bool> isFullRefund;
		private bool? isFullRefund;


		/// <summary>
		/// 是否可以申请退货退款，是为true，否为false
		/// </summary>
[Newtonsoft.Json.JsonProperty("has_retrun_goods")]//) private Nullable<bool> hasRetrunGoods;
		private bool? hasRetrunGoods;


		/// <summary>
		/// 最大可退金额
		/// </summary>
[Newtonsoft.Json.JsonProperty("refund_fee")]//) private Nullable<float> refundFee;
		private float? refundFee;

		public virtual bool? IsFullRefund
		{
			set
			{
				this.isFullRefund = value;
			}
			get
			{
				return this.isFullRefund;
			}
		}

		public virtual bool? HasRetrunGoods
		{
			set
			{
				this.hasRetrunGoods = value;
			}
			get
			{
				return this.hasRetrunGoods;
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



	}
}