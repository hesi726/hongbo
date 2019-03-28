using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeQrlabelSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeQrlabelSearchResult;
    using YouzanTradeQrlabelSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeQrlabelSearchParams;

    public class YouzanTradeQrlabelSearch : AbstractAPI <YouzanTradeQrlabelSearchParams, YouzanTradeQrlabelSearchResult>
	{

		public YouzanTradeQrlabelSearch()
		{
		}

		public YouzanTradeQrlabelSearch(YouzanTradeQrlabelSearchParams apiParams)
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
				return "youzan.trade.qrlabel.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeQrlabelSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeQrlabelSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}