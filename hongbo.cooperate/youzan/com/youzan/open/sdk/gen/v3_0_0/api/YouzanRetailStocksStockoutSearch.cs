using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStocksStockoutSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStocksStockoutSearchResult;
    using YouzanRetailStocksStockoutSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStocksStockoutSearchParams;

    public class YouzanRetailStocksStockoutSearch : AbstractAPI <YouzanRetailStocksStockoutSearchParams, YouzanRetailStocksStockoutSearchResult>
	{

		public YouzanRetailStocksStockoutSearch()
		{
		}

		public YouzanRetailStocksStockoutSearch(YouzanRetailStocksStockoutSearchParams apiParams)
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
				return "youzan.retail.stocks.stockout.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStocksStockoutSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStocksStockoutSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}