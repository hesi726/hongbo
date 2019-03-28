using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeConfirmReceiveUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeConfirmReceiveUpdateResult;
    using YouzanTradeConfirmReceiveUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeConfirmReceiveUpdateParams;

    public class YouzanTradeConfirmReceiveUpdate : AbstractAPI <YouzanTradeConfirmReceiveUpdateParams, YouzanTradeConfirmReceiveUpdateResult>
	{

		public YouzanTradeConfirmReceiveUpdate()
		{
		}

		public YouzanTradeConfirmReceiveUpdate(YouzanTradeConfirmReceiveUpdateParams apiParams)
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
				return "youzan.trade.confirm.receive.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeConfirmReceiveUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeConfirmReceiveUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}