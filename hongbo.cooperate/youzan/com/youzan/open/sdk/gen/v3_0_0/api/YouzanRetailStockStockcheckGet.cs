using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockStockcheckGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockcheckGetResult;
    using YouzanRetailStockStockcheckGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockcheckGetParams;

    public class YouzanRetailStockStockcheckGet : AbstractAPI <YouzanRetailStockStockcheckGetParams, YouzanRetailStockStockcheckGetResult>
	{

		public YouzanRetailStockStockcheckGet()
		{
		}

		public YouzanRetailStockStockcheckGet(YouzanRetailStockStockcheckGetParams apiParams)
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
				return "youzan.retail.stock.stockcheck.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockcheckGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockcheckGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}