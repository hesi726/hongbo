using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayAccountingSummaryQueryResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayAccountingSummaryQueryResult;
    using YouzanPayAccountingSummaryQueryParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayAccountingSummaryQueryParams;

    public class YouzanPayAccountingSummaryQuery : AbstractAPI <YouzanPayAccountingSummaryQueryParams, YouzanPayAccountingSummaryQueryResult>
	{

		public YouzanPayAccountingSummaryQuery()
		{
		}

		public YouzanPayAccountingSummaryQuery(YouzanPayAccountingSummaryQueryParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "GET";
			}
		}

		public override string Version
		{
			get
			{
				return "3.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.pay.accounting.summary.query";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayAccountingSummaryQueryResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayAccountingSummaryQueryParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}