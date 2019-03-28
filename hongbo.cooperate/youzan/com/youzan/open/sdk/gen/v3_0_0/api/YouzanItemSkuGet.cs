using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemSkuGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemSkuGetResult;
    using YouzanItemSkuGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemSkuGetParams;

    public class YouzanItemSkuGet : AbstractAPI <YouzanItemSkuGetParams, YouzanItemSkuGetResult>
	{

		public YouzanItemSkuGet()
		{
		}

		public YouzanItemSkuGet(YouzanItemSkuGetParams apiParams)
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
				return "youzan.item.sku.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemSkuGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemSkuGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}