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

    public class YouzanRetailStocksStockinSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 入库单单号
		/// </summary>
		private string businessOrderNo;
		/// <summary>
		/// 结束时间
		/// </summary>
		private string endTime;
		/// <summary>
		/// 入库单类型（TOCK_IN(2, "采购入库单"),STOCK_RETURN(3, "退货入库单")）
		/// </summary>
		private string orderTypes;
		/// <summary>
		/// 查询页面
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 一页数量
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;
		/// <summary>
		/// 开始时间
		/// </summary>
		private string startTime;
		/// <summary>
		/// 供货商id
		/// </summary>
		private long? vendorId;

		public virtual string BusinessOrderNo
		{
			set
			{
				this.businessOrderNo = value;
			}
			get
			{
				return this.businessOrderNo;
			}
		}


		public virtual string EndTime
		{
			set
			{
				this.endTime = value;
			}
			get
			{
				return this.endTime;
			}
		}


		public virtual string OrderTypes
		{
			set
			{
				this.orderTypes = value;
			}
			get
			{
				return this.orderTypes;
			}
		}


		public virtual long? PageNo
		{
			set
			{
				this.pageNo = value;
			}
			get
			{
				return this.pageNo;
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


		public virtual string StartTime
		{
			set
			{
				this.startTime = value;
			}
			get
			{
				return this.startTime;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(businessOrderNo, null))
			{
				@params["business_order_no"] = businessOrderNo;
			}
			if (!string.ReferenceEquals(endTime, null))
			{
				@params["end_time"] = endTime;
			}
			if (!string.ReferenceEquals(orderTypes, null))
			{
				@params["order_types"] = orderTypes;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (!string.ReferenceEquals(startTime, null))
			{
				@params["start_time"] = startTime;
			}
			if (vendorId != null)
			{
				@params["vendor_id"] = vendorId;
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