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

    public class YouzanRetailStockSellOutParams : APIParams, FileParams
	{

		/// <summary>
		/// 业务单号
		/// </summary>
		private string bizBillNo;
		/// <summary>
		/// 业务类型（4： "出库单"）
		/// </summary>
		private long? businessOrderType;
		/// <summary>
		/// 幂等单号
		/// </summary>
		private string idempotentNo;
		/// <summary>
		/// 变更明细（需保证sku唯一性）
		/// </summary>
		private string items;
		/// <summary>
		/// 库存增/减（1,"增加"；2,"减少"）
		/// </summary>
		private long? operateType;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;

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


		public virtual long? BusinessOrderType
		{
			set
			{
				this.businessOrderType = value;
			}
			get
			{
				return this.businessOrderType;
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


		public virtual string Items
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


		public virtual long? OperateType
		{
			set
			{
				this.operateType = value;
			}
			get
			{
				return this.operateType;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(bizBillNo, null))
			{
				@params["biz_bill_no"] = bizBillNo;
			}
			if (businessOrderType != null)
			{
				@params["business_order_type"] = businessOrderType;
			}
			if (!string.ReferenceEquals(idempotentNo, null))
			{
				@params["idempotent_no"] = idempotentNo;
			}
			if (!string.ReferenceEquals(items, null))
			{
				@params["items"] = items;
			}
			if (operateType != null)
			{
				@params["operate_type"] = operateType;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
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