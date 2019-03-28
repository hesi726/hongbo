using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductOfflineCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOfflineCreateResult;
    using YouzanRetailProductOfflineCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOfflineCreateParams;

    public class YouzanRetailProductOfflineCreate : AbstractAPI <YouzanRetailProductOfflineCreateParams, YouzanRetailProductOfflineCreateResult>
	{

		public YouzanRetailProductOfflineCreate()
		{
		}

		public YouzanRetailProductOfflineCreate(YouzanRetailProductOfflineCreateParams apiParams)
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
				return "youzan.retail.product.offline.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOfflineCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOfflineCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}