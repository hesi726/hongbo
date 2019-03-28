using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeQrcodeHasoutidGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeQrcodeHasoutidGetResult;
    using YouzanTradeQrcodeHasoutidGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeQrcodeHasoutidGetParams;

    public class YouzanTradeQrcodeHasoutidGet : AbstractAPI <YouzanTradeQrcodeHasoutidGetParams, YouzanTradeQrcodeHasoutidGetResult>
	{

		public YouzanTradeQrcodeHasoutidGet()
		{
		}

		public YouzanTradeQrcodeHasoutidGet(YouzanTradeQrcodeHasoutidGetParams apiParams)
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
				return "youzan.trade.qrcode.hasoutid.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeQrcodeHasoutidGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeQrcodeHasoutidGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}