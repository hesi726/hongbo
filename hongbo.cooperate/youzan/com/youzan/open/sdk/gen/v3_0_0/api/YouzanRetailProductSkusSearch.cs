using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductSkusSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkusSearchResult;
    using YouzanRetailProductSkusSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkusSearchParams;

    public class YouzanRetailProductSkusSearch : AbstractAPI <YouzanRetailProductSkusSearchParams, YouzanRetailProductSkusSearchResult>
	{

		public YouzanRetailProductSkusSearch()
		{
		}

		public YouzanRetailProductSkusSearch(YouzanRetailProductSkusSearchParams apiParams)
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
				return "youzan.retail.product.skus.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkusSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkusSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}