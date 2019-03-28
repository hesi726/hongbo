using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSalesmanTradesGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanTradesGetResult;
    using YouzanSalesmanTradesGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanTradesGetParams;

    public class YouzanSalesmanTradesGet : AbstractAPI <YouzanSalesmanTradesGetParams, YouzanSalesmanTradesGetResult>
	{

		public YouzanSalesmanTradesGet()
		{
		}

		public YouzanSalesmanTradesGet(YouzanSalesmanTradesGetParams apiParams)
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
				return "youzan.salesman.trades.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSalesmanTradesGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSalesmanTradesGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}