using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpCouponDetailGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponDetailGetResult;
    using YouzanUmpCouponDetailGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponDetailGetParams;

    public class YouzanUmpCouponDetailGet : AbstractAPI <YouzanUmpCouponDetailGetParams, YouzanUmpCouponDetailGetResult>
	{

		public YouzanUmpCouponDetailGet()
		{
		}

		public YouzanUmpCouponDetailGet(YouzanUmpCouponDetailGetParams apiParams)
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
				return "youzan.ump.coupon.detail.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponDetailGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponDetailGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}