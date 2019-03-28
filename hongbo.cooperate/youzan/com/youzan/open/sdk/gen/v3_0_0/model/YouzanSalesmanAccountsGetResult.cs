namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanSalesmanAccountsGetResult : APIResult
	{



		/// <summary>
		/// 记录总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total_results")]//) private Nullable<long> totalResults;
		private long? totalResults;


		/// <summary>
		/// 分销员列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("accounts")]//) private SalesmanAccountDetail[] accounts;
		private SalesmanAccountDetail[] accounts;

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

		public virtual SalesmanAccountDetail[] Accounts
		{
			set
			{
				this.accounts = value;
			}
			get
			{
				return this.accounts;
			}
		}


		public class SalesmanAccountDetail
		{


			/// <summary>
			/// 手机号
			/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
				internal string mobile;


			/// <summary>
			/// 销售员昵称
			/// </summary>
[Newtonsoft.Json.JsonProperty("nickname")]//) private String nickname;
				internal string nickname;


			/// <summary>
			/// 销售员标识码
			/// </summary>
[Newtonsoft.Json.JsonProperty("seller")]//) private String seller;
				internal string seller;


			/// <summary>
			/// 累计成交笔数
			/// </summary>
[Newtonsoft.Json.JsonProperty("order_num")]//) private Nullable<long> orderNum;
				internal long? orderNum;


			/// <summary>
			/// 累计成交金额
			/// </summary>
[Newtonsoft.Json.JsonProperty("money")]//) private String money;
				internal string money;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private String createdAt;
				internal string createdAt;

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


				public virtual long? OrderNum
				{
					set
					{
					this.orderNum = value;
					}
					get
					{
					return this.orderNum;
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


		}


	}
}