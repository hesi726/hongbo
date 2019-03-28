namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanSalesmanAccountScoreSearchResult : APIResult
	{



		/// <summary>
		/// 业绩统计列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("accumulations")]//) private accumulationsItemDTO[] accumulations;
		private accumulationsItemDTO[] accumulations;


		/// <summary>
		/// 记录总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total_results")]//) private Nullable<long> totalResults;
		private long? totalResults;

		public virtual accumulationsItemDTO[] Accumulations
		{
			set
			{
				this.accumulations = value;
			}
			get
			{
				return this.accumulations;
			}
		}

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


		public class accumulationsItemDTO
		{


			/// <summary>
			/// 人工结算订单金额
			/// </summary>
[Newtonsoft.Json.JsonProperty("manual_settle_order_amount")]//) private String manualSettleOrderAmount;
				internal string manualSettleOrderAmount;


			/// <summary>
			/// 人工结算订单数
			/// </summary>
[Newtonsoft.Json.JsonProperty("manual_settle_order_num")]//) private String manualSettleOrderNum;
				internal string manualSettleOrderNum;


			/// <summary>
			/// 自动结算订单金额
			/// </summary>
[Newtonsoft.Json.JsonProperty("auto_settle_order_amount")]//) private String autoSettleOrderAmount;
				internal string autoSettleOrderAmount;


			/// <summary>
			/// 自动结算订单数
			/// </summary>
[Newtonsoft.Json.JsonProperty("auto_settle_order_num")]//) private String autoSettleOrderNum;
				internal string autoSettleOrderNum;


			/// <summary>
			/// 待结算佣金
			/// </summary>
[Newtonsoft.Json.JsonProperty("wait_settle_money")]//) private String waitSettleMoney;
				internal string waitSettleMoney;


			/// <summary>
			/// 已结算佣金
			/// </summary>
[Newtonsoft.Json.JsonProperty("settle_money")]//) private String settleMoney;
				internal string settleMoney;


			/// <summary>
			/// 手机号
			/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
				internal string mobile;


			/// <summary>
			/// 昵称
			/// </summary>
[Newtonsoft.Json.JsonProperty("nickname")]//) private String nickname;
				internal string nickname;

				public virtual string ManualSettleOrderAmount
				{
					set
					{
					this.manualSettleOrderAmount = value;
					}
					get
					{
					return this.manualSettleOrderAmount;
					}
				}


				public virtual string ManualSettleOrderNum
				{
					set
					{
					this.manualSettleOrderNum = value;
					}
					get
					{
					return this.manualSettleOrderNum;
					}
				}


				public virtual string AutoSettleOrderAmount
				{
					set
					{
					this.autoSettleOrderAmount = value;
					}
					get
					{
					return this.autoSettleOrderAmount;
					}
				}


				public virtual string AutoSettleOrderNum
				{
					set
					{
					this.autoSettleOrderNum = value;
					}
					get
					{
					return this.autoSettleOrderNum;
					}
				}


				public virtual string WaitSettleMoney
				{
					set
					{
					this.waitSettleMoney = value;
					}
					get
					{
					return this.waitSettleMoney;
					}
				}


				public virtual string SettleMoney
				{
					set
					{
					this.settleMoney = value;
					}
					get
					{
					return this.settleMoney;
					}
				}


				public virtual string Mobile
				{
					set
					{
					this.mobile = value;
					}
					get
					{
					return this.mobile;
					}
				}


				public virtual string Nickname
				{
					set
					{
					this.nickname = value;
					}
					get
					{
					return this.nickname;
					}
				}


		}


	}
}