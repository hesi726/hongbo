using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanSkusCustomGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSkusCustomGetResult;
    using YouzanSkusCustomGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanSkusCustomGetParams;

    public class YouzanSkusCustomGet : AbstractAPI <YouzanSkusCustomGetParams, YouzanSkusCustomGetResult>
	{

		public YouzanSkusCustomGet()
		{
		}

		public YouzanSkusCustomGet(YouzanSkusCustomGetParams apiParams)
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
				return "youzan.skus.custom.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanSkusCustomGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanSkusCustomGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}