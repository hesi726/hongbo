using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopAddressCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressCreateResult;
    using YouzanShopAddressCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressCreateParams;

    public class YouzanShopAddressCreate : AbstractAPI <YouzanShopAddressCreateParams, YouzanShopAddressCreateResult>
	{

		public YouzanShopAddressCreate()
		{
		}

		public YouzanShopAddressCreate(YouzanShopAddressCreateParams apiParams)
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
				return "youzan.shop.address.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopAddressCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopAddressCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}