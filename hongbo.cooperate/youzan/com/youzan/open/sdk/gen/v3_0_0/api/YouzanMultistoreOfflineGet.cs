using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreOfflineGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineGetResult;
    using YouzanMultistoreOfflineGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineGetParams;

    public class YouzanMultistoreOfflineGet : AbstractAPI <YouzanMultistoreOfflineGetParams, YouzanMultistoreOfflineGetResult>
	{

		public YouzanMultistoreOfflineGet()
		{
		}

		public YouzanMultistoreOfflineGet(YouzanMultistoreOfflineGetParams apiParams)
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
				return "youzan.multistore.offline.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}