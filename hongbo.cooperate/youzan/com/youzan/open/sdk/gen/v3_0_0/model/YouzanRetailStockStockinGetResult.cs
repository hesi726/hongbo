namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailStockStockinGetResult : APIResult
	{



		/// <summary>
		/// 入库单实体信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("stock_in_order_vo")]//) private StockInOrderItemVO stockInOrderVo;
		private StockInOrderItemVO stockInOrderVo;

		public virtual StockInOrderItemVO StockInOrderVo
		{
			set
			{
				this.stockInOrderVo = value;
			}
			get
			{
				return this.stockInOrderVo;
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


	}
}