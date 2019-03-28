using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayAccountingSummaryDetailGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayAccountingSummaryDetailGetResult;
    using YouzanPayAccountingSummaryDetailGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayAccountingSummaryDetailGetParams;

    public class YouzanPayAccountingSummaryDetailGet : AbstractAPI <YouzanPayAccountingSummaryDetailGetParams, YouzanPayAccountingSummaryDetailGetResult>
	{

		public YouzanPayAccountingSummaryDetailGet()
		{
		}

		public YouzanPayAccountingSummaryDetailGet(YouzanPayAccountingSummaryDetailGetParams apiParams)
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
				return "youzan.pay.accounting.summary.detail.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayAccountingSummaryDetailGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayAccountingSummaryDetailGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}