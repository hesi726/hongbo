using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMultistoreGoodsSkuGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsSkuGetResult;
    using YouzanMultistoreGoodsSkuGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMultistoreGoodsSkuGetParams;

    public class YouzanMultistoreGoodsSkuGet : AbstractAPI <YouzanMultistoreGoodsSkuGetParams, YouzanMultistoreGoodsSkuGetResult>
	{

		public YouzanMultistoreGoodsSkuGet()
		{
		}

		public YouzanMultistoreGoodsSkuGet(YouzanMultistoreGoodsSkuGetParams apiParams)
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
				return "youzan.multistore.goods.sku.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsSkuGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMultistoreGoodsSkuGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}