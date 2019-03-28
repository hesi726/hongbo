using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsExpressGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsExpressGetResult;
    using YouzanLogisticsExpressGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsExpressGetParams;

    public class YouzanLogisticsExpressGet : AbstractAPI <YouzanLogisticsExpressGetParams, YouzanLogisticsExpressGetResult>
	{

		public YouzanLogisticsExpressGet()
		{
		}

		public YouzanLogisticsExpressGet(YouzanLogisticsExpressGetParams apiParams)
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
				return "youzan.logistics.express.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsExpressGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsExpressGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}