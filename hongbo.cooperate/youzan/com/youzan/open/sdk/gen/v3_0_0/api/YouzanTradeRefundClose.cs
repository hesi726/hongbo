using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundCloseResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundCloseResult;
    using YouzanTradeRefundCloseParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundCloseParams;

    public class YouzanTradeRefundClose : AbstractAPI <YouzanTradeRefundCloseParams, YouzanTradeRefundCloseResult>
	{

		public YouzanTradeRefundClose()
		{
		}

		public YouzanTradeRefundClose(YouzanTradeRefundCloseParams apiParams)
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
				return "youzan.trade.refund.close";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundCloseResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundCloseParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}