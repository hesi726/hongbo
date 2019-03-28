namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailStockStockreturnGetResult : APIResult
	{



		/// <summary>
		/// 退货入库详情
		/// </summary>
[Newtonsoft.Json.JsonProperty("stock_return_complex_vo")]//) private StockReturnComplexVO stockReturnComplexVo;
		private StockReturnComplexVO stockReturnComplexVo;

		public virtual StockReturnComplexVO StockReturnComplexVo
		{
			set
			{
				this.stockReturnComplexVo = value;
			}
			get
			{
				return this.stockReturnComplexVo;
			}
		}


		public class StockReturnOrderItemVO
		{


			/// <summary>
			/// 关联退货单编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_no")]//) private String sourceNo;
				internal string sourceNo;


			/// <summary>
			/// 业务单据单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("biz_bill_no")]//) private String bizBillNo;
				internal string bizBillNo;


			/// <summary>
			/// 实际入库数量（千倍）
			/// </summary>
[Newtonsoft.Json.JsonProperty("amount")]//) private Nullable<long> amount;
				internal long? amount;


			/// <summary>
			/// 退货数量（千倍）  returnAmount= amount + ossAmount
			/// </summary>
[Newtonsoft.Json.JsonProperty("return_amount")]//) private Nullable<long> returnAmount;
				internal long? returnAmount;


			/// <summary>
			/// 成本价小计
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_cost")]//) private Nullable<long> totalCost;
				internal long? totalCost;


			/// <summary>
			/// 商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// 业务类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 规格信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("specifications")]//) private String specifications;
				internal string specifications;


			/// <summary>
			/// 商品名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("product_name")]//) private String productName;
				internal string productName;


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 单位
			/// </summary>
[Newtonsoft.Json.JsonProperty("unit")]//) private String unit;
				internal string unit;


			/// <summary>
			/// 商品条码
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_no")]//) private String skuNo;
				internal string skuNo;


			/// <summary>
			/// 破损数量（千倍）
			/// </summary>
[Newtonsoft.Json.JsonProperty("loss_amount")]//) private Nullable<long> lossAmount;
				internal long? lossAmount;


			/// <summary>
			/// 操作者id
			/// </summary>
[Newtonsoft.Json.JsonProperty("admin_id")]//) private Nullable<long> adminId;
				internal long? adminId;


			/// <summary>
			/// 成本单价
			/// </summary>
[Newtonsoft.Json.JsonProperty("unit_cost")]//) private Nullable<long> unitCost;
				internal long? unitCost;

				public virtual string SourceNo
				{
					set
					{
					this.sourceNo = value;
					}
					get
					{
					return this.sourceNo;
					}
				}


				public virtual string BizBillNo
				{
					set
					{
					this.bizBillNo = value;
					}
					get
					{
					return this.bizBillNo;
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


				public virtual long? ReturnAmount
				{
					set
					{
					this.returnAmount = value;
					}
					get
					{
					return this.returnAmount;
					}
				}


				public virtual long? TotalCost
				{
					set
					{
					this.totalCost = value;
					}
					get
					{
					return this.totalCost;
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


				public virtual long? Type
				{
					set
					{
					this.type = value;
					}
					get
					{
					return this.type;
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


				public virtual long? LossAmount
				{
					set
					{
					this.lossAmount = value;
					}
					get
					{
					return this.lossAmount;
					}
				}


				public virtual long? AdminId
				{
					set
					{
					this.adminId = value;
					}
					get
					{
					return this.adminId;
					}
				}


				public virtual long? UnitCost
				{
					set
					{
					this.unitCost = value;
					}
					get
					{
					return this.unitCost;
					}
				}


		}

		public class StockReturnComplexVO
		{


			/// <summary>
			/// 操作员工名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("operator_name")]//) private String operatorName;
				internal string operatorName;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private Nullable<long> createdAt;
				internal long? createdAt;


			/// <summary>
			/// 业务单据单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("biz_bill_no")]//) private String bizBillNo;
				internal string bizBillNo;


			/// <summary>
			/// 幂等单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("idempotent_no")]//) private String idempotentNo;
				internal string idempotentNo;


			/// <summary>
			/// 业务时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("business_time")]//) private Nullable<long> businessTime;
				internal long? businessTime;


			/// <summary>
			/// 退货单维度库存数据
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock_return_orders")]//) private StockReturnItemComplexVO[] stockReturnOrders;
				internal StockReturnItemComplexVO[] stockReturnOrders;


			/// <summary>
			/// 业务类型（STOCK_CHECK(1, "库存盘点单"),
			/// STOCK_IN(2, "采购入库单"),
			/// STOCK_RETURN(3, "退货入库单"),
			/// STOCK_OUT(4, "出库单")）
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 原单号--记录订单数据（其他单据为业务单号）
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_order_no")]//) private String sourceOrderNo;
				internal string sourceOrderNo;


			/// <summary>
			/// 商家id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated_at")]//) private Nullable<long> updatedAt;
				internal long? updatedAt;


			/// <summary>
			/// 操作者id
			/// </summary>
[Newtonsoft.Json.JsonProperty("admin_id")]//) private Nullable<long> adminId;
				internal long? adminId;


			/// <summary>
			/// 状态
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
				internal long? status;

				public virtual string OperatorName
				{
					set
					{
					this.operatorName = value;
					}
					get
					{
					return this.operatorName;
					}
				}


				public virtual long? CreatedAt
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


				public virtual string BizBillNo
				{
					set
					{
					this.bizBillNo = value;
					}
					get
					{
					return this.bizBillNo;
					}
				}


				public virtual string IdempotentNo
				{
					set
					{
					this.idempotentNo = value;
					}
					get
					{
					return this.idempotentNo;
					}
				}


				public virtual long? BusinessTime
				{
					set
					{
					this.businessTime = value;
					}
					get
					{
					return this.businessTime;
					}
				}


				public virtual StockReturnItemComplexVO[] StockReturnOrders
				{
					set
					{
					this.stockReturnOrders = value;
					}
					get
					{
					return this.stockReturnOrders;
					}
				}


				public virtual long? Type
				{
					set
					{
					this.type = value;
					}
					get
					{
					return this.type;
					}
				}


				public virtual string SourceOrderNo
				{
					set
					{
					this.sourceOrderNo = value;
					}
					get
					{
					return this.sourceOrderNo;
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


				public virtual long? UpdatedAt
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


				public virtual long? AdminId
				{
					set
					{
					this.adminId = value;
					}
					get
					{
					return this.adminId;
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


		}

		public class StockReturnItemComplexVO
		{


			/// <summary>
			/// 退货单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_order_no")]//) private String sourceOrderNo;
				internal string sourceOrderNo;


			/// <summary>
			/// 退货入库单明细
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock_return_orders")]//) private StockReturnOrderItemVO[] stockReturnOrders;
				internal StockReturnOrderItemVO[] stockReturnOrders;

				public virtual string SourceOrderNo
				{
					set
					{
					this.sourceOrderNo = value;
					}
					get
					{
					return this.sourceOrderNo;
					}
				}


				public virtual StockReturnOrderItemVO[] StockReturnOrders
				{
					set
					{
					this.stockReturnOrders = value;
					}
					get
					{
					return this.stockReturnOrders;
					}
				}


		}


	}
}