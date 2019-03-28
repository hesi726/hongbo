using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpPromocardAddResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocardAddResult;
    using YouzanUmpPromocardAddParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocardAddParams;

    public class YouzanUmpPromocardAdd : AbstractAPI <YouzanUmpPromocardAddParams, YouzanUmpPromocardAddResult>
	{

		public YouzanUmpPromocardAdd()
		{
		}

		public YouzanUmpPromocardAdd(YouzanUmpPromocardAddParams apiParams)
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
				return "youzan.ump.promocard.add";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocardAddResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocardAddParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}