using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeReturngoodsFillResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeReturngoodsFillResult;
    using YouzanTradeReturngoodsFillParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeReturngoodsFillParams;

    public class YouzanTradeReturngoodsFill : AbstractAPI <YouzanTradeReturngoodsFillParams, YouzanTradeReturngoodsFillResult>
	{

		public YouzanTradeReturngoodsFill()
		{
		}

		public YouzanTradeReturngoodsFill(YouzanTradeReturngoodsFillParams apiParams)
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
				return "youzan.trade.returngoods.fill";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeReturngoodsFillResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeReturngoodsFillParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}