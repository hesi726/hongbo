using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeQrcodeExtCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeQrcodeExtCreateResult;
    using YouzanTradeQrcodeExtCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeQrcodeExtCreateParams;

    public class YouzanTradeQrcodeExtCreate : AbstractAPI <YouzanTradeQrcodeExtCreateParams, YouzanTradeQrcodeExtCreateResult>
	{

		public YouzanTradeQrcodeExtCreate()
		{
		}

		public YouzanTradeQrcodeExtCreate(YouzanTradeQrcodeExtCreateParams apiParams)
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
				return "youzan.trade.qrcode.ext.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeQrcodeExtCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeQrcodeExtCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}