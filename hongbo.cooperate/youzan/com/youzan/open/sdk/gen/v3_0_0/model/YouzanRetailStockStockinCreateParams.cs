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

    public class YouzanRetailStockStockinCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 采购入库时间
		/// </summary>
		private string businessTime;
		/// <summary>
		/// 幂等单号（请求唯一标示）
		/// </summary>
		private string idempotentNo;
		/// <summary>
		/// 入库备注（备注最长不能超过200字）
		/// </summary>
		private string remark;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;
		/// <summary>
		/// 入库明细（需保证sku唯一性）
		/// </summary>
		private string stockInOrderItems;
		/// <summary>
		/// 供应商id
		/// </summary>
		private long? vendorId;
		/// <summary>
		/// 供应商名称
		/// </summary>
		private string vendorName;

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


		public virtual string StockInOrderItems
		{
			set
			{
				this.stockInOrderItems = value;
			}
			get
			{
				return this.stockInOrderItems;
			}
		}


		public virtual long? VendorId
		{
			set
			{
				this.vendorId = value;
			}
			get
			{
				return this.vendorId;
			}
		}


		public virtual string VendorName
		{
			set
			{
				this.vendorName = value;
			}
			get
			{
				return this.vendorName;
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
			if (!string.ReferenceEquals(stockInOrderItems, null))
			{
				@params["stock_in_order_items"] = stockInOrderItems;
			}
			if (vendorId != null)
			{
				@params["vendor_id"] = vendorId;
			}
			if (!string.ReferenceEquals(vendorName, null))
			{
				@params["vendor_name"] = vendorName;
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