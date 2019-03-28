using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCustomerGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerGetResult;
    using YouzanScrmCustomerGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerGetParams;

    public class YouzanScrmCustomerGet : AbstractAPI <YouzanScrmCustomerGetParams, YouzanScrmCustomerGetResult>
	{

		public YouzanScrmCustomerGet()
		{
		}

		public YouzanScrmCustomerGet(YouzanScrmCustomerGetParams apiParams)
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
				return "youzan.scrm.customer.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}