using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeVirtualticketGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeVirtualticketGetResult;
    using YouzanTradeVirtualticketGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeVirtualticketGetParams;

    public class YouzanTradeVirtualticketGet : AbstractAPI <YouzanTradeVirtualticketGetParams, YouzanTradeVirtualticketGetResult>
	{

		public YouzanTradeVirtualticketGet()
		{
		}

		public YouzanTradeVirtualticketGet(YouzanTradeVirtualticketGetParams apiParams)
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
				return "youzan.trade.virtualticket.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeVirtualticketGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeVirtualticketGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}