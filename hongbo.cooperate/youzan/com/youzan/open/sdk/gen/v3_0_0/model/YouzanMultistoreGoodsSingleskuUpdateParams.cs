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

    public class YouzanMultistoreGoodsSingleskuUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品编码
		/// </summary>
		private string code;
		/// <summary>
		/// 商品id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 网点id
		/// </summary>
		private long? offlineId;
		/// <summary>
		/// 商品价格 单位：元
		/// </summary>
		private float? price;
		/// <summary>
		/// 商品无sku的时候，这个值不填
		/// 商品有sku的时候，需要填写sku_id
		/// </summary>
		private long? skuId;
		/// <summary>
		/// 库存
		/// </summary>
		private long? stockNum;

		public virtual string Code
		{
			set
			{
				this.code = value;
			}
			get
			{
				return this.code;
			}
		}


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


		public virtual long? OfflineId
		{
			set
			{
				this.offlineId = value;
			}
			get
			{
				return this.offlineId;
			}
		}


		public virtual float? Price
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


		public virtual long? SkuId
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


		public virtual long? StockNum
		{
			set
			{
				this.stockNum = value;
			}
			get
			{
				return this.stockNum;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(code, null))
			{
				@params["code"] = code;
			}
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (offlineId != null)
			{
				@params["offline_id"] = offlineId;
			}
			if (price != null)
			{
				@params["price"] = price;
			}
			if (skuId != null)
			{
				@params["sku_id"] = skuId;
			}
			if (stockNum != null)
			{
				@params["stock_num"] = stockNum;
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