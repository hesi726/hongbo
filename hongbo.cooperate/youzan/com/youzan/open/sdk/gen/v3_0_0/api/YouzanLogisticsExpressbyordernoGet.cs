using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsExpressbyordernoGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsExpressbyordernoGetResult;
    using YouzanLogisticsExpressbyordernoGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsExpressbyordernoGetParams;

    public class YouzanLogisticsExpressbyordernoGet : AbstractAPI <YouzanLogisticsExpressbyordernoGetParams, YouzanLogisticsExpressbyordernoGetResult>
	{

		public YouzanLogisticsExpressbyordernoGet()
		{
		}

		public YouzanLogisticsExpressbyordernoGet(YouzanLogisticsExpressbyordernoGetParams apiParams)
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
				return "youzan.logistics.expressbyorderno.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsExpressbyordernoGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsExpressbyordernoGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}