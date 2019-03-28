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

    public class YouzanTradeCartListParams : APIParams, FileParams
	{

		/// <summary>
		/// 店铺id
		/// </summary>
		private long? kdtId;
		/// <summary>
		/// 会话key,如果没有该值填
		/// </summary>
		private string nobody;
		/// <summary>
		/// 门店id,多门店时才会涉及到，不是多门店的情况填0
		/// </summary>
		private long? storeId;

		public virtual long? KdtId
		{
			set
			{
				this.kdtId = value;
			}
			get
			{
				return this.kdtId;
			}
		}


		public virtual string Nobody
		{
			set
			{
				this.nobody = value;
			}
			get
			{
				return this.nobody;
			}
		}


		public virtual long? StoreId
		{
			set
			{
				this.storeId = value;
			}
			get
			{
				return this.storeId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (kdtId != null)
			{
				@params["kdt_id"] = kdtId;
			}
			if (!string.ReferenceEquals(nobody, null))
			{
				@params["nobody"] = nobody;
			}
			if (storeId != null)
			{
				@params["store_id"] = storeId;
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