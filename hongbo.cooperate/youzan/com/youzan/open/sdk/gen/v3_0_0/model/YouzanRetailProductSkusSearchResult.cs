using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductSkusSearchResult : APIResult
	{



		/// <summary>
		/// 分页信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
		private Paginator paginator;


		/// <summary>
		/// 实体对象
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private SkuCenterSearchVO[] items;
		private SkuCenterSearchVO[] items;

		public virtual void setPaginator(Paginator paginator)
		{
			this.paginator = paginator;
		}

		public virtual Paginator getPaginator()
		{
			return this.paginator;
		}
		public virtual SkuCenterSearchVO[] Items
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


		public class SkuCenterSearchVO
		{


			/// <summary>
			/// 商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("skuId")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// 关联的商户id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdtId")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 分类id
			/// </summary>
[Newtonsoft.Json.JsonProperty("categoryId")]//) private Nullable<long> categoryId;
				internal long? categoryId;


			/// <summary>
			/// 分类名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("categoryName")]//) private String categoryName;
				internal string categoryName;


			/// <summary>
			/// 名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 规格
			/// </summary>
[Newtonsoft.Json.JsonProperty("specifications")]//) private String specifications;
				internal string specifications;


			/// <summary>
			/// 状态
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
				internal long? status;


			/// <summary>
			/// 图片地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("photoUrl")]//) private String photoUrl;
				internal string photoUrl;


			/// <summary>
			/// 单位
			/// </summary>
[Newtonsoft.Json.JsonProperty("unit")]//) private String unit;
				internal string unit;


			/// <summary>
			/// 编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("skuNo")]//) private String skuNo;
				internal string skuNo;


			/// <summary>
			/// 最后一次入库成本价
			/// </summary>
[Newtonsoft.Json.JsonProperty("lastCostPrice")]//) private Nullable<long> lastCostPrice;
				internal long? lastCostPrice;


			/// <summary>
			/// 平均成本价
			/// </summary>
[Newtonsoft.Json.JsonProperty("avgCostPrice")]//) private Nullable<long> avgCostPrice;
				internal long? avgCostPrice;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("createdAt")]//) private java.util.Date createdAt;
				internal DateTime createdAt;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updatedAt")]//) private java.util.Date updatedAt;
				internal DateTime updatedAt;


			/// <summary>
			/// 销售渠道：1 未设置，2门店 4 网店 6 门店+网店
			/// </summary>
[Newtonsoft.Json.JsonProperty("sellChannel")]//) private Nullable<long> sellChannel;
				internal long? sellChannel;


			/// <summary>
			/// 库存数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("stockNum")]//) private Nullable<long> stockNum;
				internal long? stockNum;


			/// <summary>
			/// 超卖数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("overSoldNum")]//) private Nullable<long> overSoldNum;
				internal long? overSoldNum;


			/// <summary>
			/// 销售库存
			/// </summary>
[Newtonsoft.Json.JsonProperty("sellStockCount")]//) private Nullable<long> sellStockCount;
				internal long? sellStockCount;

				public virtual long? SkuId
				{
					set
					{
					this.skuId = value;
					}
					get
					{
					return this.skuId;
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


				public virtual long? Status
				{
					set
					{
					this.status = value;
					}
					get
					{
					return this.status;
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


				public virtual long? LastCostPrice
				{
					set
					{
					this.lastCostPrice = value;
					}
					get
					{
					return this.lastCostPrice;
					}
				}


				public virtual long? AvgCostPrice
				{
					set
					{
					this.avgCostPrice = value;
					}
					get
					{
					return this.avgCostPrice;
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


				public virtual long? SellChannel
				{
					set
					{
					this.sellChannel = value;
					}
					get
					{
					return this.sellChannel;
					}
				}


				public virtual long? StockNum
				{
					set
					{
					this.stockNum = value;
					}
					get
					{
					return this.stockNum;
					}
				}


				public virtual long? OverSoldNum
				{
					set
					{
					this.overSoldNum = value;
					}
					get
					{
					return this.overSoldNum;
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