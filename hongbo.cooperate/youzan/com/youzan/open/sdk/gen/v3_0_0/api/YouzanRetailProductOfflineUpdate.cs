using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductOfflineUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOfflineUpdateResult;
    using YouzanRetailProductOfflineUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOfflineUpdateParams;

    public class YouzanRetailProductOfflineUpdate : AbstractAPI <YouzanRetailProductOfflineUpdateParams, YouzanRetailProductOfflineUpdateResult>
	{

		public YouzanRetailProductOfflineUpdate()
		{
		}

		public YouzanRetailProductOfflineUpdate(YouzanRetailProductOfflineUpdateParams apiParams)
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
				return "youzan.retail.product.offline.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOfflineUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOfflineUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}