using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsSettingGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsSettingGetResult;
    using YouzanLogisticsSettingGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsSettingGetParams;

    public class YouzanLogisticsSettingGet : AbstractAPI <YouzanLogisticsSettingGetParams, YouzanLogisticsSettingGetResult>
	{

		public YouzanLogisticsSettingGet()
		{
		}

		public YouzanLogisticsSettingGet(YouzanLogisticsSettingGetParams apiParams)
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
				return "youzan.logistics.setting.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsSettingGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsSettingGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}