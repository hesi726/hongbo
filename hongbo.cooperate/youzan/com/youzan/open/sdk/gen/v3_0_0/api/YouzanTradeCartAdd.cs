using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeCartAddResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartAddResult;
    using YouzanTradeCartAddParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartAddParams;

    public class YouzanTradeCartAdd : AbstractAPI <YouzanTradeCartAddParams, YouzanTradeCartAddResult>
	{

		public YouzanTradeCartAdd()
		{
		}

		public YouzanTradeCartAdd(YouzanTradeCartAddParams apiParams)
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
				return "youzan.trade.cart.add";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeCartAddResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeCartAddParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}