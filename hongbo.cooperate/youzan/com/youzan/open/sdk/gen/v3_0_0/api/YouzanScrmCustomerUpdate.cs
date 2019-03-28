using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCustomerUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerUpdateResult;
    using YouzanScrmCustomerUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerUpdateParams;

    public class YouzanScrmCustomerUpdate : AbstractAPI <YouzanScrmCustomerUpdateParams, YouzanScrmCustomerUpdateResult>
	{

		public YouzanScrmCustomerUpdate()
		{
		}

		public YouzanScrmCustomerUpdate(YouzanScrmCustomerUpdateParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "POST";
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
				return "youzan.scrm.customer.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}