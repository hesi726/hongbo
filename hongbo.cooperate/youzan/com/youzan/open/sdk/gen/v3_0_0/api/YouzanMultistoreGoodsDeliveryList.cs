using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreGoodsDeliveryListResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsDeliveryListResult;
    using YouzanMultistoreGoodsDeliveryListParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsDeliveryListParams;

    public class YouzanMultistoreGoodsDeliveryList : AbstractAPI <YouzanMultistoreGoodsDeliveryListParams, YouzanMultistoreGoodsDeliveryListResult>
	{

		public YouzanMultistoreGoodsDeliveryList()
		{
		}

		public YouzanMultistoreGoodsDeliveryList(YouzanMultistoreGoodsDeliveryListParams apiParams)
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
				return "youzan.multistore.goods.delivery.list";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsDeliveryListResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsDeliveryListParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}