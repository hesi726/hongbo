namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCustomerSearchResult : APIResult
	{



		/// <summary>
		/// 会员卡对应的会员个数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<long> total;
		private long? total;


		/// <summary>
		/// 当前页码
		/// </summary>
[Newtonsoft.Json.JsonProperty("page")]//) private Nullable<long> page;
		private long? page;


		/// <summary>
		/// 每页的记录数20
		/// </summary>
[Newtonsoft.Json.JsonProperty("page_size")]//) private Nullable<long> pageSize;
		private long? pageSize;


		/// <summary>
		/// 客户信息项
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private CardCustomerListItemDTO[] items;
		private CardCustomerListItemDTO[] items;

		public virtual long? Total
		{
			set
			{
				this.total = value;
			}
			get
			{
				return this.total;
			}
		}

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

		public virtual CardCustomerListItemDTO[] Items
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


		public class CardCustomerListItemDTO
		{


			/// <summary>
			/// 客户名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 粉丝id
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_id")]//) private Nullable<long> fansId;
				internal long? fansId;


			/// <summary>
			/// 粉丝类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("fasn_type")]//) private Nullable<long> fasnType;
				internal long? fasnType;


			/// <summary>
			/// 客户手机号
			/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
				internal string mobile;


			/// <summary>
			/// 微信昵称
			/// </summary>
[Newtonsoft.Json.JsonProperty("wx_nickname")]//) private String wxNickname;
				internal string wxNickname;

				public virtual string Name
				{
					set
					{
					this.name = value;
					}
					get
					{
					return this.name;
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


				public virtual long? FasnType
				{
					set
					{
					this.fasnType = value;
					}
					get
					{
					return this.fasnType;
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


				public virtual string WxNickname
				{
					set
					{
					this.wxNickname = value;
					}
					get
					{
					return this.wxNickname;
					}
				}


		}


	}
}