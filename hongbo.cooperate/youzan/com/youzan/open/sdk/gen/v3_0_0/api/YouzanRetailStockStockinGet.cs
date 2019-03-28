using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockStockinGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockinGetResult;
    using YouzanRetailStockStockinGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockinGetParams;

    public class YouzanRetailStockStockinGet : AbstractAPI <YouzanRetailStockStockinGetParams, YouzanRetailStockStockinGetResult>
	{

		public YouzanRetailStockStockinGet()
		{
		}

		public YouzanRetailStockStockinGet(YouzanRetailStockStockinGetParams apiParams)
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
				return "youzan.retail.stock.stockin.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockinGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockinGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}