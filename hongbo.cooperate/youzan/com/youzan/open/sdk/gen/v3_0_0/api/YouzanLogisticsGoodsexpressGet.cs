using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanLogisticsGoodsexpressGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsGoodsexpressGetResult;
    using YouzanLogisticsGoodsexpressGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanLogisticsGoodsexpressGetParams;

    public class YouzanLogisticsGoodsexpressGet : AbstractAPI <YouzanLogisticsGoodsexpressGetParams, YouzanLogisticsGoodsexpressGetResult>
	{

		public YouzanLogisticsGoodsexpressGet()
		{
		}

		public YouzanLogisticsGoodsexpressGet(YouzanLogisticsGoodsexpressGetParams apiParams)
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
				return "youzan.logistics.goodsexpress.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanLogisticsGoodsexpressGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanLogisticsGoodsexpressGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}