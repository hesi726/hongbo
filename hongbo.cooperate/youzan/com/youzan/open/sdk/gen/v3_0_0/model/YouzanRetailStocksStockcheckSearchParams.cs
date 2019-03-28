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

    public class YouzanRetailStocksStockcheckSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 盘点单单号
		/// </summary>
		private string businessOrderNo;
		/// <summary>
		/// 盘点单状态（CHECKING(1, "盘点中"), DONE(2, "已完成"), CANCEL(3, "已作废")）
		/// </summary>
		private string checkOrderStatus;
		/// <summary>
		/// 结束时间
		/// </summary>
		private string endTime;
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


		public virtual string CheckOrderStatus
		{
			set
			{
				this.checkOrderStatus = value;
			}
			get
			{
				return this.checkOrderStatus;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(businessOrderNo, null))
			{
				@params["business_order_no"] = businessOrderNo;
			}
			if (!string.ReferenceEquals(checkOrderStatus, null))
			{
				@params["check_order_status"] = checkOrderStatus;
			}
			if (!string.ReferenceEquals(endTime, null))
			{
				@params["end_time"] = endTime;
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
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}