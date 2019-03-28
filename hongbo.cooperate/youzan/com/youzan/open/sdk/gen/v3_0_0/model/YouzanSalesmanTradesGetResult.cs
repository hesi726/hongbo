namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanSalesmanTradesGetResult : APIResult
	{



		/// <summary>
		/// 记录总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total_results")]//) private Nullable<long> totalResults;
		private long? totalResults;


		/// <summary>
		/// 推广订单列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("trades")]//) private SalesmanTradeDetail[] trades;
		private SalesmanTradeDetail[] trades;

		public virtual long? TotalResults
		{
			set
			{
				this.totalResults = value;
			}
			get
			{
				return this.totalResults;
			}
		}

		public virtual SalesmanTradeDetail[] Trades
		{
			set
			{
				this.trades = value;
			}
			get
			{
				return this.trades;
			}
		}


		public class SalesmanTradeItem
		{


			/// <summary>
			/// 商品价格(元)
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private String price;
				internal string price;


			/// <summary>
			/// 商品数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("num")]//) private Nullable<long> num;
				internal long? num;


			/// <summary>
			/// 商品名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 商品是否参与推广0:不参与1参与
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_join")]//) private Nullable<long> isJoin;
				internal long? isJoin;


			/// <summary>
			/// 商品ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("num_iid")]//) private String numIid;
				internal string numIid;


			/// <summary>
			/// 商品提成比例(%)
			/// </summary>
[Newtonsoft.Json.JsonProperty("i_rate")]//) private String iRate;
				internal string iRate;


			/// <summary>
			/// 商品邀请奖励提成比例(%)
			/// </summary>
[Newtonsoft.Json.JsonProperty("ii_rate")]//) private String iiRate;
				internal string iiRate;


			/// <summary>
			/// 商品提成奖励(元)
			/// </summary>
[Newtonsoft.Json.JsonProperty("i_cps_money")]//) private String iCpsMoney;
				internal string iCpsMoney;


			/// <summary>
			/// 商品邀请奖励提成奖励(元)
			/// </summary>
[Newtonsoft.Json.JsonProperty("ii_cps_money")]//) private String iiCpsMoney;
				internal string iiCpsMoney;

				public virtual string Price
				{
					set
					{
					this.price = value;
					}
					get
					{
					return this.price;
					}
				}


				public virtual long? Num
				{
					set
					{
					this.num = value;
					}
					get
					{
					return this.num;
					}
				}


				public virtual string Title
				{
					set
					{
					this.title = value;
					}
					get
					{
					return this.title;
					}
				}


				public virtual long? IsJoin
				{
					set
					{
					this.isJoin = value;
					}
					get
					{
					return this.isJoin;
					}
				}


				public virtual string NumIid
				{
					set
					{
					this.numIid = value;
					}
					get
					{
					return this.numIid;
					}
				}


				public virtual string IRate
				{
					set
					{
					this.iRate = value;
					}
					get
					{
					return this.iRate;
					}
				}


				public virtual string IiRate
				{
					set
					{
					this.iiRate = value;
					}
					get
					{
					return this.iiRate;
					}
				}


				public virtual string ICpsMoney
				{
					set
					{
					this.iCpsMoney = value;
					}
					get
					{
					return this.iCpsMoney;
					}
				}


				public virtual string IiCpsMoney
				{
					set
					{
					this.iiCpsMoney = value;
					}
					get
					{
					return this.iiCpsMoney;
					}
				}


		}

		public class SalesmanTradeDetail
		{


			/// <summary>
			/// 销售员标记
			/// </summary>
[Newtonsoft.Json.JsonProperty("seller")]//) private String seller;
				internal string seller;


			/// <summary>
			/// 推广订单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("order_no")]//) private String orderNo;
				internal string orderNo;


			/// <summary>
			/// 订单总额(元),扣除运费
			/// </summary>
[Newtonsoft.Json.JsonProperty("money")]//) private String money;
				internal string money;


			/// <summary>
			/// 下单时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private String createdAt;
				internal string createdAt;


			/// <summary>
			/// 提成金额(元)
			/// </summary>
[Newtonsoft.Json.JsonProperty("cps_money")]//) private String cpsMoney;
				internal string cpsMoney;


			/// <summary>
			/// 订单状态:3:待付款，5:已付款，6:已发货，100:交易完成
			/// </summary>
[Newtonsoft.Json.JsonProperty("state")]//) private Nullable<long> state;
				internal long? state;


			/// <summary>
			/// 销售员手机号
			/// </summary>
[Newtonsoft.Json.JsonProperty("phone")]//) private String phone;
				internal string phone;


			/// <summary>
			/// 销售员推广订单详细商品提成信息数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private SalesmanTradeItem[] items;
				internal SalesmanTradeItem[] items;


			/// <summary>
			/// 结算状态1:待结算 2:已结算 3:余额不足 4:结算异常，等待重试 5:货到付款
			/// </summary>
[Newtonsoft.Json.JsonProperty("settle_state")]//) private Nullable<long> settleState;
				internal long? settleState;


			/// <summary>
			/// 是否自动结算0:人工结算1:自动结算
			/// </summary>
[Newtonsoft.Json.JsonProperty("auto_settle")]//) private Nullable<long> autoSettle;
				internal long? autoSettle;

				public virtual string Seller
				{
					set
					{
					this.seller = value;
					}
					get
					{
					return this.seller;
					}
				}


				public virtual string OrderNo
				{
					set
					{
					this.orderNo = value;
					}
					get
					{
					return this.orderNo;
					}
				}


				public virtual string Money
				{
					set
					{
					this.money = value;
					}
					get
					{
					return this.money;
					}
				}


				public virtual string CreatedAt
				{
					set
					{
					this.createdAt = value;
					}
					get
					{
					return this.createdAt;
					}
				}


				public virtual string CpsMoney
				{
					set
					{
					this.cpsMoney = value;
					}
					get
					{
					return this.cpsMoney;
					}
				}


				public virtual long? State
				{
					set
					{
					this.state = value;
					}
					get
					{
					return this.state;
					}
				}


				public virtual string Phone
				{
					set
					{
					this.phone = value;
					}
					get
					{
					return this.phone;
					}
				}


				public virtual SalesmanTradeItem[] Items
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


				public virtual long? SettleState
				{
					set
					{
					this.settleState = value;
					}
					get
					{
					return this.settleState;
					}
				}


				public virtual long? AutoSettle
				{
					set
					{
					this.autoSettle = value;
					}
					get
					{
					return this.autoSettle;
					}
				}


		}


	}
}