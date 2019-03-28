using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPaySubmerchantQueryResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySubmerchantQueryResult;
    using YouzanPaySubmerchantQueryParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPaySubmerchantQueryParams;

    public class YouzanPaySubmerchantQuery : AbstractAPI <YouzanPaySubmerchantQueryParams, YouzanPaySubmerchantQueryResult>
	{

		public YouzanPaySubmerchantQuery()
		{
		}

		public YouzanPaySubmerchantQuery(YouzanPaySubmerchantQueryParams apiParams)
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
				return "youzan.pay.submerchant.query";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPaySubmerchantQueryResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPaySubmerchantQueryParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}