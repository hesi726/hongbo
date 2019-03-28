namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailStockStockreturnCreateResult : APIResult
	{



		/// <summary>
		/// 退货入库单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("returnInOrder")]//) private String returnInOrder;
		private string returnInOrder;

		public virtual string ReturnInOrder
		{
			set
			{
				this.returnInOrder = value;
			}
			get
			{
				return this.returnInOrder;
			}
		}



	}
}