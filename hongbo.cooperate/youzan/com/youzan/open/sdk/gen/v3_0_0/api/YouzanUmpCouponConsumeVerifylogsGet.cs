using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpCouponConsumeVerifylogsGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponConsumeVerifylogsGetResult;
    using YouzanUmpCouponConsumeVerifylogsGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponConsumeVerifylogsGetParams;

    public class YouzanUmpCouponConsumeVerifylogsGet : AbstractAPI <YouzanUmpCouponConsumeVerifylogsGetParams, YouzanUmpCouponConsumeVerifylogsGetResult>
	{

		public YouzanUmpCouponConsumeVerifylogsGet()
		{
		}

		public YouzanUmpCouponConsumeVerifylogsGet(YouzanUmpCouponConsumeVerifylogsGetParams apiParams)
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
				return "youzan.ump.coupon.consume.verifylogs.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponConsumeVerifylogsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponConsumeVerifylogsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}