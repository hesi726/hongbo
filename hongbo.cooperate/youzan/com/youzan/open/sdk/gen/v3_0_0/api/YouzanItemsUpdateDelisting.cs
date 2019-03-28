using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemsUpdateDelistingResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsUpdateDelistingResult;
    using YouzanItemsUpdateDelistingParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsUpdateDelistingParams;

    public class YouzanItemsUpdateDelisting : AbstractAPI <YouzanItemsUpdateDelistingParams, YouzanItemsUpdateDelistingResult>
	{

		public YouzanItemsUpdateDelisting()
		{
		}

		public YouzanItemsUpdateDelisting(YouzanItemsUpdateDelistingParams apiParams)
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
				return "youzan.items.update.delisting";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemsUpdateDelistingResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemsUpdateDelistingParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}