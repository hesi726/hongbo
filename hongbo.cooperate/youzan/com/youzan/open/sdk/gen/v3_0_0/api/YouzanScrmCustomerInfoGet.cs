using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCustomerInfoGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerInfoGetResult;
    using YouzanScrmCustomerInfoGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCustomerInfoGetParams;

    public class YouzanScrmCustomerInfoGet : AbstractAPI <YouzanScrmCustomerInfoGetParams, YouzanScrmCustomerInfoGetResult>
	{

		public YouzanScrmCustomerInfoGet()
		{
		}

		public YouzanScrmCustomerInfoGet(YouzanScrmCustomerInfoGetParams apiParams)
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
				return "youzan.scrm.customer.info.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerInfoGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerInfoGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}