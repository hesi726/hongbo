using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanClientAppengineAuthorizeResult = com.youzan.open.sdk.gen.v1_0_0.model.YouzanClientAppengineAuthorizeResult;
    using YouzanClientAppengineAuthorizeParams = com.youzan.open.sdk.gen.v1_0_0.model.YouzanClientAppengineAuthorizeParams;

    public class YouzanClientAppengineAuthorize : AbstractAPI <YouzanClientAppengineAuthorizeParams, YouzanClientAppengineAuthorizeResult>
	{

		public YouzanClientAppengineAuthorize()
		{
		}

		public YouzanClientAppengineAuthorize(YouzanClientAppengineAuthorizeParams apiParams)
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
				return "1.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.client.appengine.authorize";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanClientAppengineAuthorizeResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanClientAppengineAuthorizeParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}