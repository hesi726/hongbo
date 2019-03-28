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

    public class YouzanPaySettleParams : APIParams, FileParams
	{

		/// <summary>
		/// 收单号:调用支付接口返回的收单号acquireNo,长度为32
		/// </summary>
		private string acquireNo;
		/// <summary>
		/// 订单对应的交易金额,必须大于0
		/// </summary>
		private long? amount;
		/// <summary>
		/// 币种，如人民币:CNY,长度为8
		/// </summary>
		private string currencyCode;
		/// <summary>
		/// 订单号，业务接入系统的订单号，长度32
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


		public virtual long? Amount
		{
			set
			{
				this.amount = value;
			}
			get
			{
				return this.amount;
			}
		}


		public virtual string CurrencyCode
		{
			set
			{
				this.currencyCode = value;
			}
			get
			{
				return this.currencyCode;
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
			if (amount != null)
			{
				@params["amount"] = amount;
			}
			if (!string.ReferenceEquals(currencyCode, null))
			{
				@params["currency_code"] = currencyCode;
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