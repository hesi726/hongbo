using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductSkuCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkuCreateResult;
    using YouzanRetailProductSkuCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkuCreateParams;

    public class YouzanRetailProductSkuCreate : AbstractAPI <YouzanRetailProductSkuCreateParams, YouzanRetailProductSkuCreateResult>
	{

		public YouzanRetailProductSkuCreate()
		{
		}

		public YouzanRetailProductSkuCreate(YouzanRetailProductSkuCreateParams apiParams)
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
				return "youzan.retail.product.sku.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkuCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkuCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}