using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductSkuGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkuGetResult;
    using YouzanRetailProductSkuGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkuGetParams;

    public class YouzanRetailProductSkuGet : AbstractAPI <YouzanRetailProductSkuGetParams, YouzanRetailProductSkuGetResult>
	{

		public YouzanRetailProductSkuGet()
		{
		}

		public YouzanRetailProductSkuGet(YouzanRetailProductSkuGetParams apiParams)
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
				return "youzan.retail.product.sku.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkuGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkuGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}