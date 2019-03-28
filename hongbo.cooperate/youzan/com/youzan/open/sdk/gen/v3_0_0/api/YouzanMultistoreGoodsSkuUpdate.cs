using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreGoodsSkuUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsSkuUpdateResult;
    using YouzanMultistoreGoodsSkuUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsSkuUpdateParams;

    public class YouzanMultistoreGoodsSkuUpdate : AbstractAPI <YouzanMultistoreGoodsSkuUpdateParams, YouzanMultistoreGoodsSkuUpdateResult>
	{

		public YouzanMultistoreGoodsSkuUpdate()
		{
		}

		public YouzanMultistoreGoodsSkuUpdate(YouzanMultistoreGoodsSkuUpdateParams apiParams)
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
				return "youzan.multistore.goods.sku.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsSkuUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsSkuUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}