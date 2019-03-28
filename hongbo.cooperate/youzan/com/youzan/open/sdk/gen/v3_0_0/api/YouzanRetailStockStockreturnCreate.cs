using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockStockreturnCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockreturnCreateResult;
    using YouzanRetailStockStockreturnCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockreturnCreateParams;

    public class YouzanRetailStockStockreturnCreate : AbstractAPI <YouzanRetailStockStockreturnCreateParams, YouzanRetailStockStockreturnCreateResult>
	{

		public YouzanRetailStockStockreturnCreate()
		{
		}

		public YouzanRetailStockStockreturnCreate(YouzanRetailStockStockreturnCreateParams apiParams)
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
				return "youzan.retail.stock.stockreturn.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockreturnCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockreturnCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}