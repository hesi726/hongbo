namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailStocksStockinSearchResult : APIResult
	{



		/// <summary>
		/// 分页信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
		private Paginator paginator;


		/// <summary>
		/// 入库单详细信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private StockInOrderItemVO[] items;
		private StockInOrderItemVO[] items;

		public virtual void setPaginator(Paginator paginator)
		{
			this.paginator = paginator;
		}

		public virtual Paginator getPaginator()
		{
			return this.paginator;
		}
		public virtual StockInOrderItemVO[] Items
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


		public class StockInOrderItemVO
		{


			/// <summary>
			/// 商品名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("product_name")]//) private String productName;
				internal string productName;


			/// <summary>
			/// 规格描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("specifications")]//) private String specifications;
				internal string specifications;


			/// <summary>
			/// 条码
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_no")]//) private String skuNo;
				internal string skuNo;


			/// <summary>
			/// 单位
			/// </summary>
[Newtonsoft.Json.JsonProperty("unit")]//) private String unit;
				internal string unit;


			/// <summary>
			/// 数量（一千倍）
			/// </summary>
[Newtonsoft.Json.JsonProperty("amount")]//) private Nullable<long> amount;
				internal long? amount;

				public virtual string ProductName
				{
					set
					{
					this.productName = value;
					}
					get
					{
					return this.productName;
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


				public virtual long? Amount
				{
					set
					{
					this.amount = value;
					}
					get
					{
					return this.amount;
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