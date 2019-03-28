using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanEbizStatsReferralSourcesGetResult : APIResult
	{



		/// <summary>
		/// 分页参数
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
		private Paginator paginator;


		/// <summary>
		/// 监控来源列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private ReferralSource[] items;
		private ReferralSource[] items;

		public virtual void setPaginator(Paginator paginator)
		{
			this.paginator = paginator;
		}

		public virtual Paginator getPaginator()
		{
			return this.paginator;
		}
		public virtual ReferralSource[] Items
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


		public class ReferralSource
		{


			/// <summary>
			/// 来源 id
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_id")]//) private Nullable<long> sourceId;
				internal long? sourceId;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("create_time")]//) private java.util.Date createTime;
				internal DateTime createTime;


			/// <summary>
			/// 来源名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_name")]//) private String sourceName;
				internal string sourceName;

				public virtual long? SourceId
				{
					set
					{
					this.sourceId = value;
					}
					get
					{
					return this.sourceId;
					}
				}


				public virtual DateTime CreateTime
				{
					set
					{
					this.createTime = value;
					}
					get
					{
					return this.createTime;
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