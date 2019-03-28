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

    public class YouzanItemSkuUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品数字编号
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 商家编码（商家为sku设置外部编号）
		/// </summary>
		private string itemNo;
		/// <summary>
		/// sku销售价格，精确到小数点2位；单位:元
		/// </summary>
		private float? price;
		/// <summary>
		/// sku库存数量
		/// </summary>
		private string quantity;
		/// <summary>
		/// sku id
		/// </summary>
		private long? skuId;

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


		public virtual string ItemNo
		{
			set
			{
				this.itemNo = value;
			}
			get
			{
				return this.itemNo;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (!string.ReferenceEquals(itemNo, null))
			{
				@params["item_no"] = itemNo;
			}
			if (price != null)
			{
				@params["price"] = price;
			}
			if (!string.ReferenceEquals(quantity, null))
			{
				@params["quantity"] = quantity;
			}
			if (skuId != null)
			{
				@params["sku_id"] = skuId;
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