using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSalesmanItemsGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanItemsGetResult;
    using YouzanSalesmanItemsGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanItemsGetParams;

    public class YouzanSalesmanItemsGet : AbstractAPI <YouzanSalesmanItemsGetParams, YouzanSalesmanItemsGetResult>
	{

		public YouzanSalesmanItemsGet()
		{
		}

		public YouzanSalesmanItemsGet(YouzanSalesmanItemsGetParams apiParams)
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
				return "youzan.salesman.items.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSalesmanItemsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSalesmanItemsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}