using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanEbizStatsReferralPagesOverviewResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralPagesOverviewResult;
    using YouzanEbizStatsReferralPagesOverviewParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralPagesOverviewParams;

    public class YouzanEbizStatsReferralPagesOverview : AbstractAPI <YouzanEbizStatsReferralPagesOverviewParams, YouzanEbizStatsReferralPagesOverviewResult>
	{

		public YouzanEbizStatsReferralPagesOverview()
		{
		}

		public YouzanEbizStatsReferralPagesOverview(YouzanEbizStatsReferralPagesOverviewParams apiParams)
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
				return "youzan.ebiz.stats.referral.pages.overview";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralPagesOverviewResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralPagesOverviewParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}