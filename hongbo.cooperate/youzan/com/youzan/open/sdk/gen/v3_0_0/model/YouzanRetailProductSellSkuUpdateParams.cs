using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanRetailProductSellSkuUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 网店商品id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 网店商品规格id
		/// </summary>
		private long? itemSkuId;
		/// <summary>
		/// 规格价格，单位：分
		/// （价格最小0.01元，最大值9999999元）
		/// </summary>
		private long? price;
		/// <summary>
		/// 请求来源（用于标识请求来源）
		/// </summary>
		private string retailSource;

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


		public virtual long? ItemSkuId
		{
			set
			{
				this.itemSkuId = value;
			}
			get
			{
				return this.itemSkuId;
			}
		}


		public virtual long? Price
		{
			set
			{
				this.price = value;
			}
			get
			{
				return this.price;
			}
		}


		public virtual string RetailSource
		{
			set
			{
				this.retailSource = value;
			}
			get
			{
				return this.retailSource;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (itemSkuId != null)
			{
				@params["item_sku_id"] = itemSkuId;
			}
			if (price != null)
			{
				@params["price"] = price;
			}
			if (!string.ReferenceEquals(retailSource, null))
			{
				@params["retail_source"] = retailSource;
			}
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}