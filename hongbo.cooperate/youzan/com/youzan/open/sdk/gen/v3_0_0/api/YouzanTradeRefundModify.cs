using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundModifyResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundModifyResult;
    using YouzanTradeRefundModifyParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundModifyParams;

    public class YouzanTradeRefundModify : AbstractAPI <YouzanTradeRefundModifyParams, YouzanTradeRefundModifyResult>
	{

		public YouzanTradeRefundModify()
		{
		}

		public YouzanTradeRefundModify(YouzanTradeRefundModifyParams apiParams)
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
				return "youzan.trade.refund.modify";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundModifyResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundModifyParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}