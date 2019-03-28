using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradesSoldGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradesSoldGetResult;
    using YouzanTradesSoldGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradesSoldGetParams;

    public class YouzanTradesSoldGet : AbstractAPI <YouzanTradesSoldGetParams, YouzanTradesSoldGetResult>
	{

		public YouzanTradesSoldGet()
		{
		}

		public YouzanTradesSoldGet(YouzanTradesSoldGetParams apiParams)
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
				return "youzan.trades.sold.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradesSoldGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradesSoldGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}