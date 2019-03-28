using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradePriceUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradePriceUpdateResult;
    using YouzanTradePriceUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradePriceUpdateParams;

    public class YouzanTradePriceUpdate : AbstractAPI <YouzanTradePriceUpdateParams, YouzanTradePriceUpdateResult>
	{

		public YouzanTradePriceUpdate()
		{
		}

		public YouzanTradePriceUpdate(YouzanTradePriceUpdateParams apiParams)
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
				return "youzan.trade.price.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradePriceUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradePriceUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}