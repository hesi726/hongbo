using System;
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

    public class YouzanUsersWeixinFollowersInfoSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 关注的结束时间。查询在该时间之前关注的粉丝，不能为空，查询时间间隔不能超过一天，格式同start_follow
		/// </summary>
		private DateTime endFollow;
		/// <summary>
		/// 需要返回的除微信粉丝基础信息外的资产信息。枚举值：points，trade，level。points可获取"points"字段，trade可获取"traded_num,trade_money"两个字段，level可获取"level_info"字段信息。传多个枚举值需用","分隔，如果该字段为空则只返回粉丝基础信息。默认为空。("fields"字段传入枚举值越多，查询数据耗费时间越长。）
		/// </summary>
		private string fields;
		/// <summary>
		/// 是否仅拉取关注的粉丝。1:仅拉取已关注的粉丝 0:拉取已关注和已跑路粉丝
		/// </summary>
		private long? onlyFollow;
		/// <summary>
		/// 页码，page_no * page_size参数不超过10000。若备选数据多于10000条，请通过调整start_follow/end_follow来缩小时间范围。
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数，最大值：50。默认为10。
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 关注的起始时间。查询在该时间之后（包含该时间）关注的粉丝，不能为空。格式可为"20170101"或"2017-01-01 12:00:00"
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


		public virtual long? OnlyFollow
		{
			set
			{
				this.onlyFollow = value;
			}
			get
			{
				return this.onlyFollow;
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
			if (onlyFollow != null)
			{
				@params["only_follow"] = onlyFollow;
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