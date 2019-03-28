using System;

namespace com.youzan.open.sdk.gen.v4_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeGetResult = com.youzan.open.sdk.gen.v4_0_0.model.YouzanTradeGetResult;
    using YouzanTradeGetParams = com.youzan.open.sdk.gen.v4_0_0.model.YouzanTradeGetParams;

    public class YouzanTradeGet : AbstractAPI <YouzanTradeGetParams, YouzanTradeGetResult>
	{

		public YouzanTradeGet()
		{
		}

		public YouzanTradeGet(YouzanTradeGetParams apiParams)
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
				return "4.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.trade.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}