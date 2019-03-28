using System;
using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v1_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class KdtUsersWeixinFollowersGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 关注的结束时间。查询在该时间之前关注的粉丝，不能为空，查询时间间隔不能超过一天
		/// </summary>
		private DateTime endFollow;
		/// <summary>
		/// 需要返回的微信粉丝对象字段，如nick,avatar等。可选值：CrmWeixinFans微信粉丝结构体中所有字段均可返回；多个字段用","分隔。如果为空则返回所有
		/// </summary>
		private string fields;
		/// <summary>
		/// 页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数，最大值：5000
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 关注的起始时间。查询在该时间之后（包含该时间）关注的粉丝，不能为空
		/// </summary>
		private DateTime startFollow;

		public virtual DateTime EndFollow
		{
			set
			{
				this.endFollow = value;
			}
			get
			{
				return this.endFollow;
			}
		}


		public virtual string Fields
		{
			set
			{
				this.fields = value;
			}
			get
			{
				return this.fields;
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


		public virtual DateTime StartFollow
		{
			set
			{
				this.startFollow = value;
			}
			get
			{
				return this.startFollow;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (endFollow != null)
			{
				@params["end_follow"] = endFollow;
			}
			if (!string.ReferenceEquals(fields, null))
			{
				@params["fields"] = fields;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (startFollow != null)
			{
				@params["start_follow"] = startFollow;
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