using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpCouponConsumeVerifyResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponConsumeVerifyResult;
    using YouzanUmpCouponConsumeVerifyParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponConsumeVerifyParams;

    public class YouzanUmpCouponConsumeVerify : AbstractAPI <YouzanUmpCouponConsumeVerifyParams, YouzanUmpCouponConsumeVerifyResult>
	{

		public YouzanUmpCouponConsumeVerify()
		{
		}

		public YouzanUmpCouponConsumeVerify(YouzanUmpCouponConsumeVerifyParams apiParams)
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
				return "youzan.ump.coupon.consume.verify";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponConsumeVerifyResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponConsumeVerifyParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}