namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanEbizStatsReferralPagesGetResult : APIResult
	{



		/// <summary>
		/// 分页参数
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
		private Paginator paginator;


		/// <summary>
		/// 监控页面列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private ReferralPage[] items;
		private ReferralPage[] items;

		public virtual void setPaginator(Paginator paginator)
		{
			this.paginator = paginator;
		}

		public virtual Paginator getPaginator()
		{
			return this.paginator;
		}
		public virtual ReferralPage[] Items
		{
			set
			{
				this.items = value;
			}
			get
			{
				return this.items;
			}
		}


		public class ReferralPage
		{


			/// <summary>
			/// 监控页面 id
			/// </summary>
[Newtonsoft.Json.JsonProperty("page_id")]//) private Nullable<long> pageId;
				internal long? pageId;


			/// <summary>
			/// 被监控对象的类型：f，g，h
			/// </summary>
[Newtonsoft.Json.JsonProperty("page_type")]//) private String pageType;
				internal string pageType;


			/// <summary>
			/// 被监控对象的 url
			/// </summary>
[Newtonsoft.Json.JsonProperty("url")]//) private String url;
				internal string url;


			/// <summary>
			/// 被监控对象的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("page_name")]//) private String pageName;
				internal string pageName;


			/// <summary>
			/// 落地PV:筛选区间内该页面作为第一个被访问的页面的浏览量
			/// </summary>
[Newtonsoft.Json.JsonProperty("pv")]//) private Nullable<long> pv;
				internal long? pv;


			/// <summary>
			/// 落地UV:筛选区间内该页面作为第一个被访问的页面的用户数
			/// </summary>
[Newtonsoft.Json.JsonProperty("uv")]//) private Nullable<long> uv;
				internal long? uv;


			/// <summary>
			/// 二跳PV: 筛选区间内用户访问落地页面后，在页面中发生点击行为进入更多店铺内页面的点击次数
			/// </summary>
[Newtonsoft.Json.JsonProperty("sec_pv")]//) private Nullable<long> secPv;
				internal long? secPv;


			/// <summary>
			/// 二跳UV: 筛选区间内用户访问落地页面后，在页面中发生点击行为进入更多店铺内页面的用户数
			/// </summary>
[Newtonsoft.Json.JsonProperty("sec_uv")]//) private Nullable<long> secUv;
				internal long? secUv;


			/// <summary>
			/// 页面跳出率: 筛选区间内用户访问落地页面后，没有任何点击访问就退出页面的比率
			/// </summary>
[Newtonsoft.Json.JsonProperty("out_rate")]//) private Nullable<long> outRate;
				internal long? outRate;

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


				public virtual string PageType
				{
					set
					{
					this.pageType = value;
					}
					get
					{
					return this.pageType;
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


				public virtual long? Pv
				{
					set
					{
					this.pv = value;
					}
					get
					{
					return this.pv;
					}
				}


				public virtual long? Uv
				{
					set
					{
					this.uv = value;
					}
					get
					{
					return this.uv;
					}
				}


				public virtual long? SecPv
				{
					set
					{
					this.secPv = value;
					}
					get
					{
					return this.secPv;
					}
				}


				public virtual long? SecUv
				{
					set
					{
					this.secUv = value;
					}
					get
					{
					return this.secUv;
					}
				}


				public virtual long? OutRate
				{
					set
					{
					this.outRate = value;
					}
					get
					{
					return this.outRate;
					}
				}


		}

		public class Paginator
		{


			/// <summary>
			/// 当前页码
			/// </summary>
[Newtonsoft.Json.JsonProperty("page")]//) private Nullable<long> page;
				internal long? page;


			/// <summary>
			/// 分页大小
			/// </summary>
[Newtonsoft.Json.JsonProperty("page_size")]//) private Nullable<long> pageSize;
				internal long? pageSize;


			/// <summary>
			/// 查询结果总数
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_count")]//) private Nullable<long> totalCount;
				internal long? totalCount;

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


				public virtual long? TotalCount
				{
					set
					{
					this.totalCount = value;
					}
					get
					{
					return this.totalCount;
					}
				}


		}


	}
}