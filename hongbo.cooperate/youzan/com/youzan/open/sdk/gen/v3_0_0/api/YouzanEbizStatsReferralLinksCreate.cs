using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanEbizStatsReferralLinksCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralLinksCreateResult;
    using YouzanEbizStatsReferralLinksCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralLinksCreateParams;

    public class YouzanEbizStatsReferralLinksCreate : AbstractAPI <YouzanEbizStatsReferralLinksCreateParams, YouzanEbizStatsReferralLinksCreateResult>
	{

		public YouzanEbizStatsReferralLinksCreate()
		{
		}

		public YouzanEbizStatsReferralLinksCreate(YouzanEbizStatsReferralLinksCreateParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "POST";
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
				return "youzan.ebiz.stats.referral.links.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralLinksCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralLinksCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}