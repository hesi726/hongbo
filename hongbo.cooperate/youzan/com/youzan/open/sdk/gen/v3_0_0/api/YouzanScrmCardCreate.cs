using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCardCreateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardCreateResult;
    using YouzanScrmCardCreateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardCreateParams;

    public class YouzanScrmCardCreate : AbstractAPI <YouzanScrmCardCreateParams, YouzanScrmCardCreateResult>
	{

		public YouzanScrmCardCreate()
		{
		}

		public YouzanScrmCardCreate(YouzanScrmCardCreateParams apiParams)
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
				return "youzan.scrm.card.create";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCardCreateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCardCreateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}