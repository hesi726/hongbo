using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpCouponTakeResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponTakeResult;
    using YouzanUmpCouponTakeParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponTakeParams;

    public class YouzanUmpCouponTake : AbstractAPI <YouzanUmpCouponTakeParams, YouzanUmpCouponTakeResult>
	{

		public YouzanUmpCouponTake()
		{
		}

		public YouzanUmpCouponTake(YouzanUmpCouponTakeParams apiParams)
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
				return "youzan.ump.coupon.take";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponTakeResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponTakeParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}