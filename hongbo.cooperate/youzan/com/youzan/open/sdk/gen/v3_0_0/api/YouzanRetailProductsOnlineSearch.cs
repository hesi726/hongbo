using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductsOnlineSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOnlineSearchResult;
    using YouzanRetailProductsOnlineSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOnlineSearchParams;

    public class YouzanRetailProductsOnlineSearch : AbstractAPI <YouzanRetailProductsOnlineSearchParams, YouzanRetailProductsOnlineSearchResult>
	{

		public YouzanRetailProductsOnlineSearch()
		{
		}

		public YouzanRetailProductsOnlineSearch(YouzanRetailProductsOnlineSearchParams apiParams)
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
				return "youzan.retail.products.online.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOnlineSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOnlineSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}