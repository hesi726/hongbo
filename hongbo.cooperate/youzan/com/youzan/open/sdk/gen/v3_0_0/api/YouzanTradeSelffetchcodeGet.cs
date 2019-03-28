using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeSelffetchcodeGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeSelffetchcodeGetResult;
    using YouzanTradeSelffetchcodeGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeSelffetchcodeGetParams;

    public class YouzanTradeSelffetchcodeGet : AbstractAPI <YouzanTradeSelffetchcodeGetParams, YouzanTradeSelffetchcodeGetResult>
	{

		public YouzanTradeSelffetchcodeGet()
		{
		}

		public YouzanTradeSelffetchcodeGet(YouzanTradeSelffetchcodeGetParams apiParams)
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
				return "youzan.trade.selffetchcode.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeSelffetchcodeGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeSelffetchcodeGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}