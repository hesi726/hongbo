using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundConditionGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundConditionGetResult;
    using YouzanTradeRefundConditionGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundConditionGetParams;

    public class YouzanTradeRefundConditionGet : AbstractAPI <YouzanTradeRefundConditionGetParams, YouzanTradeRefundConditionGetResult>
	{

		public YouzanTradeRefundConditionGet()
		{
		}

		public YouzanTradeRefundConditionGet(YouzanTradeRefundConditionGetParams apiParams)
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
				return "youzan.trade.refund.condition.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundConditionGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundConditionGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}