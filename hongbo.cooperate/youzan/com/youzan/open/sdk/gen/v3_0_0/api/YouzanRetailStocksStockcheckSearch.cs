using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStocksStockcheckSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStocksStockcheckSearchResult;
    using YouzanRetailStocksStockcheckSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStocksStockcheckSearchParams;

    public class YouzanRetailStocksStockcheckSearch : AbstractAPI <YouzanRetailStocksStockcheckSearchParams, YouzanRetailStocksStockcheckSearchResult>
	{

		public YouzanRetailStocksStockcheckSearch()
		{
		}

		public YouzanRetailStocksStockcheckSearch(YouzanRetailStocksStockcheckSearchParams apiParams)
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
				return "youzan.retail.stocks.stockcheck.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStocksStockcheckSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStocksStockcheckSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}