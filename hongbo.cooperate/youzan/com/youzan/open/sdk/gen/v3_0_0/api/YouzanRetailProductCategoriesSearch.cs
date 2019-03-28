using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductCategoriesSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductCategoriesSearchResult;
    using YouzanRetailProductCategoriesSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductCategoriesSearchParams;

    public class YouzanRetailProductCategoriesSearch : AbstractAPI <YouzanRetailProductCategoriesSearchParams, YouzanRetailProductCategoriesSearchResult>
	{

		public YouzanRetailProductCategoriesSearch()
		{
		}

		public YouzanRetailProductCategoriesSearch(YouzanRetailProductCategoriesSearchParams apiParams)
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
				return "youzan.retail.product.categories.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductCategoriesSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductCategoriesSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}