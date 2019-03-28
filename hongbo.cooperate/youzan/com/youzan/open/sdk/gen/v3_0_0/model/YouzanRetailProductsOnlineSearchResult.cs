using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductsOnlineSearchResult : APIResult
	{



		/// <summary>
		/// 分页信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
		private Paginator paginator;


		/// <summary>
		/// 网店商品搜索结果实体信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private OnlineProductSearchVO items;
		private OnlineProductSearchVO items;

		public virtual void setPaginator(Paginator paginator)
		{
			this.paginator = paginator;
		}

		public virtual Paginator getPaginator()
		{
			return this.paginator;
		}
		public virtual OnlineProductSearchVO Items
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


		public class OnlineProductSearchVO
		{


			/// <summary>
			/// 网店商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 商品名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 商品图片url（多图片返回首图）
			/// </summary>
[Newtonsoft.Json.JsonProperty("photo_url")]//) private String photoUrl;
				internal string photoUrl;


			/// <summary>
			/// 零售价，单位：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;


			/// <summary>
			/// 商品创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private java.util.Date createdAt;
				internal DateTime createdAt;


			/// <summary>
			/// 商品更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated_at")]//) private java.util.Date updatedAt;
				internal DateTime updatedAt;


			/// <summary>
			/// 销售库存
			/// </summary>
[Newtonsoft.Json.JsonProperty("sell_stock_count")]//) private Nullable<long> sellStockCount;
				internal long? sellStockCount;


			/// <summary>
			/// 商品h5页面url
			/// </summary>
[Newtonsoft.Json.JsonProperty("display_url")]//) private String displayUrl;
				internal string displayUrl;


			/// <summary>
			/// 是否为虚拟商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_virtual")]//) private Nullable<long> isVirtual;
				internal long? isVirtual;

				public virtual long? ItemId
				{
					set
					{
					this.itemId = value;
					}
					get
					{
					return this.itemId;
					}
				}


				public virtual long? KdtId
				{
					set
					{
					this.kdtId = value;
					}
					get
					{
					return this.kdtId;
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


				public virtual string PhotoUrl
				{
					set
					{
					this.photoUrl = value;
					}
					get
					{
					return this.photoUrl;
					}
				}


				public virtual long? Price
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


				public virtual DateTime CreatedAt
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


				public virtual DateTime UpdatedAt
				{
					set
					{
					this.updatedAt = value;
					}
					get
					{
					return this.updatedAt;
					}
				}


				public virtual long? SellStockCount
				{
					set
					{
					this.sellStockCount = value;
					}
					get
					{
					return this.sellStockCount;
					}
				}


				public virtual string DisplayUrl
				{
					set
					{
					this.displayUrl = value;
					}
					get
					{
					return this.displayUrl;
					}
				}


				public virtual long? IsVirtual
				{
					set
					{
					this.isVirtual = value;
					}
					get
					{
					return this.isVirtual;
					}
				}


		}

		public class Paginator
		{


			/// <summary>
			/// 当前页码
			/// </summary>
[Newtonsoft.Json.JsonProperty("page")]//) private Nullable<long> page;
				internal long? page;


			/// <summary>
			/// 分页大小
			/// </summary>
[Newtonsoft.Json.JsonProperty("page_size")]//) private Nullable<long> pageSize;
				internal long? pageSize;


			/// <summary>
			/// 查询结果总数
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_count")]//) private Nullable<long> totalCount;
				internal long? totalCount;

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


				public virtual long? TotalCount
				{
					set
					{
					this.totalCount = value;
					}
					get
					{
					return this.totalCount;
					}
				}


		}


	}
}