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

    public class YouzanPayAccountingSummaryDetailGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 账户编号
		/// </summary>
		private string acctNo;
		/// <summary>
		/// 账单汇总编号
		/// </summary>
		private string summaryNo;

		public virtual string AcctNo
		{
			set
			{
				this.acctNo = value;
			}
			get
			{
				return this.acctNo;
			}
		}


		public virtual string SummaryNo
		{
			set
			{
				this.summaryNo = value;
			}
			get
			{
				return this.summaryNo;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(acctNo, null))
			{
				@params["acct_no"] = acctNo;
			}
			if (!string.ReferenceEquals(summaryNo, null))
			{
				@params["summary_no"] = summaryNo;
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