using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeCloseResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCloseResult;
    using YouzanTradeCloseParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCloseParams;

    public class YouzanTradeClose : AbstractAPI <YouzanTradeCloseParams, YouzanTradeCloseResult>
	{

		public YouzanTradeClose()
		{
		}

		public YouzanTradeClose(YouzanTradeCloseParams apiParams)
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
				return "youzan.trade.close";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeCloseResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeCloseParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}