using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockVendorUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockVendorUpdateResult;
    using YouzanRetailStockVendorUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockVendorUpdateParams;

    public class YouzanRetailStockVendorUpdate : AbstractAPI <YouzanRetailStockVendorUpdateParams, YouzanRetailStockVendorUpdateResult>
	{

		public YouzanRetailStockVendorUpdate()
		{
		}

		public YouzanRetailStockVendorUpdate(YouzanRetailStockVendorUpdateParams apiParams)
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
				return "youzan.retail.stock.vendor.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockVendorUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockVendorUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}