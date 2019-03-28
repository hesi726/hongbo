using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeCartCountResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartCountResult;
    using YouzanTradeCartCountParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartCountParams;

    public class YouzanTradeCartCount : AbstractAPI <YouzanTradeCartCountParams, YouzanTradeCartCountResult>
	{

		public YouzanTradeCartCount()
		{
		}

		public YouzanTradeCartCount(YouzanTradeCartCountParams apiParams)
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
				return "youzan.trade.cart.count";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeCartCountResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeCartCountParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}