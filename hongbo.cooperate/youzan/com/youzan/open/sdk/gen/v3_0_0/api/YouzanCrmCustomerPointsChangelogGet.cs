using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanCrmCustomerPointsChangelogGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanCrmCustomerPointsChangelogGetResult;
    using YouzanCrmCustomerPointsChangelogGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanCrmCustomerPointsChangelogGetParams;

    public class YouzanCrmCustomerPointsChangelogGet : AbstractAPI <YouzanCrmCustomerPointsChangelogGetParams, YouzanCrmCustomerPointsChangelogGetResult>
	{

		public YouzanCrmCustomerPointsChangelogGet()
		{
		}

		public YouzanCrmCustomerPointsChangelogGet(YouzanCrmCustomerPointsChangelogGetParams apiParams)
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
				return "youzan.crm.customer.points.changelog.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanCrmCustomerPointsChangelogGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanCrmCustomerPointsChangelogGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}