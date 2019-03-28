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

    public class YouzanTradeRefundModifyParams : APIParams, FileParams
	{

		/// <summary>
		/// 退款说明，备注
		/// </summary>
		private string desc;
		/// <summary>
		/// 退款原因，原因列表地址：https://www.youzanyun.com/docs/guide/faq/699
		/// </summary>
		private long? reason;
		/// <summary>
		/// 退款金额
		/// </summary>
		private float? refundFee;
		/// <summary>
		/// 退款ID
		/// </summary>
		private string refundId;
		/// <summary>
		/// false(仅退款) true(退货退款)
		/// </summary>
		private bool? returnGoods;
		/// 
		private long? version;

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
			if (!string.ReferenceEquals(desc, null))
			{
				@params["desc"] = desc;
			}
			if (reason != null)
			{
				@params["reason"] = reason;
			}
			if (refundFee != null)
			{
				@params["refund_fee"] = refundFee;
			}
			if (!string.ReferenceEquals(refundId, null))
			{
				@params["refund_id"] = refundId;
			}
			if (returnGoods != null)
			{
				@params["return_goods"] = returnGoods;
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