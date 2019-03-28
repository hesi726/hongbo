using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsSettingUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsSettingUpdateResult;
    using YouzanLogisticsSettingUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsSettingUpdateParams;

    public class YouzanLogisticsSettingUpdate : AbstractAPI <YouzanLogisticsSettingUpdateParams, YouzanLogisticsSettingUpdateResult>
	{

		public YouzanLogisticsSettingUpdate()
		{
		}

		public YouzanLogisticsSettingUpdate(YouzanLogisticsSettingUpdateParams apiParams)
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
				return "youzan.logistics.setting.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsSettingUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsSettingUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}