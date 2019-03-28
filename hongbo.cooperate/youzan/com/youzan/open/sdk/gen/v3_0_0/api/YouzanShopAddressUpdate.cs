using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopAddressUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressUpdateResult;
    using YouzanShopAddressUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressUpdateParams;

    public class YouzanShopAddressUpdate : AbstractAPI <YouzanShopAddressUpdateParams, YouzanShopAddressUpdateResult>
	{

		public YouzanShopAddressUpdate()
		{
		}

		public YouzanShopAddressUpdate(YouzanShopAddressUpdateParams apiParams)
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
				return "youzan.shop.address.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopAddressUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopAddressUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}