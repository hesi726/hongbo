using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductsOnlineDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOnlineDeleteResult;
    using YouzanRetailProductsOnlineDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOnlineDeleteParams;

    public class YouzanRetailProductsOnlineDelete : AbstractAPI <YouzanRetailProductsOnlineDeleteParams, YouzanRetailProductsOnlineDeleteResult>
	{

		public YouzanRetailProductsOnlineDelete()
		{
		}

		public YouzanRetailProductsOnlineDelete(YouzanRetailProductsOnlineDeleteParams apiParams)
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
				return "youzan.retail.products.online.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOnlineDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOnlineDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}