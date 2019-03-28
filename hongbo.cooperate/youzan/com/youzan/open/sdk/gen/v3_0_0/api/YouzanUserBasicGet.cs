using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUserBasicGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserBasicGetResult;
    using YouzanUserBasicGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserBasicGetParams;

    public class YouzanUserBasicGet : AbstractAPI <YouzanUserBasicGetParams, YouzanUserBasicGetResult>
	{

		public YouzanUserBasicGet()
		{
		}

		public YouzanUserBasicGet(YouzanUserBasicGetParams apiParams)
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
				return "youzan.user.basic.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUserBasicGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUserBasicGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}