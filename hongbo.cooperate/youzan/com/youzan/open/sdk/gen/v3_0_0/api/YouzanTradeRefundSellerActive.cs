using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeRefundSellerActiveResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundSellerActiveResult;
    using YouzanTradeRefundSellerActiveParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeRefundSellerActiveParams;

    public class YouzanTradeRefundSellerActive : AbstractAPI <YouzanTradeRefundSellerActiveParams, YouzanTradeRefundSellerActiveResult>
	{

		public YouzanTradeRefundSellerActive()
		{
		}

		public YouzanTradeRefundSellerActive(YouzanTradeRefundSellerActiveParams apiParams)
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
				return "youzan.trade.refund.seller.active";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundSellerActiveResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeRefundSellerActiveParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}