namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanEbizStatsReferralOrdersSearchResult : APIResult
	{



		/// <summary>
		/// 返回结果包装
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginatorResult")]//) private paginatorResult paginatorResult;
		private paginatorResult _paginatorResult;

		public virtual paginatorResult PaginatorResult
		{
			set
			{
				this._paginatorResult = value;
			}
			get
			{
				return this._paginatorResult;
			}
		}


		public class list
		{


			/// <summary>
			/// kdtId
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 目标完成度
			/// </summary>
[Newtonsoft.Json.JsonProperty("complete_percent")]//) private Nullable<long> completePercent;
				internal long? completePercent;


			/// <summary>
			/// 排名
			/// </summary>
[Newtonsoft.Json.JsonProperty("rank")]//) private Nullable<long> rank;
				internal long? rank;


			/// <summary>
			/// test1
			/// </summary>
[Newtonsoft.Json.JsonProperty("shop_name")]//) private String shopName;
				internal string shopName;


			/// <summary>
			/// 目标完成百分比
			/// </summary>
[Newtonsoft.Json.JsonProperty("percent")]//) private String percent;
				internal string percent;

				public virtual long? KdtId
				{
					set
					{
					this.kdtId = value;
					}
					get
					{
					return this.kdtId;
					}
				}


				public virtual long? CompletePercent
				{
					set
					{
					this.completePercent = value;
					}
					get
					{
					return this.completePercent;
					}
				}


				public virtual long? Rank
				{
					set
					{
					this.rank = value;
					}
					get
					{
					return this.rank;
					}
				}


				public virtual string ShopName
				{
					set
					{
					this.shopName = value;
					}
					get
					{
					return this.shopName;
					}
				}


				public virtual string Percent
				{
					set
					{
					this.percent = value;
					}
					get
					{
					return this.percent;
					}
				}


		}

		public class paginatorResult
		{


			/// <summary>
			/// 分页+集合
			/// </summary>
[Newtonsoft.Json.JsonProperty("data")]//) private listWithPaginatorVO data;
				internal listWithPaginatorVO data;


			/// <summary>
			/// 调用是否成功
			/// </summary>
[Newtonsoft.Json.JsonProperty("success")]//) private Nullable<bool> success;
				internal bool? success;


			/// <summary>
			/// 错误code
			/// </summary>
[Newtonsoft.Json.JsonProperty("code")]//) private Nullable<long> code;
				internal long? code;


			/// <summary>
			/// 错误信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("message")]//) private String message;
				internal string message;


			/// <summary>
			/// 请求id
			/// </summary>
[Newtonsoft.Json.JsonProperty("requestId")]//) private String requestId;
				internal string requestId;

				public virtual listWithPaginatorVO Data
				{
					set
					{
					this.data = value;
					}
					get
					{
					return this.data;
					}
				}


				public virtual bool? Success
				{
					set
					{
					this.success = value;
					}
					get
					{
					return this.success;
					}
				}


				public virtual long? Code
				{
					set
					{
					this.code = value;
					}
					get
					{
					return this.code;
					}
				}


				public virtual string Message
				{
					set
					{
					this.message = value;
					}
					get
					{
					return this.message;
					}
				}


				public virtual string RequestId
				{
					set
					{
					this.requestId = value;
					}
					get
					{
					return this.requestId;
					}
				}


		}

		public class listWithPaginatorVO
		{


			/// <summary>
			/// 包含店铺排名信息的列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private list items;
				internal list items;


			/// <summary>
			/// 当前页码
			/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
				internal Paginator paginator;
			/// 

				public virtual list Items
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


				public virtual Paginator Paginator
				{
					set
					{
					this.paginator = value;
					}
					get
					{
					return this.paginator;
					}
				}


		}

		public class Paginator
		{


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