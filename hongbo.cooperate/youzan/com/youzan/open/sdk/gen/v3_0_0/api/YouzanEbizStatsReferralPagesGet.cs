using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanEbizStatsReferralPagesGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralPagesGetResult;
    using YouzanEbizStatsReferralPagesGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralPagesGetParams;

    public class YouzanEbizStatsReferralPagesGet : AbstractAPI <YouzanEbizStatsReferralPagesGetParams, YouzanEbizStatsReferralPagesGetResult>
	{

		public YouzanEbizStatsReferralPagesGet()
		{
		}

		public YouzanEbizStatsReferralPagesGet(YouzanEbizStatsReferralPagesGetParams apiParams)
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
				return "youzan.ebiz.stats.referral.pages.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralPagesGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralPagesGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}