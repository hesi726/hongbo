using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsOnlineCanceldelayResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsOnlineCanceldelayResult;
    using YouzanLogisticsOnlineCanceldelayParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsOnlineCanceldelayParams;

    public class YouzanLogisticsOnlineCanceldelay : AbstractAPI <YouzanLogisticsOnlineCanceldelayParams, YouzanLogisticsOnlineCanceldelayResult>
	{

		public YouzanLogisticsOnlineCanceldelay()
		{
		}

		public YouzanLogisticsOnlineCanceldelay(YouzanLogisticsOnlineCanceldelayParams apiParams)
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
				return "youzan.logistics.online.canceldelay";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsOnlineCanceldelayResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsOnlineCanceldelayParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}