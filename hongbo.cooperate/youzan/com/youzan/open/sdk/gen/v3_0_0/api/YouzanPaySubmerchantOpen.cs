using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPaySubmerchantOpenResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySubmerchantOpenResult;
    using YouzanPaySubmerchantOpenParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySubmerchantOpenParams;

    public class YouzanPaySubmerchantOpen : AbstractAPI <YouzanPaySubmerchantOpenParams, YouzanPaySubmerchantOpenResult>
	{

		public YouzanPaySubmerchantOpen()
		{
		}

		public YouzanPaySubmerchantOpen(YouzanPaySubmerchantOpenParams apiParams)
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
				return "youzan.pay.submerchant.open";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPaySubmerchantOpenResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPaySubmerchantOpenParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}