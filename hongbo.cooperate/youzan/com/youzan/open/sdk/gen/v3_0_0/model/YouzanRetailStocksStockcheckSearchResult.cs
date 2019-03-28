namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailStocksStockcheckSearchResult : APIResult
	{



		/// <summary>
		/// 分页信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("paginator")]//) private Paginator paginator;
		private Paginator paginator;


		/// <summary>
		/// 实体信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private StockCheckVO[] items;
		private StockCheckVO[] items;

		public virtual void setPaginator(Paginator paginator)
		{
			this.paginator = paginator;
		}

		public virtual Paginator getPaginator()
		{
			return this.paginator;
		}
		public virtual StockCheckVO[] Items
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


		public class StockCheckVO
		{


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
			/// 盘点时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("business_time")]//) private Nullable<long> businessTime;
				internal long? businessTime;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private Nullable<long> createdAt;
				internal long? createdAt;


			/// <summary>
			/// 备注
			/// </summary>
[Newtonsoft.Json.JsonProperty("remark")]//) private String remark;
				internal string remark;


			/// <summary>
			/// 业务类型（STOCK_CHECK(1, "库存盘点单"),
			/// STOCK_IN(2, "采购入库单"),
			/// STOCK_RETURN(3, "退货入库单"),
			/// STOCK_OUT(4, "出库单")）
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 退货入库单用于记录关联订单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("source_order_no")]//) private String sourceOrderNo;
				internal string sourceOrderNo;


			/// <summary>
			/// 员工名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("operator_name")]//) private String operatorName;
				internal string operatorName;


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated_at")]//) private Nullable<long> updatedAt;
				internal long? updatedAt;


			/// <summary>
			/// 员工id
			/// </summary>
[Newtonsoft.Json.JsonProperty("admin_id")]//) private Nullable<long> adminId;
				internal long? adminId;


			/// <summary>
			/// 状态（DOING(1, "待处理"),
			/// DONE(2, "处理成功"),
			/// FAIL(3, "处理失败")）
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
				internal long? status;

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