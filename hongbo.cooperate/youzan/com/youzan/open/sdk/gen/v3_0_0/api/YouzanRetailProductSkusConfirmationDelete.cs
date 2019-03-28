using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductSkusConfirmationDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkusConfirmationDeleteResult;
    using YouzanRetailProductSkusConfirmationDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkusConfirmationDeleteParams;

    public class YouzanRetailProductSkusConfirmationDelete : AbstractAPI <YouzanRetailProductSkusConfirmationDeleteParams, YouzanRetailProductSkusConfirmationDeleteResult>
	{

		public YouzanRetailProductSkusConfirmationDelete()
		{
		}

		public YouzanRetailProductSkusConfirmationDelete(YouzanRetailProductSkusConfirmationDeleteParams apiParams)
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
				return "youzan.retail.product.skus.confirmation.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkusConfirmationDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkusConfirmationDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}