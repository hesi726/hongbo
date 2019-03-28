using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductsOnlineDisplayResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOnlineDisplayResult;
    using YouzanRetailProductsOnlineDisplayParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOnlineDisplayParams;

    public class YouzanRetailProductsOnlineDisplay : AbstractAPI <YouzanRetailProductsOnlineDisplayParams, YouzanRetailProductsOnlineDisplayResult>
	{

		public YouzanRetailProductsOnlineDisplay()
		{
		}

		public YouzanRetailProductsOnlineDisplay(YouzanRetailProductsOnlineDisplayParams apiParams)
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
				return "youzan.retail.products.online.display";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOnlineDisplayResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOnlineDisplayParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}