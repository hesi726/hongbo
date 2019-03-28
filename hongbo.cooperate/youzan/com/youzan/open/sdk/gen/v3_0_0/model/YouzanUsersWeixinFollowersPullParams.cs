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

    public class YouzanUsersWeixinFollowersPullParams : APIParams, FileParams
	{

		/// <summary>
		/// 用于拉取该粉丝编码之后的查询条件。第一次查询可传入0，之后每次查询可传入上次查询里返回的last_fans_id，直到返回结果里的has_next为false
		/// </summary>
		private long? afterFansId;
		/// <summary>
		/// 需要返回的微信粉丝对象字段，如nick,avatar等。可选值：CrmWeixinFans微信粉丝结构体中所有字段均可返回；多个字段用","分隔。如果为空则返回所有
		/// </summary>
		private string fields;
		/// <summary>
		/// 每页条数，最大值：50
		/// </summary>
		private long? pageSize;

		public virtual long? AfterFansId
		{
			set
			{
				this.afterFansId = value;
			}
			get
			{
				return this.afterFansId;
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
			if (afterFansId != null)
			{
				@params["after_fans_id"] = afterFansId;
			}
			if (!string.ReferenceEquals(fields, null))
			{
				@params["fields"] = fields;
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