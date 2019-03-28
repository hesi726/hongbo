using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpCouponConsumeFetchlogsGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponConsumeFetchlogsGetResult;
    using YouzanUmpCouponConsumeFetchlogsGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpCouponConsumeFetchlogsGetParams;

    public class YouzanUmpCouponConsumeFetchlogsGet : AbstractAPI <YouzanUmpCouponConsumeFetchlogsGetParams, YouzanUmpCouponConsumeFetchlogsGetResult>
	{

		public YouzanUmpCouponConsumeFetchlogsGet()
		{
		}

		public YouzanUmpCouponConsumeFetchlogsGet(YouzanUmpCouponConsumeFetchlogsGetParams apiParams)
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
				return "youzan.ump.coupon.consume.fetchlogs.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponConsumeFetchlogsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpCouponConsumeFetchlogsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}