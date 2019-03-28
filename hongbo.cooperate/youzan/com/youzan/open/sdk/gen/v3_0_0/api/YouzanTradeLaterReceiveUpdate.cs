using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeLaterReceiveUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeLaterReceiveUpdateResult;
    using YouzanTradeLaterReceiveUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeLaterReceiveUpdateParams;

    public class YouzanTradeLaterReceiveUpdate : AbstractAPI <YouzanTradeLaterReceiveUpdateParams, YouzanTradeLaterReceiveUpdateResult>
	{

		public YouzanTradeLaterReceiveUpdate()
		{
		}

		public YouzanTradeLaterReceiveUpdate(YouzanTradeLaterReceiveUpdateParams apiParams)
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
				return "youzan.trade.later.receive.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeLaterReceiveUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeLaterReceiveUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}