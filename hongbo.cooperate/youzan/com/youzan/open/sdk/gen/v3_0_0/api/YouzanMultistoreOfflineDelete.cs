using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreOfflineDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineDeleteResult;
    using YouzanMultistoreOfflineDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineDeleteParams;

    public class YouzanMultistoreOfflineDelete : AbstractAPI <YouzanMultistoreOfflineDeleteParams, YouzanMultistoreOfflineDeleteResult>
	{

		public YouzanMultistoreOfflineDelete()
		{
		}

		public YouzanMultistoreOfflineDelete(YouzanMultistoreOfflineDeleteParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "POST";
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
				return "youzan.multistore.offline.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}