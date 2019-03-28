using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayCertTeamcertificationGetResult = com.youzan.open.sdk.gen.v1_0_0.model.YouzanPayCertTeamcertificationGetResult;
    using YouzanPayCertTeamcertificationGetParams = com.youzan.open.sdk.gen.v1_0_0.model.YouzanPayCertTeamcertificationGetParams;

    public class YouzanPayCertTeamcertificationGet : AbstractAPI <YouzanPayCertTeamcertificationGetParams, YouzanPayCertTeamcertificationGetResult>
	{

		public YouzanPayCertTeamcertificationGet()
		{
		}

		public YouzanPayCertTeamcertificationGet(YouzanPayCertTeamcertificationGetParams apiParams)
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
				return "1.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.pay.cert.teamcertification.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayCertTeamcertificationGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayCertTeamcertificationGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}