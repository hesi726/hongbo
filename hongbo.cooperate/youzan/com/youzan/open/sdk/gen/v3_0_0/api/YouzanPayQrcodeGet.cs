using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayQrcodeGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayQrcodeGetResult;
    using YouzanPayQrcodeGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayQrcodeGetParams;

    public class YouzanPayQrcodeGet : AbstractAPI <YouzanPayQrcodeGetParams, YouzanPayQrcodeGetResult>
	{

		public YouzanPayQrcodeGet()
		{
		}

		public YouzanPayQrcodeGet(YouzanPayQrcodeGetParams apiParams)
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
				return "youzan.pay.qrcode.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayQrcodeGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayQrcodeGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}