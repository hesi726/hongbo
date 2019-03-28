using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundApplyResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundApplyResult;
    using YouzanTradeRefundApplyParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundApplyParams;

    public class YouzanTradeRefundApply : AbstractAPI <YouzanTradeRefundApplyParams, YouzanTradeRefundApplyResult>
	{

		public YouzanTradeRefundApply()
		{
		}

		public YouzanTradeRefundApply(YouzanTradeRefundApplyParams apiParams)
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
				return "youzan.trade.refund.apply";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundApplyResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundApplyParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}