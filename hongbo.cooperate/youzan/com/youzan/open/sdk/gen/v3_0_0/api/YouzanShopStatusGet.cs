using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopStatusGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopStatusGetResult;
    using YouzanShopStatusGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopStatusGetParams;

    public class YouzanShopStatusGet : AbstractAPI <YouzanShopStatusGetParams, YouzanShopStatusGetResult>
	{

		public YouzanShopStatusGet()
		{
		}

		public YouzanShopStatusGet(YouzanShopStatusGetParams apiParams)
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
				return "youzan.shop.status.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopStatusGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopStatusGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}