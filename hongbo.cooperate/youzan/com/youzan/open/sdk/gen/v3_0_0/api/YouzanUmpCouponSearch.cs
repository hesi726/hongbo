using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpCouponSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponSearchResult;
    using YouzanUmpCouponSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponSearchParams;

    public class YouzanUmpCouponSearch : AbstractAPI <YouzanUmpCouponSearchParams, YouzanUmpCouponSearchResult>
	{

		public YouzanUmpCouponSearch()
		{
		}

		public YouzanUmpCouponSearch(YouzanUmpCouponSearchParams apiParams)
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
				return "youzan.ump.coupon.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}