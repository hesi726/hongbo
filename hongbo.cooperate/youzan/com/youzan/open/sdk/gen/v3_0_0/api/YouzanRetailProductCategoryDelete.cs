using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductCategoryDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductCategoryDeleteResult;
    using YouzanRetailProductCategoryDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductCategoryDeleteParams;

    public class YouzanRetailProductCategoryDelete : AbstractAPI <YouzanRetailProductCategoryDeleteParams, YouzanRetailProductCategoryDeleteResult>
	{

		public YouzanRetailProductCategoryDelete()
		{
		}

		public YouzanRetailProductCategoryDelete(YouzanRetailProductCategoryDeleteParams apiParams)
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
				return "youzan.retail.product.category.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductCategoryDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductCategoryDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}