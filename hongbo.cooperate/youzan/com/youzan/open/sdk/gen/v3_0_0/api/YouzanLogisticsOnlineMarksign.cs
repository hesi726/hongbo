using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsOnlineMarksignResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsOnlineMarksignResult;
    using YouzanLogisticsOnlineMarksignParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsOnlineMarksignParams;

    public class YouzanLogisticsOnlineMarksign : AbstractAPI <YouzanLogisticsOnlineMarksignParams, YouzanLogisticsOnlineMarksignResult>
	{

		public YouzanLogisticsOnlineMarksign()
		{
		}

		public YouzanLogisticsOnlineMarksign(YouzanLogisticsOnlineMarksignParams apiParams)
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
				return "youzan.logistics.online.marksign";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsOnlineMarksignResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsOnlineMarksignParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}