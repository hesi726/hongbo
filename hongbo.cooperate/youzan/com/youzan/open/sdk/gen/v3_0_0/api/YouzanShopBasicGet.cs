using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopBasicGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopBasicGetResult;
    using YouzanShopBasicGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopBasicGetParams;

    public class YouzanShopBasicGet : AbstractAPI <YouzanShopBasicGetParams, YouzanShopBasicGetResult>
	{

		public YouzanShopBasicGet()
		{
		}

		public YouzanShopBasicGet(YouzanShopBasicGetParams apiParams)
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
				return "youzan.shop.basic.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopBasicGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopBasicGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}