using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanRetailProductUnitsDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductUnitsDeleteResult;
    using YouzanRetailProductUnitsDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanRetailProductUnitsDeleteParams;

    public class YouzanRetailProductUnitsDelete : AbstractAPI <YouzanRetailProductUnitsDeleteParams, YouzanRetailProductUnitsDeleteResult>
	{

		public YouzanRetailProductUnitsDelete()
		{
		}

		public YouzanRetailProductUnitsDelete(YouzanRetailProductUnitsDeleteParams apiParams)
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
				return "youzan.retail.product.units.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanRetailProductUnitsDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanRetailProductUnitsDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}