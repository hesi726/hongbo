using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpCouponsUnfinishedSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponsUnfinishedSearchResult;
    using YouzanUmpCouponsUnfinishedSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponsUnfinishedSearchParams;

    public class YouzanUmpCouponsUnfinishedSearch : AbstractAPI <YouzanUmpCouponsUnfinishedSearchParams, YouzanUmpCouponsUnfinishedSearchResult>
	{

		public YouzanUmpCouponsUnfinishedSearch()
		{
		}

		public YouzanUmpCouponsUnfinishedSearch(YouzanUmpCouponsUnfinishedSearchParams apiParams)
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
				return "youzan.ump.coupons.unfinished.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponsUnfinishedSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponsUnfinishedSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}