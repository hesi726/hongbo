using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemUpdateDelistingResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemUpdateDelistingResult;
    using YouzanItemUpdateDelistingParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemUpdateDelistingParams;

    public class YouzanItemUpdateDelisting : AbstractAPI <YouzanItemUpdateDelistingParams, YouzanItemUpdateDelistingResult>
	{

		public YouzanItemUpdateDelisting()
		{
		}

		public YouzanItemUpdateDelisting(YouzanItemUpdateDelistingParams apiParams)
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
				return "youzan.item.update.delisting";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemUpdateDelistingResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemUpdateDelistingParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}