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

    public class YouzanMultistoreGoodsSkuUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品id
		/// </summary>
		private long? numIid;
		/// <summary>
		/// 网点id
		/// </summary>
		private long? offlineId;
		/// <summary>
		/// 商品货号（商家为商品设置的外部编号）
		/// </summary>
		private string outerId;
		/// <summary>
		/// 商品价格
		/// </summary>
		private float? price;
		/// <summary>
		/// 商品总库存。当商品没有SKU的时候有效，当商品有SKU时，总库存会自动按所有SKU库存之和计算
		/// </summary>
		private string quantity;
		/// <summary>
		/// 商品Sku信息的Json字符串，示例 [{"sku_property":{"颜色":"白色","尺寸":"M"},"sku_price":1.0,"sku_quantity":16,"sku_outer_id":"1702210201","sku_id":36149753},{"sku_property":{"颜色":"白色","尺寸":"S"},"sku_price":1.0,"sku_quantity":18,"sku_outer_id":"1702210202","sku_id":36149754}] 其中sku_property是k:v;k:v组合；
		/// sku_quantity是sku库存数量；
		/// sku_price是sku价格；
		/// sku_outer_id是sku商家编码；
		/// sku_id是sku的id; 网点商品含sku时，比需要传入。
		/// </summary>
		private string skusWithJson;

		public virtual long? NumIid
		{
			set
			{
				this.numIid = value;
			}
			get
			{
				return this.numIid;
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


		public virtual string OuterId
		{
			set
			{
				this.outerId = value;
			}
			get
			{
				return this.outerId;
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


		public virtual string Quantity
		{
			set
			{
				this.quantity = value;
			}
			get
			{
				return this.quantity;
			}
		}


		public virtual string SkusWithJson
		{
			set
			{
				this.skusWithJson = value;
			}
			get
			{
				return this.skusWithJson;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (numIid != null)
			{
				@params["num_iid"] = numIid;
			}
			if (offlineId != null)
			{
				@params["offline_id"] = offlineId;
			}
			if (!string.ReferenceEquals(outerId, null))
			{
				@params["outer_id"] = outerId;
			}
			if (price != null)
			{
				@params["price"] = price;
			}
			if (!string.ReferenceEquals(quantity, null))
			{
				@params["quantity"] = quantity;
			}
			if (!string.ReferenceEquals(skusWithJson, null))
			{
				@params["skus_with_json"] = skusWithJson;
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