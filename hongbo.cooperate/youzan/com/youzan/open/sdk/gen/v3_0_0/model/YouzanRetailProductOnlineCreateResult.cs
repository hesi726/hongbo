namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductOnlineCreateResult : APIResult
	{



		/// <summary>
		/// 商品id
		/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
		private long? itemId;


		/// <summary>
		/// 商品别名
		/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
		private string alias;


		/// <summary>
		/// 商品规格id
		/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private string[] skuId;
		private string[] skuId;

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

		public virtual string[] SkuId
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



	}
}