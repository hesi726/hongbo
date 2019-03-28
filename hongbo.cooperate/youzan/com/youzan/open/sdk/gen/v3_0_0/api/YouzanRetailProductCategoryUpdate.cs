using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductCategoryUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductCategoryUpdateResult;
    using YouzanRetailProductCategoryUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductCategoryUpdateParams;

    public class YouzanRetailProductCategoryUpdate : AbstractAPI <YouzanRetailProductCategoryUpdateParams, YouzanRetailProductCategoryUpdateResult>
	{

		public YouzanRetailProductCategoryUpdate()
		{
		}

		public YouzanRetailProductCategoryUpdate(YouzanRetailProductCategoryUpdateParams apiParams)
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
				return "youzan.retail.product.category.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductCategoryUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductCategoryUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}