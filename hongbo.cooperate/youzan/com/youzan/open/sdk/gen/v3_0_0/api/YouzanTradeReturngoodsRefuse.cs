using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeReturngoodsRefuseResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeReturngoodsRefuseResult;
    using YouzanTradeReturngoodsRefuseParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeReturngoodsRefuseParams;

    public class YouzanTradeReturngoodsRefuse : AbstractAPI <YouzanTradeReturngoodsRefuseParams, YouzanTradeReturngoodsRefuseResult>
	{

		public YouzanTradeReturngoodsRefuse()
		{
		}

		public YouzanTradeReturngoodsRefuse(YouzanTradeReturngoodsRefuseParams apiParams)
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
				return "youzan.trade.returngoods.refuse";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeReturngoodsRefuseResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeReturngoodsRefuseParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}