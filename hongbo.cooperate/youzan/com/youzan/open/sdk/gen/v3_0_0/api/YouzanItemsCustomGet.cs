using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemsCustomGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsCustomGetResult;
    using YouzanItemsCustomGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsCustomGetParams;

    public class YouzanItemsCustomGet : AbstractAPI <YouzanItemsCustomGetParams, YouzanItemsCustomGetResult>
	{

		public YouzanItemsCustomGet()
		{
		}

		public YouzanItemsCustomGet(YouzanItemsCustomGetParams apiParams)
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
				return "youzan.items.custom.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemsCustomGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemsCustomGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}