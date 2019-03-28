using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPaySubmerchantAuthQueryResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySubmerchantAuthQueryResult;
    using YouzanPaySubmerchantAuthQueryParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySubmerchantAuthQueryParams;

    public class YouzanPaySubmerchantAuthQuery : AbstractAPI <YouzanPaySubmerchantAuthQueryParams, YouzanPaySubmerchantAuthQueryResult>
	{

		public YouzanPaySubmerchantAuthQuery()
		{
		}

		public YouzanPaySubmerchantAuthQuery(YouzanPaySubmerchantAuthQueryParams apiParams)
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
				return "youzan.pay.submerchant.auth.query";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPaySubmerchantAuthQueryResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPaySubmerchantAuthQueryParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}