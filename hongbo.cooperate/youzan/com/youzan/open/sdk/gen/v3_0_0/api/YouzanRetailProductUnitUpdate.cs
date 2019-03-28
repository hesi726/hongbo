using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductUnitUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductUnitUpdateResult;
    using YouzanRetailProductUnitUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductUnitUpdateParams;

    public class YouzanRetailProductUnitUpdate : AbstractAPI <YouzanRetailProductUnitUpdateParams, YouzanRetailProductUnitUpdateResult>
	{

		public YouzanRetailProductUnitUpdate()
		{
		}

		public YouzanRetailProductUnitUpdate(YouzanRetailProductUnitUpdateParams apiParams)
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
				return "youzan.retail.product.unit.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductUnitUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductUnitUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}