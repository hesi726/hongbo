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

    public class YouzanMultistoreOfflineSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 搜索字段。搜索网点名称
		/// </summary>
		private string keyword;
		/// <summary>
		/// 当前页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 网点类型，self_fetch或store
		/// </summary>
		private string type;

		public virtual string Keyword
		{
			set
			{
				this.keyword = value;
			}
			get
			{
				return this.keyword;
			}
		}


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


		public virtual string Type
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
			if (!string.ReferenceEquals(keyword, null))
			{
				@params["keyword"] = keyword;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(type, null))
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