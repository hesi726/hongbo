using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpPromocodeDetailGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocodeDetailGetResult;
    using YouzanUmpPromocodeDetailGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocodeDetailGetParams;

    public class YouzanUmpPromocodeDetailGet : AbstractAPI <YouzanUmpPromocodeDetailGetParams, YouzanUmpPromocodeDetailGetResult>
	{

		public YouzanUmpPromocodeDetailGet()
		{
		}

		public YouzanUmpPromocodeDetailGet(YouzanUmpPromocodeDetailGetParams apiParams)
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
				return "youzan.ump.promocode.detail.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocodeDetailGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocodeDetailGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}