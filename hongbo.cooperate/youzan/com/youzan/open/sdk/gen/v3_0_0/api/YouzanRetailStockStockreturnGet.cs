using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockStockreturnGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockreturnGetResult;
    using YouzanRetailStockStockreturnGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockStockreturnGetParams;

    public class YouzanRetailStockStockreturnGet : AbstractAPI <YouzanRetailStockStockreturnGetParams, YouzanRetailStockStockreturnGetResult>
	{

		public YouzanRetailStockStockreturnGet()
		{
		}

		public YouzanRetailStockStockreturnGet(YouzanRetailStockStockreturnGetParams apiParams)
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
				return "youzan.retail.stock.stockreturn.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockreturnGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockStockreturnGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}