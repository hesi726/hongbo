using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopAddressListResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressListResult;
    using YouzanShopAddressListParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressListParams;

    public class YouzanShopAddressList : AbstractAPI <YouzanShopAddressListParams, YouzanShopAddressListResult>
	{

		public YouzanShopAddressList()
		{
		}

		public YouzanShopAddressList(YouzanShopAddressListParams apiParams)
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
				return "youzan.shop.address.list";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopAddressListResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopAddressListParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}