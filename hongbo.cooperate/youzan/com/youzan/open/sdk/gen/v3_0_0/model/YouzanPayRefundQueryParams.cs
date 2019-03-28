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

    public class YouzanPayRefundQueryParams : APIParams, FileParams
	{

		/// <summary>
		/// 收单号:调用收单创建接口时返回的收单号,长度为32
		/// </summary>
		private string acquireNo;
		/// <summary>
		/// 商户号
		/// </summary>
		private string mchId;
		/// <summary>
		/// 商户的退款单号
		/// </summary>
		private string outBizNo;

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


		public virtual string MchId
		{
			set
			{
				this.mchId = value;
			}
			get
			{
				return this.mchId;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(acquireNo, null))
			{
				@params["acquire_no"] = acquireNo;
			}
			if (!string.ReferenceEquals(mchId, null))
			{
				@params["mch_id"] = mchId;
			}
			if (!string.ReferenceEquals(outBizNo, null))
			{
				@params["out_biz_no"] = outBizNo;
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