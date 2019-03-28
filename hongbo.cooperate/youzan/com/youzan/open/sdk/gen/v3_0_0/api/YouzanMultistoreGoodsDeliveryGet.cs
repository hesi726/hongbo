using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreGoodsDeliveryGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsDeliveryGetResult;
    using YouzanMultistoreGoodsDeliveryGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsDeliveryGetParams;

    public class YouzanMultistoreGoodsDeliveryGet : AbstractAPI <YouzanMultistoreGoodsDeliveryGetParams, YouzanMultistoreGoodsDeliveryGetResult>
	{

		public YouzanMultistoreGoodsDeliveryGet()
		{
		}

		public YouzanMultistoreGoodsDeliveryGet(YouzanMultistoreGoodsDeliveryGetParams apiParams)
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
				return "youzan.multistore.goods.delivery.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsDeliveryGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsDeliveryGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}