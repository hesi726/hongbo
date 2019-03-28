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

    public class YouzanEbizStatsReferralOrdersSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 结束日期，格式：yyyy-MM-dd，例如：2017-08-25
		/// </summary>
		private string endDay;
		/// <summary>
		/// 页码，例如：1
		/// </summary>
		private long? page;
		/// <summary>
		/// 每页数据条数，例如：10
		/// </summary>
		private long? size;
		/// <summary>
		/// 起始日期，格式：yyyy-MM-dd，例如：2017-06-25
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


		public virtual long? Page
		{
			set
			{
				this.page = value;
			}
			get
			{
				return this.page;
			}
		}


		public virtual long? Size
		{
			set
			{
				this.size = value;
			}
			get
			{
				return this.size;
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
			if (page != null)
			{
				@params["page"] = page;
			}
			if (size != null)
			{
				@params["size"] = size;
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