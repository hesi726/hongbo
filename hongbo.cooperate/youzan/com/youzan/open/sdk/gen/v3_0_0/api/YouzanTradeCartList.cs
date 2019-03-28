using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeCartListResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartListResult;
    using YouzanTradeCartListParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeCartListParams;

    public class YouzanTradeCartList : AbstractAPI <YouzanTradeCartListParams, YouzanTradeCartListResult>
	{

		public YouzanTradeCartList()
		{
		}

		public YouzanTradeCartList(YouzanTradeCartListParams apiParams)
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
				return "youzan.trade.cart.list";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeCartListResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeCartListParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}