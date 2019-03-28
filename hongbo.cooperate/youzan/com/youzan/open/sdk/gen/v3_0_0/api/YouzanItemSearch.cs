using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemSearchResult;
    using YouzanItemSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemSearchParams;

    public class YouzanItemSearch : AbstractAPI <YouzanItemSearchParams, YouzanItemSearchResult>
	{

		public YouzanItemSearch()
		{
		}

		public YouzanItemSearch(YouzanItemSearchParams apiParams)
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
				return "youzan.item.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}