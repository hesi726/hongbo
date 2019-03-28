using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpPromocardDetailGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocardDetailGetResult;
    using YouzanUmpPromocardDetailGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocardDetailGetParams;

    public class YouzanUmpPromocardDetailGet : AbstractAPI <YouzanUmpPromocardDetailGetParams, YouzanUmpPromocardDetailGetResult>
	{

		public YouzanUmpPromocardDetailGet()
		{
		}

		public YouzanUmpPromocardDetailGet(YouzanUmpPromocardDetailGetParams apiParams)
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
				return "youzan.ump.promocard.detail.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocardDetailGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocardDetailGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}