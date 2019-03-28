using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemTemplateListSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemTemplateListSearchResult;
    using YouzanItemTemplateListSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemTemplateListSearchParams;

    public class YouzanItemTemplateListSearch : AbstractAPI <YouzanItemTemplateListSearchParams, YouzanItemTemplateListSearchResult>
	{

		public YouzanItemTemplateListSearch()
		{
		}

		public YouzanItemTemplateListSearch(YouzanItemTemplateListSearchParams apiParams)
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
				return "youzan.item.template.list.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemTemplateListSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemTemplateListSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}