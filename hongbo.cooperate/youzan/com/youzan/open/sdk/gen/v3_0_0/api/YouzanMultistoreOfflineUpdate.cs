using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreOfflineUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineUpdateResult;
    using YouzanMultistoreOfflineUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineUpdateParams;

    public class YouzanMultistoreOfflineUpdate : AbstractAPI <YouzanMultistoreOfflineUpdateParams, YouzanMultistoreOfflineUpdateResult>
	{

		public YouzanMultistoreOfflineUpdate()
		{
		}

		public YouzanMultistoreOfflineUpdate(YouzanMultistoreOfflineUpdateParams apiParams)
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
				return "youzan.multistore.offline.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}