using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCardUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardUpdateResult;
    using YouzanScrmCardUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardUpdateParams;

    public class YouzanScrmCardUpdate : AbstractAPI <YouzanScrmCardUpdateParams, YouzanScrmCardUpdateResult>
	{

		public YouzanScrmCardUpdate()
		{
		}

		public YouzanScrmCardUpdate(YouzanScrmCardUpdateParams apiParams)
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
				return "youzan.scrm.card.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCardUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCardUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}