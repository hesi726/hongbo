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

    public class YouzanUmpCouponSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 活动类型 PROMOCARD 优惠券，PROMOCODE 优惠码
		/// </summary>
		private string groupType;
		/// <summary>
		/// 第几页
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页数量
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 活动状态 FUTURE 未开始 ,END 已结束,ON 进行中 （默认查所有状态）
		/// </summary>
		private string status;

		public virtual string GroupType
		{
			set
			{
				this.groupType = value;
			}
			get
			{
				return this.groupType;
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


		public virtual string Status
		{
			set
			{
				this.status = value;
			}
			get
			{
				return this.status;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(groupType, null))
			{
				@params["group_type"] = groupType;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(status, null))
			{
				@params["status"] = status;
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