using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSalesmanAccountGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanAccountGetResult;
    using YouzanSalesmanAccountGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanAccountGetParams;

    public class YouzanSalesmanAccountGet : AbstractAPI <YouzanSalesmanAccountGetParams, YouzanSalesmanAccountGetResult>
	{

		public YouzanSalesmanAccountGet()
		{
		}

		public YouzanSalesmanAccountGet(YouzanSalesmanAccountGetParams apiParams)
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
				return "youzan.salesman.account.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSalesmanAccountGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSalesmanAccountGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}