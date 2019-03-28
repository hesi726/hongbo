using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundAgreeResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundAgreeResult;
    using YouzanTradeRefundAgreeParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundAgreeParams;

    public class YouzanTradeRefundAgree : AbstractAPI <YouzanTradeRefundAgreeParams, YouzanTradeRefundAgreeResult>
	{

		public YouzanTradeRefundAgree()
		{
		}

		public YouzanTradeRefundAgree(YouzanTradeRefundAgreeParams apiParams)
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
				return "youzan.trade.refund.agree";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundAgreeResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundAgreeParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}