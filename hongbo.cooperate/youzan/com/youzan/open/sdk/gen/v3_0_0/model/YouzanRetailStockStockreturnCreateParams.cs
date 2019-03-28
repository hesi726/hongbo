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

    public class YouzanRetailStockStockreturnCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 幂等单号(请求唯一标识)
		/// </summary>
		private string idempotentNo;
		/// <summary>
		/// 是否将库存盘点成0，默认false不盘点
		/// </summary>
		private bool? isNeedPd;
		/// <summary>
		/// 入库备注
		/// </summary>
		private string remark;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;
		/// <summary>
		/// 退货单明细
		/// </summary>
		private string stockReturnOrderItems;

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


		public virtual bool? IsNeedPd
		{
			set
			{
				this.isNeedPd = value;
			}
			get
			{
				return this.isNeedPd;
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


		public virtual string StockReturnOrderItems
		{
			set
			{
				this.stockReturnOrderItems = value;
			}
			get
			{
				return this.stockReturnOrderItems;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(idempotentNo, null))
			{
				@params["idempotent_no"] = idempotentNo;
			}
			if (isNeedPd != null)
			{
				@params["is_need_pd"] = isNeedPd;
			}
			if (!string.ReferenceEquals(remark, null))
			{
				@params["remark"] = remark;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (!string.ReferenceEquals(stockReturnOrderItems, null))
			{
				@params["stock_return_order_items"] = stockReturnOrderItems;
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