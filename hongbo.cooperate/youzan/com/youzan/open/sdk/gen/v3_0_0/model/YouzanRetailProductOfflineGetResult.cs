using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductOfflineGetResult : APIResult
	{



		/// <summary>
		/// 门店商品详情
		/// </summary>
[Newtonsoft.Json.JsonProperty("offline_vo")]//) private OfflineProductVO offlineVo;
		private OfflineProductVO offlineVo;

		public virtual OfflineProductVO OfflineVo
		{
			set
			{
				this.offlineVo = value;
			}
			get
			{
				return this.offlineVo;
			}
		}


		public class OfflineProductVO
		{


			/// <summary>
			/// ic中的商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 商品库中的商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_center_id")]//) private Nullable<long> skuCenterId;
				internal long? skuCenterId;


			/// <summary>
			/// 关联商户id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 分类id
			/// </summary>
[Newtonsoft.Json.JsonProperty("category_id")]//) private Nullable<long> categoryId;
				internal long? categoryId;


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
			/// 图片地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("photo_url")]//) private String photoUrl;
				internal string photoUrl;


			/// <summary>
			/// 编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_no")]//) private String skuNo;
				internal string skuNo;


			/// <summary>
			/// 单位
			/// </summary>
[Newtonsoft.Json.JsonProperty("unit")]//) private String unit;
				internal string unit;


			/// <summary>
			/// 计量方式
			/// </summary>
[Newtonsoft.Json.JsonProperty("measurement")]//) private Nullable<long> measurement;
				internal long? measurement;


			/// <summary>
			/// 最后一次入库成本价(保留两位小数，实际传参*100后传入，如实际最后一次入库成本价2.22，实际传参为222)
			/// </summary>
[Newtonsoft.Json.JsonProperty("last_cost_price")]//) private Nullable<long> lastCostPrice;
				internal long? lastCostPrice;


			/// <summary>
			/// 平均成本价零售价(保留两位小数，实际传参*100后传入，如实际平均成本价2.22，实际传参为222)
			/// </summary>
[Newtonsoft.Json.JsonProperty("avg_cost_price")]//) private Nullable<long> avgCostPrice;
				internal long? avgCostPrice;


			/// <summary>
			/// 零售价(保留两位小数，实际传参*100后传入，如实际零售价2.22，实际传参为222)
			/// </summary>
[Newtonsoft.Json.JsonProperty("retail_price")]//) private Nullable<long> retailPrice;
				internal long? retailPrice;


			/// <summary>
			/// 可售库存(保留三位小数，实际传参*1000后传入，如实际库存1.111，实际传参为1111)
			/// </summary>
[Newtonsoft.Json.JsonProperty("sell_stock_count")]//) private Nullable<long> sellStockCount;
				internal long? sellStockCount;


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

				public virtual long? Id
				{
					set
					{
					this.id = value;
					}
					get
					{
					return this.id;
					}
				}


				public virtual long? SkuCenterId
				{
					set
					{
					this.skuCenterId = value;
					}
					get
					{
					return this.skuCenterId;
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


				public virtual long? RetailPrice
				{
					set
					{
					this.retailPrice = value;
					}
					get
					{
					return this.retailPrice;
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


		}


	}
}