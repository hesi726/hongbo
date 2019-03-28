using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeCartUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartUpdateResult;
    using YouzanTradeCartUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartUpdateParams;

    public class YouzanTradeCartUpdate : AbstractAPI <YouzanTradeCartUpdateParams, YouzanTradeCartUpdateResult>
	{

		public YouzanTradeCartUpdate()
		{
		}

		public YouzanTradeCartUpdate(YouzanTradeCartUpdateParams apiParams)
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
				return "youzan.trade.cart.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeCartUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeCartUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}