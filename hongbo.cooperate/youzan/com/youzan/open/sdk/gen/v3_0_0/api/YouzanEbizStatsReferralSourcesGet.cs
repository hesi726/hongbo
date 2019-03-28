using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanEbizStatsReferralSourcesGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralSourcesGetResult;
    using YouzanEbizStatsReferralSourcesGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralSourcesGetParams;

    public class YouzanEbizStatsReferralSourcesGet : AbstractAPI <YouzanEbizStatsReferralSourcesGetParams, YouzanEbizStatsReferralSourcesGetResult>
	{

		public YouzanEbizStatsReferralSourcesGet()
		{
		}

		public YouzanEbizStatsReferralSourcesGet(YouzanEbizStatsReferralSourcesGetParams apiParams)
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
				return "youzan.ebiz.stats.referral.sources.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralSourcesGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralSourcesGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}