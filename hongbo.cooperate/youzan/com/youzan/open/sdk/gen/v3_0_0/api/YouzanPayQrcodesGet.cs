using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayQrcodesGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayQrcodesGetResult;
    using YouzanPayQrcodesGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayQrcodesGetParams;

    public class YouzanPayQrcodesGet : AbstractAPI <YouzanPayQrcodesGetParams, YouzanPayQrcodesGetResult>
	{

		public YouzanPayQrcodesGet()
		{
		}

		public YouzanPayQrcodesGet(YouzanPayQrcodesGetParams apiParams)
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
				return "youzan.pay.qrcodes.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayQrcodesGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayQrcodesGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}