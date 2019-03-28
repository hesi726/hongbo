using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSalesmanTradesAccountGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanTradesAccountGetResult;
    using YouzanSalesmanTradesAccountGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanTradesAccountGetParams;

    public class YouzanSalesmanTradesAccountGet : AbstractAPI <YouzanSalesmanTradesAccountGetParams, YouzanSalesmanTradesAccountGetResult>
	{

		public YouzanSalesmanTradesAccountGet()
		{
		}

		public YouzanSalesmanTradesAccountGet(YouzanSalesmanTradesAccountGetParams apiParams)
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
				return "youzan.salesman.trades.account.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSalesmanTradesAccountGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSalesmanTradesAccountGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}