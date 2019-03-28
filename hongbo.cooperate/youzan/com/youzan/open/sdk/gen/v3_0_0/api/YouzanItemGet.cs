using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemGetResult;
    using YouzanItemGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemGetParams;

    public class YouzanItemGet : AbstractAPI <YouzanItemGetParams, YouzanItemGetResult>
	{

		public YouzanItemGet()
		{
		}

		public YouzanItemGet(YouzanItemGetParams apiParams)
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
				return "youzan.item.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}