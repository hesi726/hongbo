using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsOnlineDelayResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsOnlineDelayResult;
    using YouzanLogisticsOnlineDelayParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsOnlineDelayParams;

    public class YouzanLogisticsOnlineDelay : AbstractAPI <YouzanLogisticsOnlineDelayParams, YouzanLogisticsOnlineDelayResult>
	{

		public YouzanLogisticsOnlineDelay()
		{
		}

		public YouzanLogisticsOnlineDelay(YouzanLogisticsOnlineDelayParams apiParams)
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
				return "youzan.logistics.online.delay";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsOnlineDelayResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsOnlineDelayParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}