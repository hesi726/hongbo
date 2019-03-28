using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCardUrlGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardUrlGetResult;
    using YouzanScrmCardUrlGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardUrlGetParams;

    public class YouzanScrmCardUrlGet : AbstractAPI <YouzanScrmCardUrlGetParams, YouzanScrmCardUrlGetResult>
	{

		public YouzanScrmCardUrlGet()
		{
		}

		public YouzanScrmCardUrlGet(YouzanScrmCardUrlGetParams apiParams)
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
				return "youzan.scrm.card.url.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCardUrlGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCardUrlGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}