using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanRetailStockStockoutCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 出库时间
		/// </summary>
		private string businessTime;
		/// <summary>
		/// 幂等单号（请求唯一标识）
		/// </summary>
		private string idempotentNo;
		/// <summary>
		/// 出库备注（备注最长不能超过200字）
		/// </summary>
		private string remark;
		/// <summary>
		/// 来源 外部调用系统唯一标识 OPEN_XXXX
		/// </summary>
		private string source;
		/// <summary>
		/// 出库单明细（需保证sku唯一性）
		/// </summary>
		private string stockOutOrderItems;
		/// <summary>
		/// 出库单类型（  OTHER_OUT_LOSS(43, "其他出库-报损"),
		/// OTHER_OUT_USE(44, "其他出库-领用"),
		/// OTHER_OUT_OTHER(49, "其他出库-其他"),）
		/// </summary>
		private long? stockOutType;

		public virtual string BusinessTime
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


		public virtual string Source
		{
			set
			{
				this.source = value;
			}
			get
			{
				return this.source;
			}
		}


		public virtual string StockOutOrderItems
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


		public virtual long? StockOutType
		{
			set
			{
				this.stockOutType = value;
			}
			get
			{
				return this.stockOutType;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(businessTime, null))
			{
				@params["business_time"] = businessTime;
			}
			if (!string.ReferenceEquals(idempotentNo, null))
			{
				@params["idempotent_no"] = idempotentNo;
			}
			if (!string.ReferenceEquals(remark, null))
			{
				@params["remark"] = remark;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (!string.ReferenceEquals(stockOutOrderItems, null))
			{
				@params["stock_out_order_items"] = stockOutOrderItems;
			}
			if (stockOutType != null)
			{
				@params["stock_out_type"] = stockOutType;
			}
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}