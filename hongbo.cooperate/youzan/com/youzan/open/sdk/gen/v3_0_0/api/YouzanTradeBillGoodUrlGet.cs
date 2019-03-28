using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeBillGoodUrlGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeBillGoodUrlGetResult;
    using YouzanTradeBillGoodUrlGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeBillGoodUrlGetParams;

    public class YouzanTradeBillGoodUrlGet : AbstractAPI <YouzanTradeBillGoodUrlGetParams, YouzanTradeBillGoodUrlGetResult>
	{

		public YouzanTradeBillGoodUrlGet()
		{
		}

		public YouzanTradeBillGoodUrlGet(YouzanTradeBillGoodUrlGetParams apiParams)
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
				return "youzan.trade.bill.good.url.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeBillGoodUrlGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeBillGoodUrlGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}