using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsTemplateSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsTemplateSearchResult;
    using YouzanLogisticsTemplateSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsTemplateSearchParams;

    public class YouzanLogisticsTemplateSearch : AbstractAPI <YouzanLogisticsTemplateSearchParams, YouzanLogisticsTemplateSearchResult>
	{

		public YouzanLogisticsTemplateSearch()
		{
		}

		public YouzanLogisticsTemplateSearch(YouzanLogisticsTemplateSearchParams apiParams)
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
				return "youzan.logistics.template.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsTemplateSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsTemplateSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}