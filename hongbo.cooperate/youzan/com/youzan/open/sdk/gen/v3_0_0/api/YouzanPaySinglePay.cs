using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPaySinglePayResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySinglePayResult;
    using YouzanPaySinglePayParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySinglePayParams;

    public class YouzanPaySinglePay : AbstractAPI <YouzanPaySinglePayParams, YouzanPaySinglePayResult>
	{

		public YouzanPaySinglePay()
		{
		}

		public YouzanPaySinglePay(YouzanPaySinglePayParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "POST";
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
				return "youzan.pay.single.pay";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPaySinglePayResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPaySinglePayParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}