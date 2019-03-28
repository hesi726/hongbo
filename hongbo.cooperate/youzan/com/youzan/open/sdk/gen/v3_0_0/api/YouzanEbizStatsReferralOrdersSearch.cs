using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanEbizStatsReferralOrdersSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralOrdersSearchResult;
    using YouzanEbizStatsReferralOrdersSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanEbizStatsReferralOrdersSearchParams;

    public class YouzanEbizStatsReferralOrdersSearch : AbstractAPI <YouzanEbizStatsReferralOrdersSearchParams, YouzanEbizStatsReferralOrdersSearchResult>
	{

		public YouzanEbizStatsReferralOrdersSearch()
		{
		}

		public YouzanEbizStatsReferralOrdersSearch(YouzanEbizStatsReferralOrdersSearchParams apiParams)
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
				return "youzan.ebiz.stats.referral.orders.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralOrdersSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanEbizStatsReferralOrdersSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}