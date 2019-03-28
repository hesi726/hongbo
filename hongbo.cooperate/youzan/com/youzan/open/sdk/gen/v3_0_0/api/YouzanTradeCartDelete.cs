using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeCartDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartDeleteResult;
    using YouzanTradeCartDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartDeleteParams;

    public class YouzanTradeCartDelete : AbstractAPI <YouzanTradeCartDeleteParams, YouzanTradeCartDeleteResult>
	{

		public YouzanTradeCartDelete()
		{
		}

		public YouzanTradeCartDelete(YouzanTradeCartDeleteParams apiParams)
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
				return "youzan.trade.cart.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeCartDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeCartDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}