using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockSellOutResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockSellOutResult;
    using YouzanRetailStockSellOutParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockSellOutParams;

    public class YouzanRetailStockSellOut : AbstractAPI <YouzanRetailStockSellOutParams, YouzanRetailStockSellOutResult>
	{

		public YouzanRetailStockSellOut()
		{
		}

		public YouzanRetailStockSellOut(YouzanRetailStockSellOutParams apiParams)
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
				return "youzan.retail.stock.sell.out";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockSellOutResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockSellOutParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}