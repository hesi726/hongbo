using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeBillCancelGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeBillCancelGetResult;
    using YouzanTradeBillCancelGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeBillCancelGetParams;

    public class YouzanTradeBillCancelGet : AbstractAPI <YouzanTradeBillCancelGetParams, YouzanTradeBillCancelGetResult>
	{

		public YouzanTradeBillCancelGet()
		{
		}

		public YouzanTradeBillCancelGet(YouzanTradeBillCancelGetParams apiParams)
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
				return "youzan.trade.bill.cancel.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeBillCancelGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeBillCancelGetParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}