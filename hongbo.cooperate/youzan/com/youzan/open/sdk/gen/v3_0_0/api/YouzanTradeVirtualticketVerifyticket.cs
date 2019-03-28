using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeVirtualticketVerifyticketResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeVirtualticketVerifyticketResult;
    using YouzanTradeVirtualticketVerifyticketParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeVirtualticketVerifyticketParams;

    public class YouzanTradeVirtualticketVerifyticket : AbstractAPI <YouzanTradeVirtualticketVerifyticketParams, YouzanTradeVirtualticketVerifyticketResult>
	{

		public YouzanTradeVirtualticketVerifyticket()
		{
		}

		public YouzanTradeVirtualticketVerifyticket(YouzanTradeVirtualticketVerifyticketParams apiParams)
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
				return "youzan.trade.virtualticket.verifyticket";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeVirtualticketVerifyticketResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeVirtualticketVerifyticketParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}