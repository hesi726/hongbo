using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradesSoldOuterGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradesSoldOuterGetResult;
    using YouzanTradesSoldOuterGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradesSoldOuterGetParams;

    public class YouzanTradesSoldOuterGet : AbstractAPI <YouzanTradesSoldOuterGetParams, YouzanTradesSoldOuterGetResult>
	{

		public YouzanTradesSoldOuterGet()
		{
		}

		public YouzanTradesSoldOuterGet(YouzanTradesSoldOuterGetParams apiParams)
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
				return "youzan.trades.sold.outer.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradesSoldOuterGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradesSoldOuterGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}