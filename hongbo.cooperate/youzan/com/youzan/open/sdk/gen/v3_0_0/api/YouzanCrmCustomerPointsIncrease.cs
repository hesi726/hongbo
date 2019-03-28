using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanCrmCustomerPointsIncreaseResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanCrmCustomerPointsIncreaseResult;
    using YouzanCrmCustomerPointsIncreaseParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanCrmCustomerPointsIncreaseParams;

    public class YouzanCrmCustomerPointsIncrease : AbstractAPI <YouzanCrmCustomerPointsIncreaseParams, YouzanCrmCustomerPointsIncreaseResult>
	{

		public YouzanCrmCustomerPointsIncrease()
		{
		}

		public YouzanCrmCustomerPointsIncrease(YouzanCrmCustomerPointsIncreaseParams apiParams)
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
				return "youzan.crm.customer.points.increase";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanCrmCustomerPointsIncreaseResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanCrmCustomerPointsIncreaseParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}