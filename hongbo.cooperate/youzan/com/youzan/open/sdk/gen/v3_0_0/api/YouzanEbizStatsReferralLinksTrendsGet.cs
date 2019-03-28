using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanEbizStatsReferralLinksTrendsGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralLinksTrendsGetResult;
    using YouzanEbizStatsReferralLinksTrendsGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralLinksTrendsGetParams;

    public class YouzanEbizStatsReferralLinksTrendsGet : AbstractAPI <YouzanEbizStatsReferralLinksTrendsGetParams, YouzanEbizStatsReferralLinksTrendsGetResult>
	{

		public YouzanEbizStatsReferralLinksTrendsGet()
		{
		}

		public YouzanEbizStatsReferralLinksTrendsGet(YouzanEbizStatsReferralLinksTrendsGetParams apiParams)
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
				return "youzan.ebiz.stats.referral.links.trends.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralLinksTrendsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralLinksTrendsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}