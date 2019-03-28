using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStocksStockinSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStocksStockinSearchResult;
    using YouzanRetailStocksStockinSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStocksStockinSearchParams;

    public class YouzanRetailStocksStockinSearch : AbstractAPI <YouzanRetailStocksStockinSearchParams, YouzanRetailStocksStockinSearchResult>
	{

		public YouzanRetailStocksStockinSearch()
		{
		}

		public YouzanRetailStocksStockinSearch(YouzanRetailStocksStockinSearchParams apiParams)
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
				return "youzan.retail.stocks.stockin.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStocksStockinSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStocksStockinSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}