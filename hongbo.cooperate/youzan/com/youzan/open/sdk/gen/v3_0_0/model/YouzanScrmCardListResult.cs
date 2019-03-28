using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCardListResult : APIResult
	{



		/// <summary>
		/// 会员卡总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<long> total;
		private long? total;


		/// <summary>
		/// 页码
		/// </summary>
[Newtonsoft.Json.JsonProperty("page")]//) private Nullable<long> page;
		private long? page;


		/// <summary>
		/// 每页最大纪录数
		/// </summary>
[Newtonsoft.Json.JsonProperty("page_size")]//) private Nullable<long> pageSize;
		private long? pageSize;


		/// <summary>
		/// 会员卡列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private CardListItemDTO[] items;
		private CardListItemDTO[] items;

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

		public virtual CardListItemDTO[] Items
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


		public class CardListItemDTO
		{


			/// <summary>
			/// 商家会员卡的唯一标识
			/// </summary>
[Newtonsoft.Json.JsonProperty("card_alias")]//) private String cardAlias;
				internal string cardAlias;


			/// <summary>
			/// 会员卡名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 发卡链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("card_link")]//) private String cardLink;
				internal string cardLink;


			/// <summary>
			/// 会员卡状态：使用中:true 已禁用:false
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_available")]//) private Nullable<bool> isAvailable;
				internal bool? isAvailable;


			/// <summary>
			/// 会员卡创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("create_time")]//) private java.util.Date createTime;
				internal DateTime createTime;


			/// <summary>
			/// 会员卡类型;3:无门槛卡,2:付费卡,1:规则卡
			/// </summary>
[Newtonsoft.Json.JsonProperty("grant_type")]//) private Nullable<long> grantType;
				internal long? grantType;

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


				public virtual string CardLink
				{
					set
					{
					this.cardLink = value;
					}
					get
					{
					return this.cardLink;
					}
				}


				public virtual bool? IsAvailable
				{
					set
					{
					this.isAvailable = value;
					}
					get
					{
					return this.isAvailable;
					}
				}


				public virtual DateTime CreateTime
				{
					set
					{
					this.createTime = value;
					}
					get
					{
					return this.createTime;
					}
				}


				public virtual long? GrantType
				{
					set
					{
					this.grantType = value;
					}
					get
					{
					return this.grantType;
					}
				}


		}


	}
}