using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockVendorGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockVendorGetResult;
    using YouzanRetailStockVendorGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockVendorGetParams;

    public class YouzanRetailStockVendorGet : AbstractAPI <YouzanRetailStockVendorGetParams, YouzanRetailStockVendorGetResult>
	{

		public YouzanRetailStockVendorGet()
		{
		}

		public YouzanRetailStockVendorGet(YouzanRetailStockVendorGetParams apiParams)
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
				return "youzan.retail.stock.vendor.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockVendorGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockVendorGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}