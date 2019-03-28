namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMultistoreGoodsDeliveryGetResult : APIResult
	{



		/// <summary>
		/// 是否支持快递
		/// </summary>
[Newtonsoft.Json.JsonProperty("express")]//) private Nullable<long> express;
		private long? express;


		/// <summary>
		/// 是否支持同城配送
		/// </summary>
[Newtonsoft.Json.JsonProperty("local_delivery")]//) private Nullable<long> localDelivery;
		private long? localDelivery;


		/// <summary>
		/// 是否支持到店自提
		/// </summary>
[Newtonsoft.Json.JsonProperty("self_fetch")]//) private Nullable<long> selfFetch;
		private long? selfFetch;

		public virtual long? Express
		{
			set
			{
				this.express = value;
			}
			get
			{
				return this.express;
			}
		}

		public virtual long? LocalDelivery
		{
			set
			{
				this.localDelivery = value;
			}
			get
			{
				return this.localDelivery;
			}
		}

		public virtual long? SelfFetch
		{
			set
			{
				this.selfFetch = value;
			}
			get
			{
				return this.selfFetch;
			}
		}



	}
}