using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundSearchResult;
    using YouzanTradeRefundSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundSearchParams;

    public class YouzanTradeRefundSearch : AbstractAPI <YouzanTradeRefundSearchParams, YouzanTradeRefundSearchResult>
	{

		public YouzanTradeRefundSearch()
		{
		}

		public YouzanTradeRefundSearch(YouzanTradeRefundSearchParams apiParams)
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
				return "youzan.trade.refund.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}