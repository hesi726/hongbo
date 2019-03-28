using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductSkuGetResult : APIResult
	{



		/// <summary>
		/// 商品库商品实体类
		/// </summary>
[Newtonsoft.Json.JsonProperty("sku_center_vo")]//) private SkuCenterVO skuCenterVo;
		private SkuCenterVO skuCenterVo;

		public virtual SkuCenterVO SkuCenterVo
		{
			set
			{
				this.skuCenterVo = value;
			}
			get
			{
				return this.skuCenterVo;
			}
		}


		public class SkuCenterVO
		{


			/// <summary>
			/// 销售渠道
			/// </summary>
[Newtonsoft.Json.JsonProperty("sell_channel")]//) private Nullable<long> sellChannel;
				internal long? sellChannel;


			/// <summary>
			/// 商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 分类id
			/// </summary>
[Newtonsoft.Json.JsonProperty("category_id")]//) private Nullable<long> categoryId;
				internal long? categoryId;


			/// <summary>
			/// 商品名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 商品规格
			/// </summary>
[Newtonsoft.Json.JsonProperty("specifications")]//) private String specifications;
				internal string specifications;


			/// <summary>
			/// 商品图片
			/// </summary>
[Newtonsoft.Json.JsonProperty("photo_url")]//) private String photoUrl;
				internal string photoUrl;


			/// <summary>
			/// 商品编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_no")]//) private String skuNo;
				internal string skuNo;


			/// <summary>
			/// 单位名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("unit")]//) private String unit;
				internal string unit;


			/// <summary>
			/// 商品状态
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
				internal long? status;


			/// <summary>
			/// 最后一次入库成本价
			/// </summary>
[Newtonsoft.Json.JsonProperty("last_cost_price")]//) private Nullable<long> lastCostPrice;
				internal long? lastCostPrice;


			/// <summary>
			/// 平均成本价
			/// </summary>
[Newtonsoft.Json.JsonProperty("avg_cost_price")]//) private Nullable<long> avgCostPrice;
				internal long? avgCostPrice;


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
			/// 实物库存
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock_num")]//) private Nullable<long> stockNum;
				internal long? stockNum;


			/// <summary>
			/// 可售库存
			/// </summary>
[Newtonsoft.Json.JsonProperty("sell_stock_count")]//) private Nullable<long> sellStockCount;
				internal long? sellStockCount;


			/// <summary>
			/// 版本号
			/// </summary>
[Newtonsoft.Json.JsonProperty("version")]//) private Nullable<long> version;
				internal long? version;

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


				public virtual long? Version
				{
					set
					{
					this.version = value;
					}
					get
					{
					return this.version;
					}
				}


		}


	}
}