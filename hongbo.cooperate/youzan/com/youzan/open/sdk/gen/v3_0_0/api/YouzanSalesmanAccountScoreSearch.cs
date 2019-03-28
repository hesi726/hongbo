using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSalesmanAccountScoreSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanAccountScoreSearchResult;
    using YouzanSalesmanAccountScoreSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSalesmanAccountScoreSearchParams;

    public class YouzanSalesmanAccountScoreSearch : AbstractAPI <YouzanSalesmanAccountScoreSearchParams, YouzanSalesmanAccountScoreSearchResult>
	{

		public YouzanSalesmanAccountScoreSearch()
		{
		}

		public YouzanSalesmanAccountScoreSearch(YouzanSalesmanAccountScoreSearchParams apiParams)
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
				return "youzan.salesman.account.score.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSalesmanAccountScoreSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSalesmanAccountScoreSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}