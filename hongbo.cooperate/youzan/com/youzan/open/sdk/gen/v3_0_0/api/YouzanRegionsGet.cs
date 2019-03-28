using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRegionsGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRegionsGetResult;
    using YouzanRegionsGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRegionsGetParams;

    public class YouzanRegionsGet : AbstractAPI <YouzanRegionsGetParams, YouzanRegionsGetResult>
	{

		public YouzanRegionsGet()
		{
		}

		public YouzanRegionsGet(YouzanRegionsGetParams apiParams)
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
				return "youzan.regions.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRegionsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRegionsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}