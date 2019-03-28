using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPaySettleResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySettleResult;
    using YouzanPaySettleParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySettleParams;

    public class YouzanPaySettle : AbstractAPI <YouzanPaySettleParams, YouzanPaySettleResult>
	{

		public YouzanPaySettle()
		{
		}

		public YouzanPaySettle(YouzanPaySettleParams apiParams)
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
				return "youzan.pay.settle";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPaySettleResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPaySettleParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}