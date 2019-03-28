using System;

namespace com.youzan.open.sdk.gen.v3_0_1.api
{

    using com.youzan.open.sdk.api;
    using YouzanCrmCustomerPointsDecreaseResult = com.youzan.open.sdk.gen.v3_0_1.model.YouzanCrmCustomerPointsDecreaseResult;
    using YouzanCrmCustomerPointsDecreaseParams = com.youzan.open.sdk.gen.v3_0_1.model.YouzanCrmCustomerPointsDecreaseParams;

    public class YouzanCrmCustomerPointsDecrease : AbstractAPI <YouzanCrmCustomerPointsDecreaseParams, YouzanCrmCustomerPointsDecreaseResult>
	{

		public YouzanCrmCustomerPointsDecrease()
		{
		}

		public YouzanCrmCustomerPointsDecrease(YouzanCrmCustomerPointsDecreaseParams apiParams)
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
				return "youzan.crm.customer.points.decrease";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanCrmCustomerPointsDecreaseResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanCrmCustomerPointsDecreaseParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}