using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSalesmanAccountAddResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanAccountAddResult;
    using YouzanSalesmanAccountAddParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanAccountAddParams;

    public class YouzanSalesmanAccountAdd : AbstractAPI <YouzanSalesmanAccountAddParams, YouzanSalesmanAccountAddResult>
	{

		public YouzanSalesmanAccountAdd()
		{
		}

		public YouzanSalesmanAccountAdd(YouzanSalesmanAccountAddParams apiParams)
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
				return "youzan.salesman.account.add";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSalesmanAccountAddResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSalesmanAccountAddParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}