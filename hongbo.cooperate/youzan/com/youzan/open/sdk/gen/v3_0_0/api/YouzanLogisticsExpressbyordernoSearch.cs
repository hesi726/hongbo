using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsExpressbyordernoSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsExpressbyordernoSearchResult;
    using YouzanLogisticsExpressbyordernoSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsExpressbyordernoSearchParams;

    public class YouzanLogisticsExpressbyordernoSearch : AbstractAPI <YouzanLogisticsExpressbyordernoSearchParams, YouzanLogisticsExpressbyordernoSearchResult>
	{

		public YouzanLogisticsExpressbyordernoSearch()
		{
		}

		public YouzanLogisticsExpressbyordernoSearch(YouzanLogisticsExpressbyordernoSearchParams apiParams)
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
				return "youzan.logistics.expressbyorderno.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsExpressbyordernoSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsExpressbyordernoSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}