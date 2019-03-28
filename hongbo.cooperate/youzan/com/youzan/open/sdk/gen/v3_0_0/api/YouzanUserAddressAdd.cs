using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUserAddressAddResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserAddressAddResult;
    using YouzanUserAddressAddParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserAddressAddParams;

    public class YouzanUserAddressAdd : AbstractAPI <YouzanUserAddressAddParams, YouzanUserAddressAddResult>
	{

		public YouzanUserAddressAdd()
		{
		}

		public YouzanUserAddressAdd(YouzanUserAddressAddParams apiParams)
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
				return "youzan.user.address.add";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUserAddressAddResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUserAddressAddParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}