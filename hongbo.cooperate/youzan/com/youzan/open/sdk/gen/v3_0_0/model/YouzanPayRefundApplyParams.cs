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

    public class YouzanPayRefundApplyParams : APIParams, FileParams
	{

		/// <summary>
		/// 收单号
		/// </summary>
		private string acquireNo;
		/// <summary>
		/// 商户退款单号
		/// </summary>
		private string outBizNo;
		/// <summary>
		/// 退款金额
		/// </summary>
		private long? refundAmount;

		public virtual string AcquireNo
		{
			set
			{
				this.acquireNo = value;
			}
			get
			{
				return this.acquireNo;
			}
		}


		public virtual string OutBizNo
		{
			set
			{
				this.outBizNo = value;
			}
			get
			{
				return this.outBizNo;
			}
		}


		public virtual long? RefundAmount
		{
			set
			{
				this.refundAmount = value;
			}
			get
			{
				return this.refundAmount;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(acquireNo, null))
			{
				@params["acquire_no"] = acquireNo;
			}
			if (!string.ReferenceEquals(outBizNo, null))
			{
				@params["out_biz_no"] = outBizNo;
			}
			if (refundAmount != null)
			{
				@params["refund_amount"] = refundAmount;
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