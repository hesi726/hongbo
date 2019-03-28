using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductsOfflineSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOfflineSearchResult;
    using YouzanRetailProductsOfflineSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductsOfflineSearchParams;

    public class YouzanRetailProductsOfflineSearch : AbstractAPI <YouzanRetailProductsOfflineSearchParams, YouzanRetailProductsOfflineSearchResult>
	{

		public YouzanRetailProductsOfflineSearch()
		{
		}

		public YouzanRetailProductsOfflineSearch(YouzanRetailProductsOfflineSearchParams apiParams)
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
				return "youzan.retail.products.offline.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOfflineSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductsOfflineSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}