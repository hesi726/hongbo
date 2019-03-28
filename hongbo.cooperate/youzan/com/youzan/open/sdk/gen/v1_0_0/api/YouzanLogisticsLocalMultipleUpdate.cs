using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsLocalMultipleUpdateResult = com.youzan.open.sdk.gen.v1_0_0.model.YouzanLogisticsLocalMultipleUpdateResult;
    using YouzanLogisticsLocalMultipleUpdateParams = com.youzan.open.sdk.gen.v1_0_0.model.YouzanLogisticsLocalMultipleUpdateParams;

    public class YouzanLogisticsLocalMultipleUpdate : AbstractAPI <YouzanLogisticsLocalMultipleUpdateParams, YouzanLogisticsLocalMultipleUpdateResult>
	{

		public YouzanLogisticsLocalMultipleUpdate()
		{
		}

		public YouzanLogisticsLocalMultipleUpdate(YouzanLogisticsLocalMultipleUpdateParams apiParams)
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
				return "1.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.logistics.local.multiple.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsLocalMultipleUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsLocalMultipleUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}