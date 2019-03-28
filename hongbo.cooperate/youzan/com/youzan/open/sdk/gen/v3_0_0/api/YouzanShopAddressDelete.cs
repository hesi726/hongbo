using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanShopAddressDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressDeleteResult;
    using YouzanShopAddressDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanShopAddressDeleteParams;

    public class YouzanShopAddressDelete : AbstractAPI <YouzanShopAddressDeleteParams, YouzanShopAddressDeleteResult>
	{

		public YouzanShopAddressDelete()
		{
		}

		public YouzanShopAddressDelete(YouzanShopAddressDeleteParams apiParams)
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
				return "youzan.shop.address.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanShopAddressDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanShopAddressDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}