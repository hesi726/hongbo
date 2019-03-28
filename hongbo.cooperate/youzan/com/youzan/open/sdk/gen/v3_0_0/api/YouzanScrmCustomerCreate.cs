using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCustomerCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerCreateResult;
    using YouzanScrmCustomerCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerCreateParams;

    public class YouzanScrmCustomerCreate : AbstractAPI <YouzanScrmCustomerCreateParams, YouzanScrmCustomerCreateResult>
	{

		public YouzanScrmCustomerCreate()
		{
		}

		public YouzanScrmCustomerCreate(YouzanScrmCustomerCreateParams apiParams)
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
				return "youzan.scrm.customer.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}