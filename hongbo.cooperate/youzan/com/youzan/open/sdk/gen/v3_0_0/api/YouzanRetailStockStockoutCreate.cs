using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockStockoutCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockoutCreateResult;
    using YouzanRetailStockStockoutCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockoutCreateParams;

    public class YouzanRetailStockStockoutCreate : AbstractAPI <YouzanRetailStockStockoutCreateParams, YouzanRetailStockStockoutCreateResult>
	{

		public YouzanRetailStockStockoutCreate()
		{
		}

		public YouzanRetailStockStockoutCreate(YouzanRetailStockStockoutCreateParams apiParams)
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
				return "youzan.retail.stock.stockout.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockoutCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockoutCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}