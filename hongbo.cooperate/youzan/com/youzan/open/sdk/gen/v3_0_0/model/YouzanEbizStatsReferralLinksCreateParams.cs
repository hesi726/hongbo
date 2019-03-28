using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    //////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    //////	using Maps = com.google.common.collect.Maps;



    //////	using Multimap = com.google.common.collect.Multimap;



    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanEbizStatsReferralLinksCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 创建渠道，普通商家请默认传"dc"
		/// </summary>
		private string origin;
		/// <summary>
		/// 监控来源名称
		/// </summary>
		private string sourceName;
		/// <summary>
		/// 商品页，微页面，或者主页的 url
		/// </summary>
		private string url;

		public virtual string Origin
		{
			set
			{
				this.origin = value;
			}
			get
			{
				return this.origin;
			}
		}


		public virtual string SourceName
		{
			set
			{
				this.sourceName = value;
			}
			get
			{
				return this.sourceName;
			}
		}


		public virtual string Url
		{
			set
			{
				this.url = value;
			}
			get
			{
				return this.url;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(origin, null))
			{
				@params["origin"] = origin;
			}
			if (!string.ReferenceEquals(sourceName, null))
			{
				@params["source_name"] = sourceName;
			}
			if (!string.ReferenceEquals(url, null))
			{
				@params["url"] = url;
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