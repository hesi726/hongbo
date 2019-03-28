using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockStockoutGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockoutGetResult;
    using YouzanRetailStockStockoutGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockoutGetParams;

    public class YouzanRetailStockStockoutGet : AbstractAPI <YouzanRetailStockStockoutGetParams, YouzanRetailStockStockoutGetResult>
	{

		public YouzanRetailStockStockoutGet()
		{
		}

		public YouzanRetailStockStockoutGet(YouzanRetailStockStockoutGetParams apiParams)
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
				return "youzan.retail.stock.stockout.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockoutGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockoutGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}