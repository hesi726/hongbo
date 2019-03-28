using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSalesmanCustomersGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanCustomersGetResult;
    using YouzanSalesmanCustomersGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanCustomersGetParams;

    public class YouzanSalesmanCustomersGet : AbstractAPI <YouzanSalesmanCustomersGetParams, YouzanSalesmanCustomersGetResult>
	{

		public YouzanSalesmanCustomersGet()
		{
		}

		public YouzanSalesmanCustomersGet(YouzanSalesmanCustomersGetParams apiParams)
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
				return "youzan.salesman.customers.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSalesmanCustomersGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSalesmanCustomersGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}