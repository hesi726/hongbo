using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductsOfflineSearchResult : APIResult
	{



		/// <summary>
		/// 分页信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
		private Paginator paginator;


		/// <summary>
		/// 门店商品搜索结果实体信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private OfflineProductSearchVO items;
		private OfflineProductSearchVO items;

		public virtual void setPaginator(Paginator paginator)
		{
			this.paginator = paginator;
		}

		public virtual Paginator getPaginator()
		{
			return this.paginator;
		}
		public virtual OfflineProductSearchVO Items
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


		public class OfflineProductSearchVO
		{


			/// <summary>
			/// 分类id
			/// </summary>
[Newtonsoft.Json.JsonProperty("category_id")]//) private Nullable<long> categoryId;
				internal long? categoryId;


			/// <summary>
			/// 分类名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("category_name")]//) private String categoryName;
				internal string categoryName;


			/// <summary>
			/// 规格
			/// </summary>
[Newtonsoft.Json.JsonProperty("specifications")]//) private String specifications;
				internal string specifications;


			/// <summary>
			/// 门店商品编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_no")]//) private String skuNo;
				internal string skuNo;


			/// <summary>
			/// 计量方式（0：计数，10：计重）
			/// </summary>
[Newtonsoft.Json.JsonProperty("measurement")]//) private Nullable<long> measurement;
				internal long? measurement;


			/// <summary>
			/// 门店商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 门店商品名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private Nullable<long> title;
				internal long? title;


			/// <summary>
			/// 门店商品单位
			/// </summary>
[Newtonsoft.Json.JsonProperty("unit")]//) private String unit;
				internal string unit;


			/// <summary>
			/// 门店商品图片
			/// </summary>
[Newtonsoft.Json.JsonProperty("photo_url")]//) private String photoUrl;
				internal string photoUrl;


			/// <summary>
			/// 零售价，单位：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private java.util.Date createdAt;
				internal DateTime createdAt;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated_at")]//) private java.util.Date updatedAt;
				internal DateTime updatedAt;


			/// <summary>
			/// 销售库存（实际库存量*1000返回）
			/// </summary>
[Newtonsoft.Json.JsonProperty("sell_stock_count")]//) private Nullable<long> sellStockCount;
				internal long? sellStockCount;

				public virtual long? CategoryId
				{
					set
					{
					this.categoryId = value;
					}
					get
					{
					return this.categoryId;
					}
				}


				public virtual string CategoryName
				{
					set
					{
					this.categoryName = value;
					}
					get
					{
					return this.categoryName;
					}
				}


				public virtual string Specifications
				{
					set
					{
					this.specifications = value;
					}
					get
					{
					return this.specifications;
					}
				}


				public virtual string SkuNo
				{
					set
					{
					this.skuNo = value;
					}
					get
					{
					return this.skuNo;
					}
				}


				public virtual long? Measurement
				{
					set
					{
					this.measurement = value;
					}
					get
					{
					return this.measurement;
					}
				}


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


				public virtual long? Title
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


				public virtual string Unit
				{
					set
					{
					this.unit = value;
					}
					get
					{
					return this.unit;
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