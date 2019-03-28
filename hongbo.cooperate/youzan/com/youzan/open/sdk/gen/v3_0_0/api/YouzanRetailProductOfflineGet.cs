using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductOfflineGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOfflineGetResult;
    using YouzanRetailProductOfflineGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductOfflineGetParams;

    public class YouzanRetailProductOfflineGet : AbstractAPI <YouzanRetailProductOfflineGetParams, YouzanRetailProductOfflineGetResult>
	{

		public YouzanRetailProductOfflineGet()
		{
		}

		public YouzanRetailProductOfflineGet(YouzanRetailProductOfflineGetParams apiParams)
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
				return "youzan.retail.product.offline.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOfflineGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductOfflineGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}