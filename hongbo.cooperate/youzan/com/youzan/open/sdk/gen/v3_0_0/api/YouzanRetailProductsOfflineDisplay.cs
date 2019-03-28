using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductsOfflineDisplayResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOfflineDisplayResult;
    using YouzanRetailProductsOfflineDisplayParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOfflineDisplayParams;

    public class YouzanRetailProductsOfflineDisplay : AbstractAPI <YouzanRetailProductsOfflineDisplayParams, YouzanRetailProductsOfflineDisplayResult>
	{

		public YouzanRetailProductsOfflineDisplay()
		{
		}

		public YouzanRetailProductsOfflineDisplay(YouzanRetailProductsOfflineDisplayParams apiParams)
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
				return "youzan.retail.products.offline.display";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOfflineDisplayResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOfflineDisplayParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}