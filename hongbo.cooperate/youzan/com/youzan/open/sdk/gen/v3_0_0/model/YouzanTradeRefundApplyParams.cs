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

    public class YouzanTradeRefundApplyParams : APIParams, FileParams
	{

		/// <summary>
		/// 退款说明，备注
		/// </summary>
		private string desc;
		/// <summary>
		/// 手机号
		/// </summary>
		private string mobile;
		/// <summary>
		/// 交易的商品明细编号。
		/// </summary>
		private long? oid;
		/// <summary>
		/// 退款原因，原因列表地址：https://www.youzanyun.com/docs/guide/faq/699
		/// </summary>
		private long? reason;
		/// <summary>
		/// 退款金额
		/// </summary>
		private float? refundFee;
		/// <summary>
		/// 是否退货 false(仅退款) true(退货退款)
		/// </summary>
		private bool? returnGoods;
		/// <summary>
		/// 订单号
		/// </summary>
		private string tid;

		public virtual string Desc
		{
			set
			{
				this.desc = value;
			}
			get
			{
				return this.desc;
			}
		}


		public virtual string Mobile
		{
			set
			{
				this.mobile = value;
			}
			get
			{
				return this.mobile;
			}
		}


		public virtual long? Oid
		{
			set
			{
				this.oid = value;
			}
			get
			{
				return this.oid;
			}
		}


		public virtual long? Reason
		{
			set
			{
				this.reason = value;
			}
			get
			{
				return this.reason;
			}
		}


		public virtual float? RefundFee
		{
			set
			{
				this.refundFee = value;
			}
			get
			{
				return this.refundFee;
			}
		}


		public virtual bool? ReturnGoods
		{
			set
			{
				this.returnGoods = value;
			}
			get
			{
				return this.returnGoods;
			}
		}


		public virtual string Tid
		{
			set
			{
				this.tid = value;
			}
			get
			{
				return this.tid;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(desc, null))
			{
				@params["desc"] = desc;
			}
			if (!string.ReferenceEquals(mobile, null))
			{
				@params["mobile"] = mobile;
			}
			if (oid != null)
			{
				@params["oid"] = oid;
			}
			if (reason != null)
			{
				@params["reason"] = reason;
			}
			if (refundFee != null)
			{
				@params["refund_fee"] = refundFee;
			}
			if (returnGoods != null)
			{
				@params["return_goods"] = returnGoods;
			}
			if (!string.ReferenceEquals(tid, null))
			{
				@params["tid"] = tid;
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