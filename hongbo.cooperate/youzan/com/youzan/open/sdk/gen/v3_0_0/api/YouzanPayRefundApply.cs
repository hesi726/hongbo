using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayRefundApplyResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayRefundApplyResult;
    using YouzanPayRefundApplyParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayRefundApplyParams;

    public class YouzanPayRefundApply : AbstractAPI <YouzanPayRefundApplyParams, YouzanPayRefundApplyResult>
	{

		public YouzanPayRefundApply()
		{
		}

		public YouzanPayRefundApply(YouzanPayRefundApplyParams apiParams)
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
				return "youzan.pay.refund.apply";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayRefundApplyResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayRefundApplyParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}