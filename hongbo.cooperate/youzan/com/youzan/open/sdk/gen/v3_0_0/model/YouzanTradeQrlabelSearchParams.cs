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

    public class YouzanTradeQrlabelSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页数量
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 网点编号
		/// </summary>
		private string shopId;
		/// <summary>
		/// 网点类型
		/// </summary>
		private string shopType;

		public virtual long? PageNo
		{
			set
			{
				this.pageNo = value;
			}
			get
			{
				return this.pageNo;
			}
		}


		public virtual long? PageSize
		{
			set
			{
				this.pageSize = value;
			}
			get
			{
				return this.pageSize;
			}
		}


		public virtual string ShopId
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


		public virtual string ShopType
		{
			set
			{
				this.shopType = value;
			}
			get
			{
				return this.shopType;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(shopId, null))
			{
				@params["shop_id"] = shopId;
			}
			if (!string.ReferenceEquals(shopType, null))
			{
				@params["shop_type"] = shopType;
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