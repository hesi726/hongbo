using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCardDisableResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardDisableResult;
    using YouzanScrmCardDisableParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardDisableParams;

    public class YouzanScrmCardDisable : AbstractAPI <YouzanScrmCardDisableParams, YouzanScrmCardDisableResult>
	{

		public YouzanScrmCardDisable()
		{
		}

		public YouzanScrmCardDisable(YouzanScrmCardDisableParams apiParams)
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
				return "youzan.scrm.card.disable";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCardDisableResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCardDisableParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}