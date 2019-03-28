using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpPresentGiveResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPresentGiveResult;
    using YouzanUmpPresentGiveParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPresentGiveParams;

    public class YouzanUmpPresentGive : AbstractAPI <YouzanUmpPresentGiveParams, YouzanUmpPresentGiveResult>
	{

		public YouzanUmpPresentGive()
		{
		}

		public YouzanUmpPresentGive(YouzanUmpPresentGiveParams apiParams)
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
				return "youzan.ump.present.give";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpPresentGiveResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpPresentGiveParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}