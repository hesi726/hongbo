using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopGetResult;
    using YouzanShopGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopGetParams;

    public class YouzanShopGet : AbstractAPI <YouzanShopGetParams, YouzanShopGetResult>
	{

		public YouzanShopGet()
		{
		}

		public YouzanShopGet(YouzanShopGetParams apiParams)
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
				return "youzan.shop.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}