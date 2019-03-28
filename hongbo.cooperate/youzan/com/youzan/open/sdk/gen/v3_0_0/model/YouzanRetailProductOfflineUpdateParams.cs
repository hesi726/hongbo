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

    public class YouzanRetailProductOfflineUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 是否上架（1上架，0下架）
		/// </summary>
		private long? display;
		/// <summary>
		/// 门店商品id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 计量方式（0表示非称重，10表示称重）
		/// </summary>
		private long? measurement;
		/// <summary>
		/// 门店商品名称
		/// </summary>
		private string name;
		/// <summary>
		/// 图片地址（例如：[{"url":"upload_files/2016/05/16/FjvGju7UwGfol_yAXK3RzxOGelt0.png","id":"642430978","width":"300","height":"299"},{"url":"upload_files/2016/05/20/FgNkCcgqoGd_fMDPPCas1UIX3aCM.jpg","id":"644360875","width":"640","height"）
		/// </summary>
		private string photoUrl;
		/// <summary>
		/// 上一次关联的商品库商品id
		/// </summary>
		private long? preRelateSkuId;
		/// <summary>
		/// 本次关联的商品库商品id
		/// </summary>
		private long? relateSkuId;
		/// <summary>
		/// 零售价（最小为1分，最大为999999900分。单位：分）
		/// </summary>
		private long? retailPrice;
		/// <summary>
		/// 销售库存
		/// </summary>
		private long? sellStockNum;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;

		public virtual long? Display
		{
			set
			{
				this.display = value;
			}
			get
			{
				return this.display;
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


		public virtual long? Measurement
		{
			set
			{
				this.measurement = value;
			}
			get
			{
				return this.measurement;
			}
		}


		public virtual string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name;
			}
		}


		public virtual string PhotoUrl
		{
			set
			{
				this.photoUrl = value;
			}
			get
			{
				return this.photoUrl;
			}
		}


		public virtual long? PreRelateSkuId
		{
			set
			{
				this.preRelateSkuId = value;
			}
			get
			{
				return this.preRelateSkuId;
			}
		}


		public virtual long? RelateSkuId
		{
			set
			{
				this.relateSkuId = value;
			}
			get
			{
				return this.relateSkuId;
			}
		}


		public virtual long? RetailPrice
		{
			set
			{
				this.retailPrice = value;
			}
			get
			{
				return this.retailPrice;
			}
		}


		public virtual long? SellStockNum
		{
			set
			{
				this.sellStockNum = value;
			}
			get
			{
				return this.sellStockNum;
			}
		}


		public virtual string Source
		{
			set
			{
				this.source = value;
			}
			get
			{
				return this.source;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (display != null)
			{
				@params["display"] = display;
			}
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (measurement != null)
			{
				@params["measurement"] = measurement;
			}
			if (!string.ReferenceEquals(name, null))
			{
				@params["name"] = name;
			}
			if (!string.ReferenceEquals(photoUrl, null))
			{
				@params["photo_url"] = photoUrl;
			}
			if (preRelateSkuId != null)
			{
				@params["pre_relate_sku_id"] = preRelateSkuId;
			}
			if (relateSkuId != null)
			{
				@params["relate_sku_id"] = relateSkuId;
			}
			if (retailPrice != null)
			{
				@params["retail_price"] = retailPrice;
			}
			if (sellStockNum != null)
			{
				@params["sell_stock_num"] = sellStockNum;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
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