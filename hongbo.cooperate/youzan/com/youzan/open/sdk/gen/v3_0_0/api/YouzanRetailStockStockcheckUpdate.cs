using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockStockcheckUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockcheckUpdateResult;
    using YouzanRetailStockStockcheckUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockcheckUpdateParams;

    public class YouzanRetailStockStockcheckUpdate : AbstractAPI <YouzanRetailStockStockcheckUpdateParams, YouzanRetailStockStockcheckUpdateResult>
	{

		public YouzanRetailStockStockcheckUpdate()
		{
		}

		public YouzanRetailStockStockcheckUpdate(YouzanRetailStockStockcheckUpdateParams apiParams)
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
				return "youzan.retail.stock.stockcheck.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockcheckUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockcheckUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}