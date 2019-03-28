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

    public class YouzanEbizStatsReferralPagesGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 结束日期，格式：yyyy-MM-dd
		/// </summary>
		private string endDay;
		/// <summary>
		/// 关键字
		/// </summary>
		private string keyword;
		/// <summary>
		/// 页码
		/// </summary>
		private long? page;
		/// <summary>
		/// 页面大小
		/// </summary>
		private long? size;
		/// <summary>
		/// 起点
		/// </summary>
		private long? start;
		/// <summary>
		/// 起始日期，格式：yyyy-MM-dd
		/// </summary>
		private string startDay;

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


		public virtual string Keyword
		{
			set
			{
				this.keyword = value;
			}
			get
			{
				return this.keyword;
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


		public virtual long? Start
		{
			set
			{
				this.start = value;
			}
			get
			{
				return this.start;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(endDay, null))
			{
				@params["end_day"] = endDay;
			}
			if (!string.ReferenceEquals(keyword, null))
			{
				@params["keyword"] = keyword;
			}
			if (page != null)
			{
				@params["page"] = page;
			}
			if (size != null)
			{
				@params["size"] = size;
			}
			if (start != null)
			{
				@params["start"] = start;
			}
			if (!string.ReferenceEquals(startDay, null))
			{
				@params["start_day"] = startDay;
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