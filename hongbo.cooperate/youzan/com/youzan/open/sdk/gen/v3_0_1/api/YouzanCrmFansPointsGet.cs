using System;

namespace com.youzan.open.sdk.gen.v3_0_1.api
{

    using com.youzan.open.sdk.api;
    using YouzanCrmFansPointsGetResult = com.youzan.open.sdk.gen.v3_0_1.model.YouzanCrmFansPointsGetResult;
    using YouzanCrmFansPointsGetParams = com.youzan.open.sdk.gen.v3_0_1.model.YouzanCrmFansPointsGetParams;

    public class YouzanCrmFansPointsGet : AbstractAPI <YouzanCrmFansPointsGetParams, YouzanCrmFansPointsGetResult>
	{

		public YouzanCrmFansPointsGet()
		{
		}

		public YouzanCrmFansPointsGet(YouzanCrmFansPointsGetParams apiParams)
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
				return "3.0.1";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.crm.fans.points.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanCrmFansPointsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanCrmFansPointsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}