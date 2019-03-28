using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanEbizStatsReferralLinksGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralLinksGetResult;
    using YouzanEbizStatsReferralLinksGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralLinksGetParams;

    public class YouzanEbizStatsReferralLinksGet : AbstractAPI <YouzanEbizStatsReferralLinksGetParams, YouzanEbizStatsReferralLinksGetResult>
	{

		public YouzanEbizStatsReferralLinksGet()
		{
		}

		public YouzanEbizStatsReferralLinksGet(YouzanEbizStatsReferralLinksGetParams apiParams)
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
				return "youzan.ebiz.stats.referral.links.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralLinksGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralLinksGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}