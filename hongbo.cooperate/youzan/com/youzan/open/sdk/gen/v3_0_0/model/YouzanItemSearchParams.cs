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

    public class YouzanItemSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 作为查询条件的商品ID列表，以逗号分隔，如1,2
		/// </summary>
		private string itemIds;
		/// <summary>
		/// 页
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页数量
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 搜索关键字
		/// </summary>
		private string q;
		/// <summary>
		/// 是否在售:
		/// 0: 在售
		/// 1: 售罄或部分售罄
		/// 2: 全部
		/// </summary>
		private long? showSoldOut;
		/// <summary>
		/// 作为查询的分组ID列表，以逗号分隔，如1,2
		/// </summary>
		private string tagIds;

		public virtual string ItemIds
		{
			set
			{
				this.itemIds = value;
			}
			get
			{
				return this.itemIds;
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


		public virtual long? ShowSoldOut
		{
			set
			{
				this.showSoldOut = value;
			}
			get
			{
				return this.showSoldOut;
			}
		}


		public virtual string TagIds
		{
			set
			{
				this.tagIds = value;
			}
			get
			{
				return this.tagIds;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(itemIds, null))
			{
				@params["item_ids"] = itemIds;
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
			if (showSoldOut != null)
			{
				@params["show_sold_out"] = showSoldOut;
			}
			if (!string.ReferenceEquals(tagIds, null))
			{
				@params["tag_ids"] = tagIds;
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