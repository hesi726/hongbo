using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreGoodsDeliveryUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsDeliveryUpdateResult;
    using YouzanMultistoreGoodsDeliveryUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsDeliveryUpdateParams;

    public class YouzanMultistoreGoodsDeliveryUpdate : AbstractAPI <YouzanMultistoreGoodsDeliveryUpdateParams, YouzanMultistoreGoodsDeliveryUpdateResult>
	{

		public YouzanMultistoreGoodsDeliveryUpdate()
		{
		}

		public YouzanMultistoreGoodsDeliveryUpdate(YouzanMultistoreGoodsDeliveryUpdateParams apiParams)
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
				return "youzan.multistore.goods.delivery.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsDeliveryUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsDeliveryUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}