using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCustomerCardListResult : APIResult
	{



		/// <summary>
		/// 会员拥有的会员卡总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<long> total;
		private long? total;


		/// <summary>
		/// 当前页码
		/// </summary>
[Newtonsoft.Json.JsonProperty("page")]//) private Nullable<long> page;
		private long? page;


		/// <summary>
		/// 每页的最大记录条数
		/// </summary>
[Newtonsoft.Json.JsonProperty("page_size")]//) private Nullable<long> pageSize;
		private long? pageSize;


		/// <summary>
		/// 会员卡列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private CustomerCardListItemDTO items;
		private CustomerCardListItemDTO items;

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

		public virtual CustomerCardListItemDTO Items
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


		public class CustomerCardListItemDTO
		{


			/// <summary>
			/// 会员卡有效期截止日期
			/// </summary>
[Newtonsoft.Json.JsonProperty("card_end_time")]//) private java.util.Date cardEndTime;
				internal DateTime cardEndTime;


			/// <summary>
			/// 会员卡有效期开始日期
			/// </summary>
[Newtonsoft.Json.JsonProperty("card_start_time")]//) private java.util.Date cardStartTime;
				internal DateTime cardStartTime;


			/// <summary>
			/// 用户会员卡卡号
			/// </summary>
[Newtonsoft.Json.JsonProperty("card_no")]//) private String cardNo;
				internal string cardNo;


			/// <summary>
			/// 商家会员卡的唯一标识
			/// </summary>
[Newtonsoft.Json.JsonProperty("card_alias")]//) private String cardAlias;
				internal string cardAlias;

				public virtual DateTime CardEndTime
				{
					set
					{
					this.cardEndTime = value;
					}
					get
					{
					return this.cardEndTime;
					}
				}


				public virtual DateTime CardStartTime
				{
					set
					{
					this.cardStartTime = value;
					}
					get
					{
					return this.cardStartTime;
					}
				}


				public virtual string CardNo
				{
					set
					{
					this.cardNo = value;
					}
					get
					{
					return this.cardNo;
					}
				}


				public virtual string CardAlias
				{
					set
					{
					this.cardAlias = value;
					}
					get
					{
					return this.cardAlias;
					}
				}


		}


	}
}