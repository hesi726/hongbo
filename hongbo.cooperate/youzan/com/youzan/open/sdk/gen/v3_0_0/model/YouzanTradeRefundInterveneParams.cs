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

    public class YouzanTradeRefundInterveneParams : APIParams, FileParams
	{

		/// <summary>
		/// 退款ID
		/// </summary>
		private string refundId;
		/// <summary>
		/// 申请理由
		/// </summary>
		private string remark;
		/// <summary>
		/// 退款版本
		/// </summary>
		private long? version;

		public virtual string RefundId
		{
			set
			{
				this.refundId = value;
			}
			get
			{
				return this.refundId;
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


		public virtual long? Version
		{
			set
			{
				this.version = value;
			}
			get
			{
				return this.version;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(refundId, null))
			{
				@params["refund_id"] = refundId;
			}
			if (!string.ReferenceEquals(remark, null))
			{
				@params["remark"] = remark;
			}
			if (version != null)
			{
				@params["version"] = version;
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