using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductOnlineGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOnlineGetResult;
    using YouzanRetailProductOnlineGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOnlineGetParams;

    public class YouzanRetailProductOnlineGet : AbstractAPI <YouzanRetailProductOnlineGetParams, YouzanRetailProductOnlineGetResult>
	{

		public YouzanRetailProductOnlineGet()
		{
		}

		public YouzanRetailProductOnlineGet(YouzanRetailProductOnlineGetParams apiParams)
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
				return "youzan.retail.product.online.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOnlineGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOnlineGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}