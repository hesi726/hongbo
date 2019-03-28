namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailStockStockinCreateResult : APIResult
	{



		/// <summary>
		/// 入库单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("business_order_no")]//) private String businessOrderNo;
		private string businessOrderNo;

		public virtual string BusinessOrderNo
		{
			set
			{
				this.businessOrderNo = value;
			}
			get
			{
				return this.businessOrderNo;
			}
		}



	}
}