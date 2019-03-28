using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsGetexpressbyordernoGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsGetexpressbyordernoGetResult;
    using YouzanLogisticsGetexpressbyordernoGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsGetexpressbyordernoGetParams;

    public class YouzanLogisticsGetexpressbyordernoGet : AbstractAPI <YouzanLogisticsGetexpressbyordernoGetParams, YouzanLogisticsGetexpressbyordernoGetResult>
	{

		public YouzanLogisticsGetexpressbyordernoGet()
		{
		}

		public YouzanLogisticsGetexpressbyordernoGet(YouzanLogisticsGetexpressbyordernoGetParams apiParams)
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
				return "youzan.logistics.getexpressbyorderno.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsGetexpressbyordernoGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsGetexpressbyordernoGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}