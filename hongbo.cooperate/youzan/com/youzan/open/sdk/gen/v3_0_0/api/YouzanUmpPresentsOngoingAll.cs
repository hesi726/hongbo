using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpPresentsOngoingAllResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPresentsOngoingAllResult;
    using YouzanUmpPresentsOngoingAllParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpPresentsOngoingAllParams;

    public class YouzanUmpPresentsOngoingAll : AbstractAPI <YouzanUmpPresentsOngoingAllParams, YouzanUmpPresentsOngoingAllResult>
	{

		public YouzanUmpPresentsOngoingAll()
		{
		}

		public YouzanUmpPresentsOngoingAll(YouzanUmpPresentsOngoingAllParams apiParams)
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
				return "youzan.ump.presents.ongoing.all";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpPresentsOngoingAllResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpPresentsOngoingAllParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}