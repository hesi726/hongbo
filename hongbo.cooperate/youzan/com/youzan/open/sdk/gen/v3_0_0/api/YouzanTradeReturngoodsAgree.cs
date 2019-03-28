using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeReturngoodsAgreeResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeReturngoodsAgreeResult;
    using YouzanTradeReturngoodsAgreeParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeReturngoodsAgreeParams;

    public class YouzanTradeReturngoodsAgree : AbstractAPI <YouzanTradeReturngoodsAgreeParams, YouzanTradeReturngoodsAgreeResult>
	{

		public YouzanTradeReturngoodsAgree()
		{
		}

		public YouzanTradeReturngoodsAgree(YouzanTradeReturngoodsAgreeParams apiParams)
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
				return "youzan.trade.returngoods.agree";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeReturngoodsAgreeResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeReturngoodsAgreeParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}