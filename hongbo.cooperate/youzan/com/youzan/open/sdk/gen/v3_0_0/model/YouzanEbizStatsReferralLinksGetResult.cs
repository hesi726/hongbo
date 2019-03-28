namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanEbizStatsReferralLinksGetResult : APIResult
	{



		/// <summary>
		/// 分页参数
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
		private Paginator paginator;


		/// <summary>
		/// 跟踪链接列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private ReferralLink[] items;
		private ReferralLink[] items;

		public virtual void setPaginator(Paginator paginator)
		{
			this.paginator = paginator;
		}

		public virtual Paginator getPaginator()
		{
			return this.paginator;
		}
		public virtual ReferralLink[] Items
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


		public class ReferralLink
		{


			/// <summary>
			/// 监控页面 id
			/// </summary>
[Newtonsoft.Json.JsonProperty("page_id")]//) private Nullable<long> pageId;
				internal long? pageId;


			/// <summary>
			/// 跟踪链接 id
			/// </summary>
[Newtonsoft.Json.JsonProperty("track_link_id")]//) private Nullable<long> trackLinkId;
				internal long? trackLinkId;


			/// <summary>
			/// 来源 id
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_id")]//) private Nullable<long> sourceId;
				internal long? sourceId;


			/// <summary>
			/// 来源名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_name")]//) private String sourceName;
				internal string sourceName;


			/// <summary>
			/// 页面别名
			/// </summary>
[Newtonsoft.Json.JsonProperty("page_alias")]//) private String pageAlias;
				internal string pageAlias;


			/// <summary>
			/// 被监控页面类型：f，g，h
			/// </summary>
[Newtonsoft.Json.JsonProperty("page_type")]//) private String pageType;
				internal string pageType;


			/// <summary>
			/// 落地UV:筛选区间内该页面作为第一个被访问的页面的用户数
			/// </summary>
[Newtonsoft.Json.JsonProperty("uv")]//) private Nullable<long> uv;
				internal long? uv;


			/// <summary>
			/// 落地PV:筛选区间内该页面作为第一个被访问的页面的浏览量
			/// </summary>
[Newtonsoft.Json.JsonProperty("pv")]//) private Nullable<long> pv;
				internal long? pv;


			/// <summary>
			/// 二跳UV: 筛选区间内用户访问落地页面后，在页面中发生点击行为进入更多店铺内页面的用户数
			/// </summary>
[Newtonsoft.Json.JsonProperty("sec_uv")]//) private Nullable<long> secUv;
				internal long? secUv;


			/// <summary>
			/// 二跳PV: 筛选区间内用户访问落地页面后，在页面中发生点击行为进入更多店铺内页面的点击次数
			/// </summary>
[Newtonsoft.Json.JsonProperty("sec_pv")]//) private Nullable<long> secPv;
				internal long? secPv;


			/// <summary>
			/// 页面跳出率: 筛选区间内用户访问落地页面后，没有任何点击访问就退出页面的比率
			/// </summary>
[Newtonsoft.Json.JsonProperty("out_rate")]//) private Nullable<long> outRate;
				internal long? outRate;


			/// <summary>
			/// 转化下单数: 筛选区间内用户访问落地页面后，2小时内在店铺中进行下单的数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("order_cnt")]//) private Nullable<long> orderCnt;
				internal long? orderCnt;


			/// <summary>
			/// 转化付款数: 筛选区间内用户访问落地页面后，2小时内在店铺中进行下单并且付款成功的订单数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("payed_cnt")]//) private Nullable<long> payedCnt;
				internal long? payedCnt;


			/// <summary>
			/// 转化成交额（分）: 筛选区间内用户访问落地页面后，2小时内在店铺中进行下单并且付款成功的成交金额
			/// </summary>
[Newtonsoft.Json.JsonProperty("payed_amount")]//) private Nullable<long> payedAmount;
				internal long? payedAmount;


			/// <summary>
			/// 购买转化率: 筛选区间内用户访问落地页面后，2小时内在店铺中进行下单并且付款成功的人数与访客数的比率。计算公式：付款人数 / 落地UV × 100%
			/// </summary>
[Newtonsoft.Json.JsonProperty("buy_rate")]//) private Nullable<long> buyRate;
				internal long? buyRate;


			/// <summary>
			/// 转化付款人数：筛选区间内，用户访问落地页面后，2小时内在店铺中进行下单并且付款成功的用户数
			/// </summary>
[Newtonsoft.Json.JsonProperty("payed_user_cnt")]//) private Nullable<long> payedUserCnt;
				internal long? payedUserCnt;


			/// <summary>
			/// goodsCnt
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_cnt")]//) private Nullable<long> goodsCnt;
				internal long? goodsCnt;


			/// <summary>
			/// 单品成交额: 筛选区间内，用户访问落地页面后，2小时内投放商品下单并且付款成功的成交金额（不包括其他连带销售商品的成交额）
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_payed_amount")]//) private Nullable<long> goodsPayedAmount;
				internal long? goodsPayedAmount;


			/// <summary>
			/// 创建来源
			/// </summary>
[Newtonsoft.Json.JsonProperty("origin")]//) private Nullable<long> origin;
				internal long? origin;

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


				public virtual string PageAlias
				{
					set
					{
					this.pageAlias = value;
					}
					get
					{
					return this.pageAlias;
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


				public virtual long? OrderCnt
				{
					set
					{
					this.orderCnt = value;
					}
					get
					{
					return this.orderCnt;
					}
				}


				public virtual long? PayedCnt
				{
					set
					{
					this.payedCnt = value;
					}
					get
					{
					return this.payedCnt;
					}
				}


				public virtual long? PayedAmount
				{
					set
					{
					this.payedAmount = value;
					}
					get
					{
					return this.payedAmount;
					}
				}


				public virtual long? BuyRate
				{
					set
					{
					this.buyRate = value;
					}
					get
					{
					return this.buyRate;
					}
				}


				public virtual long? PayedUserCnt
				{
					set
					{
					this.payedUserCnt = value;
					}
					get
					{
					return this.payedUserCnt;
					}
				}


				public virtual long? GoodsCnt
				{
					set
					{
					this.goodsCnt = value;
					}
					get
					{
					return this.goodsCnt;
					}
				}


				public virtual long? GoodsPayedAmount
				{
					set
					{
					this.goodsPayedAmount = value;
					}
					get
					{
					return this.goodsPayedAmount;
					}
				}


				public virtual long? Origin
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