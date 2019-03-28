using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpPromocodeBuyerSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocodeBuyerSearchResult;
    using YouzanUmpPromocodeBuyerSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocodeBuyerSearchParams;

    public class YouzanUmpPromocodeBuyerSearch : AbstractAPI <YouzanUmpPromocodeBuyerSearchParams, YouzanUmpPromocodeBuyerSearchResult>
	{

		public YouzanUmpPromocodeBuyerSearch()
		{
		}

		public YouzanUmpPromocodeBuyerSearch(YouzanUmpPromocodeBuyerSearchParams apiParams)
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
				return "youzan.ump.promocode.buyer.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocodeBuyerSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocodeBuyerSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}