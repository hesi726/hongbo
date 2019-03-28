using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockUpdateResult;
    using YouzanRetailStockUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockUpdateParams;

    public class YouzanRetailStockUpdate : AbstractAPI <YouzanRetailStockUpdateParams, YouzanRetailStockUpdateResult>
	{

		public YouzanRetailStockUpdate()
		{
		}

		public YouzanRetailStockUpdate(YouzanRetailStockUpdateParams apiParams)
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
				return "youzan.retail.stock.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}