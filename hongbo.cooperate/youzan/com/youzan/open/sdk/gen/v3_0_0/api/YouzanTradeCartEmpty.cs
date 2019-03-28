using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeCartEmptyResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartEmptyResult;
    using YouzanTradeCartEmptyParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartEmptyParams;

    public class YouzanTradeCartEmpty : AbstractAPI <YouzanTradeCartEmptyParams, YouzanTradeCartEmptyResult>
	{

		public YouzanTradeCartEmpty()
		{
		}

		public YouzanTradeCartEmpty(YouzanTradeCartEmptyParams apiParams)
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
				return "youzan.trade.cart.empty";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeCartEmptyResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeCartEmptyParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}