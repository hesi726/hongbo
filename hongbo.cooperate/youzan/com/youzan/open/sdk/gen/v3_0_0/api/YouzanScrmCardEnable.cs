using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCardEnableResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardEnableResult;
    using YouzanScrmCardEnableParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardEnableParams;

    public class YouzanScrmCardEnable : AbstractAPI <YouzanScrmCardEnableParams, YouzanScrmCardEnableResult>
	{

		public YouzanScrmCardEnable()
		{
		}

		public YouzanScrmCardEnable(YouzanScrmCardEnableParams apiParams)
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
				return "youzan.scrm.card.enable";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCardEnableResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCardEnableParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}