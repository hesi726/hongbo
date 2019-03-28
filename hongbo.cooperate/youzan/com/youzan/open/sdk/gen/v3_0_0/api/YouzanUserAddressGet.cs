using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUserAddressGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserAddressGetResult;
    using YouzanUserAddressGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserAddressGetParams;

    public class YouzanUserAddressGet : AbstractAPI <YouzanUserAddressGetParams, YouzanUserAddressGetResult>
	{

		public YouzanUserAddressGet()
		{
		}

		public YouzanUserAddressGet(YouzanUserAddressGetParams apiParams)
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
				return "youzan.user.address.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUserAddressGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUserAddressGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}