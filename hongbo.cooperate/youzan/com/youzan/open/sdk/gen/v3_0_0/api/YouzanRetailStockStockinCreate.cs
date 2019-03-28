using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockStockinCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockinCreateResult;
    using YouzanRetailStockStockinCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockinCreateParams;

    public class YouzanRetailStockStockinCreate : AbstractAPI <YouzanRetailStockStockinCreateParams, YouzanRetailStockStockinCreateResult>
	{

		public YouzanRetailStockStockinCreate()
		{
		}

		public YouzanRetailStockStockinCreate(YouzanRetailStockStockinCreateParams apiParams)
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
				return "youzan.retail.stock.stockin.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockinCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockinCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}