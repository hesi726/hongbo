using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockVendorsSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockVendorsSearchResult;
    using YouzanRetailStockVendorsSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockVendorsSearchParams;

    public class YouzanRetailStockVendorsSearch : AbstractAPI <YouzanRetailStockVendorsSearchParams, YouzanRetailStockVendorsSearchResult>
	{

		public YouzanRetailStockVendorsSearch()
		{
		}

		public YouzanRetailStockVendorsSearch(YouzanRetailStockVendorsSearchParams apiParams)
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
				return "3.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.retail.stock.vendors.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockVendorsSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockVendorsSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}