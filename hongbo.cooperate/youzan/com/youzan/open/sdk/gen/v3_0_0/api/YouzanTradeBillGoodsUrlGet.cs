using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanTradeBillGoodsUrlGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeBillGoodsUrlGetResult;
    using YouzanTradeBillGoodsUrlGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanTradeBillGoodsUrlGetParams;

    public class YouzanTradeBillGoodsUrlGet : AbstractAPI <YouzanTradeBillGoodsUrlGetParams, YouzanTradeBillGoodsUrlGetResult>
	{

		public YouzanTradeBillGoodsUrlGet()
		{
		}

		public YouzanTradeBillGoodsUrlGet(YouzanTradeBillGoodsUrlGetParams apiParams)
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
				return "youzan.trade.bill.goods.url.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanTradeBillGoodsUrlGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanTradeBillGoodsUrlGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}