namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanPayAccountingSummaryDetailGetResult : APIResult
	{



		/// <summary>
		/// 账户编号
		/// </summary>
[Newtonsoft.Json.JsonProperty("acct_no")]//) private String acctNo;
		private string acctNo;


		/// <summary>
		/// 币种
		/// </summary>
[Newtonsoft.Json.JsonProperty("currency")]//) private Nullable<long> currency;
		private long? currency;


		/// <summary>
		/// 收入金额（分）
		/// </summary>
[Newtonsoft.Json.JsonProperty("income_amount")]//) private Nullable<long> incomeAmount;
		private long? incomeAmount;


		/// <summary>
		/// 支出金额（分）
		/// </summary>
[Newtonsoft.Json.JsonProperty("paid_amount")]//) private Nullable<long> paidAmount;
		private long? paidAmount;


		/// <summary>
		/// 期初余额（分）
		/// </summary>
[Newtonsoft.Json.JsonProperty("previous_balance")]//) private Nullable<long> previousBalance;
		private long? previousBalance;


		/// <summary>
		/// 期末余额（分）
		/// </summary>
[Newtonsoft.Json.JsonProperty("current_balance")]//) private Nullable<long> currentBalance;
		private long? currentBalance;


		/// <summary>
		/// 汇总日期
		/// </summary>
[Newtonsoft.Json.JsonProperty("summary_date")]//) private Nullable<long> summaryDate;
		private long? summaryDate;


		/// <summary>
		/// 汇总方式
		/// </summary>
[Newtonsoft.Json.JsonProperty("summary_type")]//) private String summaryType;
		private string summaryType;


		/// <summary>
		/// 收入详情列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("income_detail_list")]//) private AccountingSummaryDetailDataDTO[] incomeDetailList;
		private AccountingSummaryDetailDataDTO[] incomeDetailList;


		/// <summary>
		/// 支出详情列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("paid_detail_list")]//) private AccountingSummaryDetailDataDTO[] paidDetailList;
		private AccountingSummaryDetailDataDTO[] paidDetailList;

		public virtual string AcctNo
		{
			set
			{
				this.acctNo = value;
			}
			get
			{
				return this.acctNo;
			}
		}

		public virtual long? Currency
		{
			set
			{
				this.currency = value;
			}
			get
			{
				return this.currency;
			}
		}

		public virtual long? IncomeAmount
		{
			set
			{
				this.incomeAmount = value;
			}
			get
			{
				return this.incomeAmount;
			}
		}

		public virtual long? PaidAmount
		{
			set
			{
				this.paidAmount = value;
			}
			get
			{
				return this.paidAmount;
			}
		}

		public virtual long? PreviousBalance
		{
			set
			{
				this.previousBalance = value;
			}
			get
			{
				return this.previousBalance;
			}
		}

		public virtual long? CurrentBalance
		{
			set
			{
				this.currentBalance = value;
			}
			get
			{
				return this.currentBalance;
			}
		}

		public virtual long? SummaryDate
		{
			set
			{
				this.summaryDate = value;
			}
			get
			{
				return this.summaryDate;
			}
		}

		public virtual string SummaryType
		{
			set
			{
				this.summaryType = value;
			}
			get
			{
				return this.summaryType;
			}
		}

		public virtual AccountingSummaryDetailDataDTO[] IncomeDetailList
		{
			set
			{
				this.incomeDetailList = value;
			}
			get
			{
				return this.incomeDetailList;
			}
		}

		public virtual AccountingSummaryDetailDataDTO[] PaidDetailList
		{
			set
			{
				this.paidDetailList = value;
			}
			get
			{
				return this.paidDetailList;
			}
		}


		public class AccountingSummaryDetailDataDTO
		{


			/// <summary>
			/// 业务名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("biz_name")]//) private String bizName;
				internal string bizName;


			/// <summary>
			/// 交易笔数
			/// </summary>
[Newtonsoft.Json.JsonProperty("trade_count")]//) private Nullable<long> tradeCount;
				internal long? tradeCount;


			/// <summary>
			/// 金额（分）
			/// </summary>
[Newtonsoft.Json.JsonProperty("amount")]//) private Nullable<long> amount;
				internal long? amount;

				public virtual string BizName
				{
					set
					{
					this.bizName = value;
					}
					get
					{
					return this.bizName;
					}
				}


				public virtual long? TradeCount
				{
					set
					{
					this.tradeCount = value;
					}
					get
					{
					return this.tradeCount;
					}
				}


				public virtual long? Amount
				{
					set
					{
					this.amount = value;
					}
					get
					{
					return this.amount;
					}
				}


		}


	}
}