using System;

namespace com.youzan.open.sdk.gen.v3_0_1.api
{

    using com.youzan.open.sdk.api;
    using YouzanCrmCustomerPointsChangelogGetResult = com.youzan.open.sdk.gen.v3_0_1.model.YouzanCrmCustomerPointsChangelogGetResult;
    using YouzanCrmCustomerPointsChangelogGetParams = com.youzan.open.sdk.gen.v3_0_1.model.YouzanCrmCustomerPointsChangelogGetParams;

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
				return "3.0.1";
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