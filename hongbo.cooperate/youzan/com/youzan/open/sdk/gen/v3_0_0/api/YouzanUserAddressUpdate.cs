using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUserAddressUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserAddressUpdateResult;
    using YouzanUserAddressUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserAddressUpdateParams;

    public class YouzanUserAddressUpdate : AbstractAPI <YouzanUserAddressUpdateParams, YouzanUserAddressUpdateResult>
	{

		public YouzanUserAddressUpdate()
		{
		}

		public YouzanUserAddressUpdate(YouzanUserAddressUpdateParams apiParams)
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
				return "youzan.user.address.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUserAddressUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUserAddressUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}