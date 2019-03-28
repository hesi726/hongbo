using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductSkusDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkusDeleteResult;
    using YouzanRetailProductSkusDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkusDeleteParams;

    public class YouzanRetailProductSkusDelete : AbstractAPI <YouzanRetailProductSkusDeleteParams, YouzanRetailProductSkusDeleteResult>
	{

		public YouzanRetailProductSkusDelete()
		{
		}

		public YouzanRetailProductSkusDelete(YouzanRetailProductSkusDeleteParams apiParams)
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
				return "youzan.retail.product.skus.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkusDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkusDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}