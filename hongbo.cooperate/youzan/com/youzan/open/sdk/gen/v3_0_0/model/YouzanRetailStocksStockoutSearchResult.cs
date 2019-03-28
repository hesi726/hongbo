using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailStocksStockoutSearchResult : APIResult
	{



		/// <summary>
		/// 分页信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
		private Paginator paginator;


		/// <summary>
		/// 出库单详情
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private StockOutOrderVO[] items;
		private StockOutOrderVO[] items;

		public virtual void setPaginator(Paginator paginator)
		{
			this.paginator = paginator;
		}

		public virtual Paginator getPaginator()
		{
			return this.paginator;
		}
		public virtual StockOutOrderVO[] Items
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


		public class StockOutOrderItemVO
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
			/// 数量（千倍）
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

		public class StockOutOrderVO
		{


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 业务时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("business_time")]//) private java.util.Date businessTime;
				internal DateTime businessTime;


			/// <summary>
			/// 业务类型（STOCK_CHECK(1, "库存盘点单"),
			/// STOCK_IN(2, "采购入库单"),
			/// STOCK_RETURN(3, "退货入库单"),
			/// STOCK_OUT(4, "出库单")）
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 操作者id
			/// </summary>
[Newtonsoft.Json.JsonProperty("admin_id")]//) private Nullable<long> adminId;
				internal long? adminId;


			/// <summary>
			/// 业务单据单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("biz_bill_no")]//) private String bizBillNo;
				internal string bizBillNo;


			/// <summary>
			/// 幂等单号（请求唯一标识）
			/// </summary>
[Newtonsoft.Json.JsonProperty("idempotent_no")]//) private String idempotentNo;
				internal string idempotentNo;


			/// <summary>
			/// 用于存储退货入库单关联的订单号（其他单据为业务单号）
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_order_no")]//) private String sourceOrderNo;
				internal string sourceOrderNo;


			/// <summary>
			/// 单据业务类型（  SELL_ONLINE_OUT(41, "网店销售出库"),
			/// SELL_OFFLINE_OUT(42, "门店销售出库"),）
			/// </summary>
[Newtonsoft.Json.JsonProperty("order_biz_type")]//) private Nullable<long> orderBizType;
				internal long? orderBizType;


			/// <summary>
			/// 创建人
			/// </summary>
[Newtonsoft.Json.JsonProperty("create_name")]//) private String createName;
				internal string createName;


			/// <summary>
			/// 操作人
			/// </summary>
[Newtonsoft.Json.JsonProperty("operator_name")]//) private String operatorName;
				internal string operatorName;


			/// <summary>
			/// 备注
			/// </summary>
[Newtonsoft.Json.JsonProperty("remark")]//) private String remark;
				internal string remark;


			/// <summary>
			/// 关联订单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("relation_order_no")]//) private String relationOrderNo;
				internal string relationOrderNo;


			/// <summary>
			/// 出库单详情
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock_out_order_items")]//) private StockOutOrderItemVO[] stockOutOrderItems;
				internal StockOutOrderItemVO[] stockOutOrderItems;

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


				public virtual DateTime BusinessTime
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


				public virtual long? OrderBizType
				{
					set
					{
					this.orderBizType = value;
					}
					get
					{
					return this.orderBizType;
					}
				}


				public virtual string CreateName
				{
					set
					{
					this.createName = value;
					}
					get
					{
					return this.createName;
					}
				}


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


				public virtual string Remark
				{
					set
					{
					this.remark = value;
					}
					get
					{
					return this.remark;
					}
				}


				public virtual string RelationOrderNo
				{
					set
					{
					this.relationOrderNo = value;
					}
					get
					{
					return this.relationOrderNo;
					}
				}


				public virtual StockOutOrderItemVO[] StockOutOrderItems
				{
					set
					{
					this.stockOutOrderItems = value;
					}
					get
					{
					return this.stockOutOrderItems;
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