using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradesQrGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradesQrGetResult;
    using YouzanTradesQrGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradesQrGetParams;

    public class YouzanTradesQrGet : AbstractAPI <YouzanTradesQrGetParams, YouzanTradesQrGetResult>
	{

		public YouzanTradesQrGet()
		{
		}

		public YouzanTradesQrGet(YouzanTradesQrGetParams apiParams)
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
				return "youzan.trades.qr.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradesQrGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradesQrGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}