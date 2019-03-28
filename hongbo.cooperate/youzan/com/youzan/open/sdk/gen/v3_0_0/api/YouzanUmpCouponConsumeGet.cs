using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpCouponConsumeGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponConsumeGetResult;
    using YouzanUmpCouponConsumeGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponConsumeGetParams;

    public class YouzanUmpCouponConsumeGet : AbstractAPI <YouzanUmpCouponConsumeGetParams, YouzanUmpCouponConsumeGetResult>
	{

		public YouzanUmpCouponConsumeGet()
		{
		}

		public YouzanUmpCouponConsumeGet(YouzanUmpCouponConsumeGetParams apiParams)
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
				return "youzan.ump.coupon.consume.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponConsumeGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponConsumeGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}