using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopAddressGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressGetResult;
    using YouzanShopAddressGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressGetParams;

    public class YouzanShopAddressGet : AbstractAPI <YouzanShopAddressGetParams, YouzanShopAddressGetResult>
	{

		public YouzanShopAddressGet()
		{
		}

		public YouzanShopAddressGet(YouzanShopAddressGetParams apiParams)
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
				return "youzan.shop.address.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopAddressGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopAddressGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}