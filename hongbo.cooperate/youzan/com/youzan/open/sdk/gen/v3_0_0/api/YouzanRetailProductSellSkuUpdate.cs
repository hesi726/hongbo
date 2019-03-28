using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductSellSkuUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSellSkuUpdateResult;
    using YouzanRetailProductSellSkuUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSellSkuUpdateParams;

    public class YouzanRetailProductSellSkuUpdate : AbstractAPI <YouzanRetailProductSellSkuUpdateParams, YouzanRetailProductSellSkuUpdateResult>
	{

		public YouzanRetailProductSellSkuUpdate()
		{
		}

		public YouzanRetailProductSellSkuUpdate(YouzanRetailProductSellSkuUpdateParams apiParams)
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
				return "youzan.retail.product.sell.sku.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSellSkuUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSellSkuUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}