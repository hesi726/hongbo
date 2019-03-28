namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMultistoreGoodsDeliveryListResult : APIResult
	{



		/// <summary>
		/// 网点下所有商品的配送方式
		/// </summary>
[Newtonsoft.Json.JsonProperty("list")]//) private MultistoreDeliverySetting[] list;
		private MultistoreDeliverySetting[] list;

		public virtual MultistoreDeliverySetting[] List
		{
			set
			{
				this.list = value;
			}
			get
			{
				return this.list;
			}
		}


		public class MultistoreDeliverySetting
		{


			/// <summary>
			/// 是否支持自提：1支持；0不支持
			/// </summary>
[Newtonsoft.Json.JsonProperty("self_fetch")]//) private Nullable<long> selfFetch;
				internal long? selfFetch;


			/// <summary>
			/// 是否支持快递：1支持；0不支持
			/// </summary>
[Newtonsoft.Json.JsonProperty("express")]//) private Nullable<long> express;
				internal long? express;


			/// <summary>
			/// 网点id
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_id")]//) private Nullable<long> shopId;
				internal long? shopId;


			/// <summary>
			/// 是否支持同城送：1支持；0不支持
			/// </summary>
[Newtonsoft.Json.JsonProperty("local_delivery")]//) private Nullable<long> localDelivery;
				internal long? localDelivery;


			/// <summary>
			/// 商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_id")]//) private Nullable<long> goodsId;
				internal long? goodsId;

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


				public virtual long? ShopId
				{
					set
					{
					this.shopId = value;
					}
					get
					{
					return this.shopId;
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


				public virtual long? GoodsId
				{
					set
					{
					this.goodsId = value;
					}
					get
					{
					return this.goodsId;
					}
				}


		}


	}
}