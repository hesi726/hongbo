using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_1_0.model
{

    //	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    //	using Maps = com.google.common.collect.Maps;

    //	using Multimap = com.google.common.collect.Multimap;

    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanScrmCustomerSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 成为客户的时间，截止值，时间戳格式，单位是秒
		/// </summary>
		private long? createdAtEnd;
		/// <summary>
		/// 成为客户的时间，起始值，时间戳格式，单位是秒
		/// </summary>
		private long? createdAtStart;
		/// <summary>
		/// 是否为会员，0表示非会员，1表示会员
		/// </summary>
		private long? isMember;
		/// <summary>
		/// 页码，最多支持500页(500页是以每页默认值20为单位，客户查询最大为10000)
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页数量，最多支持50个
		/// </summary>
		private long? pageSize;

		public virtual long? CreatedAtEnd
		{
			set
			{
				this.createdAtEnd = value;
			}
			get
			{
				return this.createdAtEnd;
			}
		}


		public virtual long? CreatedAtStart
		{
			set
			{
				this.createdAtStart = value;
			}
			get
			{
				return this.createdAtStart;
			}
		}


		public virtual long? IsMember
		{
			set
			{
				this.isMember = value;
			}
			get
			{
				return this.isMember;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (createdAtEnd != null)
			{
				@params["created_at_end"] = createdAtEnd;
			}
			if (createdAtStart != null)
			{
				@params["created_at_start"] = createdAtStart;
			}
			if (isMember != null)
			{
				@params["is_member"] = isMember;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
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