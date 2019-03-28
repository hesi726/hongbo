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

    public class YouzanItemReviewsCountParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 供货商店铺id
		/// </summary>
		private long? supplierKdtId;

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


		public virtual long? SupplierKdtId
		{
			set
			{
				this.supplierKdtId = value;
			}
			get
			{
				return this.supplierKdtId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (supplierKdtId != null)
			{
				@params["supplier_kdt_id"] = supplierKdtId;
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