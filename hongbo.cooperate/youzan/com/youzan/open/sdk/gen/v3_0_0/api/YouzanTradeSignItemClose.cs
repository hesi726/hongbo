using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeSignItemCloseResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeSignItemCloseResult;
    using YouzanTradeSignItemCloseParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeSignItemCloseParams;

    public class YouzanTradeSignItemClose : AbstractAPI <YouzanTradeSignItemCloseParams, YouzanTradeSignItemCloseResult>
	{

		public YouzanTradeSignItemClose()
		{
		}

		public YouzanTradeSignItemClose(YouzanTradeSignItemCloseParams apiParams)
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
				return "youzan.trade.sign.item.close";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeSignItemCloseResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeSignItemCloseParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}