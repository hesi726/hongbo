using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundMessagesGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundMessagesGetResult;
    using YouzanTradeRefundMessagesGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundMessagesGetParams;

    public class YouzanTradeRefundMessagesGet : AbstractAPI <YouzanTradeRefundMessagesGetParams, YouzanTradeRefundMessagesGetResult>
	{

		public YouzanTradeRefundMessagesGet()
		{
		}

		public YouzanTradeRefundMessagesGet(YouzanTradeRefundMessagesGetParams apiParams)
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
				return "youzan.trade.refund.messages.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundMessagesGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundMessagesGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}