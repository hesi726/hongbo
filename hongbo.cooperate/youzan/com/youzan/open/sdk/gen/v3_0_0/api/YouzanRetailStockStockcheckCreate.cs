using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockStockcheckCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockcheckCreateResult;
    using YouzanRetailStockStockcheckCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockcheckCreateParams;

    public class YouzanRetailStockStockcheckCreate : AbstractAPI <YouzanRetailStockStockcheckCreateParams, YouzanRetailStockStockcheckCreateResult>
	{

		public YouzanRetailStockStockcheckCreate()
		{
		}

		public YouzanRetailStockStockcheckCreate(YouzanRetailStockStockcheckCreateParams apiParams)
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
				return "youzan.retail.stock.stockcheck.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockcheckCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockcheckCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}