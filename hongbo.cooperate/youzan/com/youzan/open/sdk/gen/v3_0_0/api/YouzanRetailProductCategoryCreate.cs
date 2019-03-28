using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductCategoryCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductCategoryCreateResult;
    using YouzanRetailProductCategoryCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductCategoryCreateParams;

    public class YouzanRetailProductCategoryCreate : AbstractAPI <YouzanRetailProductCategoryCreateParams, YouzanRetailProductCategoryCreateResult>
	{

		public YouzanRetailProductCategoryCreate()
		{
		}

		public YouzanRetailProductCategoryCreate(YouzanRetailProductCategoryCreateParams apiParams)
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
				return "youzan.retail.product.category.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductCategoryCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductCategoryCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}