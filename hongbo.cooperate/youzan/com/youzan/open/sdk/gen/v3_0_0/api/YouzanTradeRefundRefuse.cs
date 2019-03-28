using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundRefuseResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundRefuseResult;
    using YouzanTradeRefundRefuseParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundRefuseParams;

    public class YouzanTradeRefundRefuse : AbstractAPI <YouzanTradeRefundRefuseParams, YouzanTradeRefundRefuseResult>
	{

		public YouzanTradeRefundRefuse()
		{
		}

		public YouzanTradeRefundRefuse(YouzanTradeRefundRefuseParams apiParams)
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
				return "youzan.trade.refund.refuse";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundRefuseResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundRefuseParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}