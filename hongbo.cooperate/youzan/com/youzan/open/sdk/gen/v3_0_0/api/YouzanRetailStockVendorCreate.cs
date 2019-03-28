using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailStockVendorCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockVendorCreateResult;
    using YouzanRetailStockVendorCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailStockVendorCreateParams;

    public class YouzanRetailStockVendorCreate : AbstractAPI <YouzanRetailStockVendorCreateParams, YouzanRetailStockVendorCreateResult>
	{

		public YouzanRetailStockVendorCreate()
		{
		}

		public YouzanRetailStockVendorCreate(YouzanRetailStockVendorCreateParams apiParams)
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
				return "youzan.retail.stock.vendor.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailStockVendorCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailStockVendorCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}