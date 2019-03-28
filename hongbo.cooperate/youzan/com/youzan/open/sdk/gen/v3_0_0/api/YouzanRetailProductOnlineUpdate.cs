using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductOnlineUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOnlineUpdateResult;
    using YouzanRetailProductOnlineUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOnlineUpdateParams;

    public class YouzanRetailProductOnlineUpdate : AbstractAPI <YouzanRetailProductOnlineUpdateParams, YouzanRetailProductOnlineUpdateResult>
	{

		public YouzanRetailProductOnlineUpdate()
		{
		}

		public YouzanRetailProductOnlineUpdate(YouzanRetailProductOnlineUpdateParams apiParams)
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
				return "youzan.retail.product.online.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOnlineUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOnlineUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}