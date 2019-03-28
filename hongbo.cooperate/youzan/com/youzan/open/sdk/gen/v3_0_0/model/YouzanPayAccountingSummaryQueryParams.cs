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

    public class YouzanPayAccountingSummaryQueryParams : APIParams, FileParams
	{

		/// <summary>
		/// 账户号
		/// </summary>
		private string acctNo;
		/// <summary>
		/// 汇总时间，多个时间用逗号","分隔
		/// </summary>
		private string summaryDates;
		/// <summary>
		/// 汇总类型：D 日汇总；M 月汇总
		/// </summary>
		private string summaryType;

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


		public virtual string SummaryDates
		{
			set
			{
				this.summaryDates = value;
			}
			get
			{
				return this.summaryDates;
			}
		}


		public virtual string SummaryType
		{
			set
			{
				this.summaryType = value;
			}
			get
			{
				return this.summaryType;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(acctNo, null))
			{
				@params["acct_no"] = acctNo;
			}
			if (!string.ReferenceEquals(summaryDates, null))
			{
				@params["summary_dates"] = summaryDates;
			}
			if (!string.ReferenceEquals(summaryType, null))
			{
				@params["summary_type"] = summaryType;
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