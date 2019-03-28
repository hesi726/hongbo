using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductUnitsSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductUnitsSearchResult;
    using YouzanRetailProductUnitsSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductUnitsSearchParams;

    public class YouzanRetailProductUnitsSearch : AbstractAPI <YouzanRetailProductUnitsSearchParams, YouzanRetailProductUnitsSearchResult>
	{

		public YouzanRetailProductUnitsSearch()
		{
		}

		public YouzanRetailProductUnitsSearch(YouzanRetailProductUnitsSearchParams apiParams)
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
				return "youzan.retail.product.units.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductUnitsSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductUnitsSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}