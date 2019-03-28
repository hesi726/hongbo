using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeSelffetchcodeApplyResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeSelffetchcodeApplyResult;
    using YouzanTradeSelffetchcodeApplyParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeSelffetchcodeApplyParams;

    public class YouzanTradeSelffetchcodeApply : AbstractAPI <YouzanTradeSelffetchcodeApplyParams, YouzanTradeSelffetchcodeApplyResult>
	{

		public YouzanTradeSelffetchcodeApply()
		{
		}

		public YouzanTradeSelffetchcodeApply(YouzanTradeSelffetchcodeApplyParams apiParams)
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
				return "youzan.trade.selffetchcode.apply";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeSelffetchcodeApplyResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeSelffetchcodeApplyParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}