namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductOfflineCreateResult : APIResult
	{



		/// <summary>
		/// 门店商品id
		/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
		private long? itemId;


		/// <summary>
		/// 门店规格id列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("sku_ids")]//) private string[] skuIds;
		private string[] skuIds;

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

		public virtual string[] SkuIds
		{
			set
			{
				this.skuIds = value;
			}
			get
			{
				return this.skuIds;
			}
		}



	}
}