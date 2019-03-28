using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPaySubmerchantUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySubmerchantUpdateResult;
    using YouzanPaySubmerchantUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySubmerchantUpdateParams;

    public class YouzanPaySubmerchantUpdate : AbstractAPI <YouzanPaySubmerchantUpdateParams, YouzanPaySubmerchantUpdateResult>
	{

		public YouzanPaySubmerchantUpdate()
		{
		}

		public YouzanPaySubmerchantUpdate(YouzanPaySubmerchantUpdateParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "POST";
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
				return "youzan.pay.submerchant.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPaySubmerchantUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPaySubmerchantUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}