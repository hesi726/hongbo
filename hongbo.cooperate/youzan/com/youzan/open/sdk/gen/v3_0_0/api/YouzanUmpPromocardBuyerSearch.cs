using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpPromocardBuyerSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocardBuyerSearchResult;
    using YouzanUmpPromocardBuyerSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocardBuyerSearchParams;

    public class YouzanUmpPromocardBuyerSearch : AbstractAPI <YouzanUmpPromocardBuyerSearchParams, YouzanUmpPromocardBuyerSearchResult>
	{

		public YouzanUmpPromocardBuyerSearch()
		{
		}

		public YouzanUmpPromocardBuyerSearch(YouzanUmpPromocardBuyerSearchParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "GET";
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
				return "youzan.ump.promocard.buyer.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocardBuyerSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocardBuyerSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}