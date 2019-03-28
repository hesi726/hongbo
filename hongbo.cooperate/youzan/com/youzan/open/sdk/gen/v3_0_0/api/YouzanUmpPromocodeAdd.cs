using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpPromocodeAddResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocodeAddResult;
    using YouzanUmpPromocodeAddParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPromocodeAddParams;

    public class YouzanUmpPromocodeAdd : AbstractAPI <YouzanUmpPromocodeAddParams, YouzanUmpPromocodeAddResult>
	{

		public YouzanUmpPromocodeAdd()
		{
		}

		public YouzanUmpPromocodeAdd(YouzanUmpPromocodeAddParams apiParams)
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
				return "youzan.ump.promocode.add";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocodeAddResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpPromocodeAddParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}