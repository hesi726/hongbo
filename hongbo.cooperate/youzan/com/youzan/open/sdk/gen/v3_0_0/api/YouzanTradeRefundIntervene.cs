using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundInterveneResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundInterveneResult;
    using YouzanTradeRefundInterveneParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundInterveneParams;

    public class YouzanTradeRefundIntervene : AbstractAPI <YouzanTradeRefundInterveneParams, YouzanTradeRefundInterveneResult>
	{

		public YouzanTradeRefundIntervene()
		{
		}

		public YouzanTradeRefundIntervene(YouzanTradeRefundInterveneParams apiParams)
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
				return "youzan.trade.refund.intervene";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundInterveneResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundInterveneParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}