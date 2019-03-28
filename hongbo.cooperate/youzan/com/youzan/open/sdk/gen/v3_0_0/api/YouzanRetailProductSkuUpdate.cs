using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductSkuUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkuUpdateResult;
    using YouzanRetailProductSkuUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkuUpdateParams;

    public class YouzanRetailProductSkuUpdate : AbstractAPI <YouzanRetailProductSkuUpdateParams, YouzanRetailProductSkuUpdateResult>
	{

		public YouzanRetailProductSkuUpdate()
		{
		}

		public YouzanRetailProductSkuUpdate(YouzanRetailProductSkuUpdateParams apiParams)
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
				return "youzan.retail.product.sku.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkuUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkuUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}