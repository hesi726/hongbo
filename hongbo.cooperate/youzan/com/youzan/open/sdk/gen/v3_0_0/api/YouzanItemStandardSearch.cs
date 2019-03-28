using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemStandardSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemStandardSearchResult;
    using YouzanItemStandardSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemStandardSearchParams;

    public class YouzanItemStandardSearch : AbstractAPI <YouzanItemStandardSearchParams, YouzanItemStandardSearchResult>
	{

		public YouzanItemStandardSearch()
		{
		}

		public YouzanItemStandardSearch(YouzanItemStandardSearchParams apiParams)
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
				return "youzan.item.standard.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemStandardSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemStandardSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}