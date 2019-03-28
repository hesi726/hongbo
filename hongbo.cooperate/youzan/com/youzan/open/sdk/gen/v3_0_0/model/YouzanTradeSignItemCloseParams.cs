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

    public class YouzanTradeSignItemCloseParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品交易编号
		/// </summary>
		private string oid;
		/// <summary>
		/// 退款金额
		/// </summary>
		private float? refundAmt;
		/// <summary>
		/// 交易订单号
		/// </summary>
		private string tid;

		public virtual string Oid
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


		public virtual float? RefundAmt
		{
			set
			{
				this.refundAmt = value;
			}
			get
			{
				return this.refundAmt;
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
			if (!string.ReferenceEquals(oid, null))
			{
				@params["oid"] = oid;
			}
			if (refundAmt != null)
			{
				@params["refund_amt"] = refundAmt;
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