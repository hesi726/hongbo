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

    public class YouzanRetailStockUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 来源
		/// </summary>
		private string source;
		/// <summary>
		/// 库存增/减（1,"增加"；2,"减少"）
		/// </summary>
		private long? operateType;
		/// <summary>
		/// 变更明细
		/// </summary>
		private string items;
		/// <summary>
		/// 幂等单号
		/// </summary>
		private string idempotentNo;
		/// <summary>
		/// 业务类型（  1： "库存盘点单",2："采购入库单",3： "退货入库单",4： "出库单"）
		/// </summary>
		private long? businessOrderType;
		/// <summary>
		/// 业务单号
		/// </summary>
		private string bizBillNo;

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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (operateType != null)
			{
				@params["operate_type"] = operateType;
			}
			if (!string.ReferenceEquals(items, null))
			{
				@params["items"] = items;
			}
			if (!string.ReferenceEquals(idempotentNo, null))
			{
				@params["idempotent_no"] = idempotentNo;
			}
			if (businessOrderType != null)
			{
				@params["business_order_type"] = businessOrderType;
			}
			if (!string.ReferenceEquals(bizBillNo, null))
			{
				@params["biz_bill_no"] = bizBillNo;
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