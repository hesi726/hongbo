using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductUnitCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductUnitCreateResult;
    using YouzanRetailProductUnitCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductUnitCreateParams;

    public class YouzanRetailProductUnitCreate : AbstractAPI <YouzanRetailProductUnitCreateParams, YouzanRetailProductUnitCreateResult>
	{

		public YouzanRetailProductUnitCreate()
		{
		}

		public YouzanRetailProductUnitCreate(YouzanRetailProductUnitCreateParams apiParams)
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
				return "youzan.retail.product.unit.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductUnitCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductUnitCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}