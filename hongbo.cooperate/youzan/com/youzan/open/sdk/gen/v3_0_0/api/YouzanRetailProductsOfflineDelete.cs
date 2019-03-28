using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductsOfflineDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOfflineDeleteResult;
    using YouzanRetailProductsOfflineDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOfflineDeleteParams;

    public class YouzanRetailProductsOfflineDelete : AbstractAPI <YouzanRetailProductsOfflineDeleteParams, YouzanRetailProductsOfflineDeleteResult>
	{

		public YouzanRetailProductsOfflineDelete()
		{
		}

		public YouzanRetailProductsOfflineDelete(YouzanRetailProductsOfflineDeleteParams apiParams)
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
				return "youzan.retail.products.offline.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOfflineDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOfflineDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}