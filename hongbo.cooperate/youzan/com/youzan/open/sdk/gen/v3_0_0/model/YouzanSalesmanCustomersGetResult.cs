namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanSalesmanCustomersGetResult : APIResult
	{



		/// <summary>
		/// 记录总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total_results")]//) private Nullable<long> totalResults;
		private long? totalResults;


		/// <summary>
		/// 客户列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("customers")]//) private SalesmanCustomerDetail[] customers;
		private SalesmanCustomerDetail[] customers;

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

		public virtual SalesmanCustomerDetail[] Customers
		{
			set
			{
				this.customers = value;
			}
			get
			{
				return this.customers;
			}
		}


		public class SalesmanCustomerDetail
		{


			/// <summary>
			/// 客户昵称
			/// </summary>
[Newtonsoft.Json.JsonProperty("nickname")]//) private String nickname;
				internal string nickname;


			/// <summary>
			/// 客户头像
			/// </summary>
[Newtonsoft.Json.JsonProperty("avatar")]//) private String avatar;
				internal string avatar;


			/// <summary>
			/// 粉丝类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_type")]//) private Nullable<long> fansType;
				internal long? fansType;


			/// <summary>
			/// 粉丝Id
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_id")]//) private Nullable<long> fansId;
				internal long? fansId;

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


				public virtual string Avatar
				{
					set
					{
					this.avatar = value;
					}
					get
					{
					return this.avatar;
					}
				}


				public virtual long? FansType
				{
					set
					{
					this.fansType = value;
					}
					get
					{
					return this.fansType;
					}
				}


				public virtual long? FansId
				{
					set
					{
					this.fansId = value;
					}
					get
					{
					return this.fansId;
					}
				}


		}


	}
}