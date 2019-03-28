namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanEbizStatsReferralLinksCreateResult : APIResult
	{



		/// <summary>
		/// 页面名称
		/// </summary>
[Newtonsoft.Json.JsonProperty("page_name")]//) private String pageName;
		private string pageName;


		/// <summary>
		/// 长地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("long_url")]//) private String longUrl;
		private string longUrl;


		/// <summary>
		/// 跟踪链接 id
		/// </summary>
[Newtonsoft.Json.JsonProperty("track_link_id")]//) private Nullable<long> trackLinkId;
		private long? trackLinkId;


		/// <summary>
		/// 来源名称
		/// </summary>
[Newtonsoft.Json.JsonProperty("source_name")]//) private String sourceName;
		private string sourceName;


		/// <summary>
		/// 短链地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("url")]//) private String url;
		private string url;

		public virtual string PageName
		{
			set
			{
				this.pageName = value;
			}
			get
			{
				return this.pageName;
			}
		}

		public virtual string LongUrl
		{
			set
			{
				this.longUrl = value;
			}
			get
			{
				return this.longUrl;
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



	}
}