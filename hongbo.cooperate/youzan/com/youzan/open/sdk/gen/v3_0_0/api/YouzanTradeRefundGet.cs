using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundGetResult;
    using YouzanTradeRefundGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundGetParams;

    public class YouzanTradeRefundGet : AbstractAPI <YouzanTradeRefundGetParams, YouzanTradeRefundGetResult>
	{

		public YouzanTradeRefundGet()
		{
		}

		public YouzanTradeRefundGet(YouzanTradeRefundGetParams apiParams)
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
				return "youzan.trade.refund.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}