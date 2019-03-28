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

    public class YouzanRetailStocksStockoutSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 业务操作人id
		/// </summary>
		private long? bizOperatorId;
		/// <summary>
		/// 出库单单号
		/// </summary>
		private string businessOrderNo;
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
		/// 是否展示子信息
		/// </summary>
		private bool? showItem;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;
		/// <summary>
		/// 开始时间
		/// </summary>
		private string startTime;
		/// <summary>
		/// 出库单类型（41, "网店销售出库",
		/// 42, "门店销售出库",  43, "其他出库-报损",44, "其他出库-领用",49, "其他出库-其他"）
		/// </summary>
		private string stockOutTypes;

		public virtual long? BizOperatorId
		{
			set
			{
				this.bizOperatorId = value;
			}
			get
			{
				return this.bizOperatorId;
			}
		}


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


		public virtual bool? ShowItem
		{
			set
			{
				this.showItem = value;
			}
			get
			{
				return this.showItem;
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


		public virtual string StockOutTypes
		{
			set
			{
				this.stockOutTypes = value;
			}
			get
			{
				return this.stockOutTypes;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (bizOperatorId != null)
			{
				@params["biz_operator_id"] = bizOperatorId;
			}
			if (!string.ReferenceEquals(businessOrderNo, null))
			{
				@params["business_order_no"] = businessOrderNo;
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
			if (showItem != null)
			{
				@params["show_item"] = showItem;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (!string.ReferenceEquals(startTime, null))
			{
				@params["start_time"] = startTime;
			}
			if (!string.ReferenceEquals(stockOutTypes, null))
			{
				@params["stock_out_types"] = stockOutTypes;
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