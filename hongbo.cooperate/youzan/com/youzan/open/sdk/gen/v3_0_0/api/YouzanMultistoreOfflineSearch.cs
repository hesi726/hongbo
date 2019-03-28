using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreOfflineSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineSearchResult;
    using YouzanMultistoreOfflineSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineSearchParams;

    public class YouzanMultistoreOfflineSearch : AbstractAPI <YouzanMultistoreOfflineSearchParams, YouzanMultistoreOfflineSearchResult>
	{

		public YouzanMultistoreOfflineSearch()
		{
		}

		public YouzanMultistoreOfflineSearch(YouzanMultistoreOfflineSearchParams apiParams)
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
				return "youzan.multistore.offline.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}