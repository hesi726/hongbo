using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeVirtualticketVerifycodeResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeVirtualticketVerifycodeResult;
    using YouzanTradeVirtualticketVerifycodeParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeVirtualticketVerifycodeParams;

    public class YouzanTradeVirtualticketVerifycode : AbstractAPI <YouzanTradeVirtualticketVerifycodeParams, YouzanTradeVirtualticketVerifycodeResult>
	{

		public YouzanTradeVirtualticketVerifycode()
		{
		}

		public YouzanTradeVirtualticketVerifycode(YouzanTradeVirtualticketVerifycodeParams apiParams)
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
				return "youzan.trade.virtualticket.verifycode";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeVirtualticketVerifycodeResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeVirtualticketVerifycodeParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}