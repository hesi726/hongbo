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

    public class YouzanRetailStockStockcheckCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 盘点时间
		/// </summary>
		private string businessTime;
		/// <summary>
		/// 幂等单号（请求唯一标识）
		/// </summary>
		private string idempotentNo;
		/// <summary>
		/// 是否完成盘点（默认false）
		/// </summary>
		private bool? isFinish;
		/// <summary>
		/// 操作人名称
		/// </summary>
		private string operatorName;
		/// <summary>
		/// 备注（备注最长不能超过200字）
		/// </summary>
		private string remark;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;
		/// <summary>
		/// 盘点明细（需保证sku唯一性）
		/// </summary>
		private string stockCheckCreateItems;

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


		public virtual bool? IsFinish
		{
			set
			{
				this.isFinish = value;
			}
			get
			{
				return this.isFinish;
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


		public virtual string StockCheckCreateItems
		{
			set
			{
				this.stockCheckCreateItems = value;
			}
			get
			{
				return this.stockCheckCreateItems;
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
			if (isFinish != null)
			{
				@params["is_finish"] = isFinish;
			}
			if (!string.ReferenceEquals(operatorName, null))
			{
				@params["operator_name"] = operatorName;
			}
			if (!string.ReferenceEquals(remark, null))
			{
				@params["remark"] = remark;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (!string.ReferenceEquals(stockCheckCreateItems, null))
			{
				@params["stock_check_create_items"] = stockCheckCreateItems;
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