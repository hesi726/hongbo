using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayQrcodeCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayQrcodeCreateResult;
    using YouzanPayQrcodeCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayQrcodeCreateParams;

    public class YouzanPayQrcodeCreate : AbstractAPI <YouzanPayQrcodeCreateParams, YouzanPayQrcodeCreateResult>
	{

		public YouzanPayQrcodeCreate()
		{
		}

		public YouzanPayQrcodeCreate(YouzanPayQrcodeCreateParams apiParams)
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
				return "youzan.pay.qrcode.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayQrcodeCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayQrcodeCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}