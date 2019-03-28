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

    public class YouzanItemQuantityUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品数字编号
		/// </summary>
		private long? itemId;
		/// <summary>
		/// sku库存数量
		/// </summary>
		private long? quantity;
		/// <summary>
		/// sku id
		/// </summary>
		private long? skuId;
		/// <summary>
		/// 库存更新方式：0为全量更新，1为增量更新(默认为0)
		/// </summary>
		private long? type;

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


		public virtual long? Quantity
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


		public virtual long? Type
		{
			set
			{
				this.type = value;
			}
			get
			{
				return this.type;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (quantity != null)
			{
				@params["quantity"] = quantity;
			}
			if (skuId != null)
			{
				@params["sku_id"] = skuId;
			}
			if (type != null)
			{
				@params["type"] = type;
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