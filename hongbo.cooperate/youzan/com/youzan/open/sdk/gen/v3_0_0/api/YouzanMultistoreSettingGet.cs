using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreSettingGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreSettingGetResult;
    using YouzanMultistoreSettingGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreSettingGetParams;

    public class YouzanMultistoreSettingGet : AbstractAPI <YouzanMultistoreSettingGetParams, YouzanMultistoreSettingGetResult>
	{

		public YouzanMultistoreSettingGet()
		{
		}

		public YouzanMultistoreSettingGet(YouzanMultistoreSettingGetParams apiParams)
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
				return "youzan.multistore.setting.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreSettingGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreSettingGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}