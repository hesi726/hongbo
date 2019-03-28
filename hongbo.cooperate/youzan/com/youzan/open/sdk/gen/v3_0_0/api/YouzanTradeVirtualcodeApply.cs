using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeVirtualcodeApplyResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeVirtualcodeApplyResult;
    using YouzanTradeVirtualcodeApplyParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeVirtualcodeApplyParams;

    public class YouzanTradeVirtualcodeApply : AbstractAPI <YouzanTradeVirtualcodeApplyParams, YouzanTradeVirtualcodeApplyResult>
	{

		public YouzanTradeVirtualcodeApply()
		{
		}

		public YouzanTradeVirtualcodeApply(YouzanTradeVirtualcodeApplyParams apiParams)
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
				return "youzan.trade.virtualcode.apply";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeVirtualcodeApplyResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeVirtualcodeApplyParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}