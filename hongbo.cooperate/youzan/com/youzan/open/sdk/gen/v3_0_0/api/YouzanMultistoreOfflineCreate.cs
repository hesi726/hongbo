using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreOfflineCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineCreateResult;
    using YouzanMultistoreOfflineCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreOfflineCreateParams;

    public class YouzanMultistoreOfflineCreate : AbstractAPI <YouzanMultistoreOfflineCreateParams, YouzanMultistoreOfflineCreateResult>
	{

		public YouzanMultistoreOfflineCreate()
		{
		}

		public YouzanMultistoreOfflineCreate(YouzanMultistoreOfflineCreateParams apiParams)
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
				return "youzan.multistore.offline.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreOfflineCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}