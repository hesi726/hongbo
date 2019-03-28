using System;

namespace com.youzan.open.sdk.gen.v3_1_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCustomerSearchResult = com.youzan.open.sdk.gen.v3_1_0.model.YouzanScrmCustomerSearchResult;
    using YouzanScrmCustomerSearchParams = com.youzan.open.sdk.gen.v3_1_0.model.YouzanScrmCustomerSearchParams;

    public class YouzanScrmCustomerSearch : AbstractAPI <YouzanScrmCustomerSearchParams, YouzanScrmCustomerSearchResult>
	{

		public YouzanScrmCustomerSearch()
		{
		}

		public YouzanScrmCustomerSearch(YouzanScrmCustomerSearchParams apiParams)
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
				return "3.1.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.scrm.customer.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCustomerSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}