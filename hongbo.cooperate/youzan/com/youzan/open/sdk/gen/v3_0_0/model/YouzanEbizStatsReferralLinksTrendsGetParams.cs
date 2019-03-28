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

    public class YouzanEbizStatsReferralLinksTrendsGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 结束日期，格式：yyyy-MM-dd
		/// </summary>
		private string endDay;
		/// <summary>
		/// 监控页面 id
		/// </summary>
		private long? pageId;
		/// <summary>
		/// 起始日期，格式：yyyy-MM-dd
		/// </summary>
		private string startDay;
		/// <summary>
		/// 跟踪链接 id
		/// </summary>
		private long? trackLinkId;

		public virtual string EndDay
		{
			set
			{
				this.endDay = value;
			}
			get
			{
				return this.endDay;
			}
		}


		public virtual long? PageId
		{
			set
			{
				this.pageId = value;
			}
			get
			{
				return this.pageId;
			}
		}


		public virtual string StartDay
		{
			set
			{
				this.startDay = value;
			}
			get
			{
				return this.startDay;
			}
		}


		public virtual long? TrackLinkId
		{
			set
			{
				this.trackLinkId = value;
			}
			get
			{
				return this.trackLinkId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(endDay, null))
			{
				@params["end_day"] = endDay;
			}
			if (pageId != null)
			{
				@params["page_id"] = pageId;
			}
			if (!string.ReferenceEquals(startDay, null))
			{
				@params["start_day"] = startDay;
			}
			if (trackLinkId != null)
			{
				@params["track_link_id"] = trackLinkId;
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