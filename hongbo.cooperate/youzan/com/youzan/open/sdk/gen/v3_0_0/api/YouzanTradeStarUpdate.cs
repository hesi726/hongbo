using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeStarUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeStarUpdateResult;
    using YouzanTradeStarUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeStarUpdateParams;

    public class YouzanTradeStarUpdate : AbstractAPI <YouzanTradeStarUpdateParams, YouzanTradeStarUpdateResult>
	{

		public YouzanTradeStarUpdate()
		{
		}

		public YouzanTradeStarUpdate(YouzanTradeStarUpdateParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "POST";
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
				return "youzan.trade.star.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeStarUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeStarUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}