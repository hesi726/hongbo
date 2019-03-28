using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsLocalSetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsLocalSetResult;
    using YouzanLogisticsLocalSetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsLocalSetParams;

    public class YouzanLogisticsLocalSet : AbstractAPI <YouzanLogisticsLocalSetParams, YouzanLogisticsLocalSetResult>
	{

		public YouzanLogisticsLocalSet()
		{
		}

		public YouzanLogisticsLocalSet(YouzanLogisticsLocalSetParams apiParams)
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
				return "youzan.logistics.local.set";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsLocalSetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsLocalSetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}