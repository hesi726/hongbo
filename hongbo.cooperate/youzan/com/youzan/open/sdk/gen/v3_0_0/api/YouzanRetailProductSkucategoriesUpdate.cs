using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductSkucategoriesUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkucategoriesUpdateResult;
    using YouzanRetailProductSkucategoriesUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductSkucategoriesUpdateParams;

    public class YouzanRetailProductSkucategoriesUpdate : AbstractAPI <YouzanRetailProductSkucategoriesUpdateParams, YouzanRetailProductSkucategoriesUpdateResult>
	{

		public YouzanRetailProductSkucategoriesUpdate()
		{
		}

		public YouzanRetailProductSkucategoriesUpdate(YouzanRetailProductSkucategoriesUpdateParams apiParams)
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
				return "youzan.retail.product.skucategories.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkucategoriesUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductSkucategoriesUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}