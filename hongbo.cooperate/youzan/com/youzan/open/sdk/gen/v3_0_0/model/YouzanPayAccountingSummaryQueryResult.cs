namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanPayAccountingSummaryQueryResult : APIResult
	{



		/// <summary>
		/// 汇总日期
		/// </summary>
[Newtonsoft.Json.JsonProperty("summary_date")]//) private Nullable<long> summaryDate;
		private long? summaryDate;


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
		/// 收入交易笔数
		/// </summary>
[Newtonsoft.Json.JsonProperty("income_trade_count")]//) private Nullable<long> incomeTradeCount;
		private long? incomeTradeCount;


		/// <summary>
		/// 支出交易笔数
		/// </summary>
[Newtonsoft.Json.JsonProperty("paid_trade_count")]//) private Nullable<long> paidTradeCount;
		private long? paidTradeCount;


		/// <summary>
		/// 期初余额（分）
		/// </summary>
[Newtonsoft.Json.JsonProperty("init_balance")]//) private Nullable<long> initBalance;
		private long? initBalance;


		/// <summary>
		/// 期末余额（分）
		/// </summary>
[Newtonsoft.Json.JsonProperty("end_balance")]//) private Nullable<long> endBalance;
		private long? endBalance;


		/// <summary>
		/// 汇总编号
		/// </summary>
[Newtonsoft.Json.JsonProperty("summary_no")]//) private String summaryNo;
		private string summaryNo;


		/// <summary>
		/// 币种
		/// </summary>
[Newtonsoft.Json.JsonProperty("currency")]//) private Nullable<long> currency;
		private long? currency;


		/// <summary>
		/// 账户编号
		/// </summary>
[Newtonsoft.Json.JsonProperty("acct_no")]//) private String acctNo;
		private string acctNo;


		/// <summary>
		/// 汇总类型
		/// </summary>
[Newtonsoft.Json.JsonProperty("summary_type")]//) private String summaryType;
		private string summaryType;

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

		public virtual long? IncomeTradeCount
		{
			set
			{
				this.incomeTradeCount = value;
			}
			get
			{
				return this.incomeTradeCount;
			}
		}

		public virtual long? PaidTradeCount
		{
			set
			{
				this.paidTradeCount = value;
			}
			get
			{
				return this.paidTradeCount;
			}
		}

		public virtual long? InitBalance
		{
			set
			{
				this.initBalance = value;
			}
			get
			{
				return this.initBalance;
			}
		}

		public virtual long? EndBalance
		{
			set
			{
				this.endBalance = value;
			}
			get
			{
				return this.endBalance;
			}
		}

		public virtual string SummaryNo
		{
			set
			{
				this.summaryNo = value;
			}
			get
			{
				return this.summaryNo;
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



	}
}