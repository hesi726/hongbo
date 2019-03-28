using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanScrmCardGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardGetResult;
    using YouzanScrmCardGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanScrmCardGetParams;

    public class YouzanScrmCardGet : AbstractAPI <YouzanScrmCardGetParams, YouzanScrmCardGetResult>
	{

		public YouzanScrmCardGet()
		{
		}

		public YouzanScrmCardGet(YouzanScrmCardGetParams apiParams)
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
				return "youzan.scrm.card.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanScrmCardGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanScrmCardGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}