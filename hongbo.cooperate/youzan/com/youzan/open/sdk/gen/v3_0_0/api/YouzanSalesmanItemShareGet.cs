using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSalesmanItemShareGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanItemShareGetResult;
    using YouzanSalesmanItemShareGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanItemShareGetParams;

    public class YouzanSalesmanItemShareGet : AbstractAPI <YouzanSalesmanItemShareGetParams, YouzanSalesmanItemShareGetResult>
	{

		public YouzanSalesmanItemShareGet()
		{
		}

		public YouzanSalesmanItemShareGet(YouzanSalesmanItemShareGetParams apiParams)
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
				return "youzan.salesman.item.share.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSalesmanItemShareGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSalesmanItemShareGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}