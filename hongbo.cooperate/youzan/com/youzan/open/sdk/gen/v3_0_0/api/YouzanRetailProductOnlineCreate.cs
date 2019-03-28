using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductOnlineCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOnlineCreateResult;
    using YouzanRetailProductOnlineCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOnlineCreateParams;

    public class YouzanRetailProductOnlineCreate : AbstractAPI <YouzanRetailProductOnlineCreateParams, YouzanRetailProductOnlineCreateResult>
	{

		public YouzanRetailProductOnlineCreate()
		{
		}

		public YouzanRetailProductOnlineCreate(YouzanRetailProductOnlineCreateParams apiParams)
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
				return "youzan.retail.product.online.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOnlineCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOnlineCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}