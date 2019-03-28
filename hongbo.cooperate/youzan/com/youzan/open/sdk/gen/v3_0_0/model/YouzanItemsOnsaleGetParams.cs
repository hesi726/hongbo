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

    public class YouzanItemsOnsaleGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 排序方式。格式为column:asc/desc，目前排序字段：1.创建时间：created_time，2.更新时间：update_time，3.价格：price，4.销量：sold_num
		/// </summary>
		private string orderBy;
		/// <summary>
		/// 页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数，最大300个
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 搜索字段。搜索商品的title
		/// </summary>
		private string q;
		/// <summary>
		/// 商品标签的ID
		/// </summary>
		private long? tagId;
		/// <summary>
		/// 商品终止更新时间，单位为ms
		/// </summary>
		private long? updateTimeEnd;
		/// <summary>
		/// 商品初始更新时间，单位为ms
		/// </summary>
		private long? updateTimeStart;

		public virtual string OrderBy
		{
			set
			{
				this.orderBy = value;
			}
			get
			{
				return this.orderBy;
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


		public virtual string Q
		{
			set
			{
				this.q = value;
			}
			get
			{
				return this.q;
			}
		}


		public virtual long? TagId
		{
			set
			{
				this.tagId = value;
			}
			get
			{
				return this.tagId;
			}
		}


		public virtual long? UpdateTimeEnd
		{
			set
			{
				this.updateTimeEnd = value;
			}
			get
			{
				return this.updateTimeEnd;
			}
		}


		public virtual long? UpdateTimeStart
		{
			set
			{
				this.updateTimeStart = value;
			}
			get
			{
				return this.updateTimeStart;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(orderBy, null))
			{
				@params["order_by"] = orderBy;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(q, null))
			{
				@params["q"] = q;
			}
			if (tagId != null)
			{
				@params["tag_id"] = tagId;
			}
			if (updateTimeEnd != null)
			{
				@params["update_time_end"] = updateTimeEnd;
			}
			if (updateTimeStart != null)
			{
				@params["update_time_start"] = updateTimeStart;
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