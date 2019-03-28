namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanEbizStatsReferralLinksTrendsGetResult : APIResult
	{



		/// <summary>
		/// 跟踪链接数据
		/// </summary>
[Newtonsoft.Json.JsonProperty("trends")]//) private ReferralTrend[] trends;
		private ReferralTrend[] trends;

		public virtual ReferralTrend[] Trends
		{
			set
			{
				this.trends = value;
			}
			get
			{
				return this.trends;
			}
		}


		public class ReferralTrend
		{


			/// <summary>
			/// 日期，格式为："2017-06-22"
			/// </summary>
[Newtonsoft.Json.JsonProperty("date")]//) private String date;
				internal string date;


			/// <summary>
			/// 落地UV:筛选区间内该页面作为第一个被访问的页面的用户数
			/// </summary>
[Newtonsoft.Json.JsonProperty("uv")]//) private Nullable<long> uv;
				internal long? uv;


			/// <summary>
			/// 转化成交额（分）: 筛选区间内用户访问落地页面后，2小时内在店铺中进行下单并且付款成功的成交金额
			/// </summary>
[Newtonsoft.Json.JsonProperty("payed_amount")]//) private Nullable<long> payedAmount;
				internal long? payedAmount;


			/// <summary>
			/// 落地PV:筛选区间内该页面作为第一个被访问的页面的浏览量
			/// </summary>
[Newtonsoft.Json.JsonProperty("pv")]//) private Nullable<long> pv;
				internal long? pv;


			/// <summary>
			/// 转化付款数: 筛选区间内用户访问落地页面后，2小时内在店铺中进行下单并且付款成功的订单数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("payed_cnt")]//) private Nullable<long> payedCnt;
				internal long? payedCnt;


			/// <summary>
			/// 页面跳出率: 筛选区间内用户访问落地页面后，没有任何点击访问就退出页面的比率
			/// </summary>
[Newtonsoft.Json.JsonProperty("out_rate")]//) private Nullable<long> outRate;
				internal long? outRate;


			/// <summary>
			/// 二跳PV: 筛选区间内用户访问落地页面后，在页面中发生点击行为进入更多店铺内页面的点击次数
			/// </summary>
[Newtonsoft.Json.JsonProperty("sec_pv")]//) private Nullable<long> secPv;
				internal long? secPv;


			/// <summary>
			/// 购买转化率: 筛选区间内用户访问落地页面后，2小时内在店铺中进行下单并且付款成功的人数与访客数的比率。计算公式：付款人数 / 落地UV × 100%
			/// </summary>
[Newtonsoft.Json.JsonProperty("buy_rate")]//) private Nullable<long> buyRate;
				internal long? buyRate;


			/// <summary>
			/// 二跳UV: 筛选区间内用户访问落地页面后，在页面中发生点击行为进入更多店铺内页面的用户数
			/// </summary>
[Newtonsoft.Json.JsonProperty("sec_uv")]//) private Nullable<long> secUv;
				internal long? secUv;


			/// <summary>
			/// 转化下单数: 筛选区间内用户访问落地页面后，2小时内在店铺中进行下单的数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("order_cnt")]//) private Nullable<long> orderCnt;
				internal long? orderCnt;


			/// <summary>
			/// 单品销量：筛选区间内，用户访问落地页面后，2小时内该页面商品被购买的销量（不包括其他连带销售商品的销量）
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_payed_cnt")]//) private Nullable<long> goodsPayedCnt;
				internal long? goodsPayedCnt;


			/// <summary>
			/// 转化付款人数：筛选区间内，用户访问落地页面后，2小时内在店铺中进行下单并且付款成功的用户数
			/// </summary>
[Newtonsoft.Json.JsonProperty("payed_user_cnt")]//) private Nullable<long> payedUserCnt;
				internal long? payedUserCnt;


			/// <summary>
			/// 单品成交额: 筛选区间内，用户访问落地页面后，2小时内投放商品下单并且付款成功的成交金额（不包括其他连带销售商品的成交额）
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_payed_amount")]//) private Nullable<long> goodsPayedAmount;
				internal long? goodsPayedAmount;


			/// <summary>
			/// 来源名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_name")]//) private Nullable<long> sourceName;
				internal long? sourceName;

				public virtual string Date
				{
					set
					{
					this.date = value;
					}
					get
					{
					return this.date;
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


				public virtual long? GoodsPayedCnt
				{
					set
					{
					this.goodsPayedCnt = value;
					}
					get
					{
					return this.goodsPayedCnt;
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


				public virtual long? SourceName
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


	}
}