using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsLocalGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsLocalGetResult;
    using YouzanLogisticsLocalGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsLocalGetParams;

    public class YouzanLogisticsLocalGet : AbstractAPI <YouzanLogisticsLocalGetParams, YouzanLogisticsLocalGetResult>
	{

		public YouzanLogisticsLocalGet()
		{
		}

		public YouzanLogisticsLocalGet(YouzanLogisticsLocalGetParams apiParams)
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
				return "youzan.logistics.local.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsLocalGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsLocalGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}