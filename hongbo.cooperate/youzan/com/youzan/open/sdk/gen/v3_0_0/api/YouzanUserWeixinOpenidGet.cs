using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUserWeixinOpenidGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserWeixinOpenidGetResult;
    using YouzanUserWeixinOpenidGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUserWeixinOpenidGetParams;

    public class YouzanUserWeixinOpenidGet : AbstractAPI <YouzanUserWeixinOpenidGetParams, YouzanUserWeixinOpenidGetResult>
	{

		public YouzanUserWeixinOpenidGet()
		{
		}

		public YouzanUserWeixinOpenidGet(YouzanUserWeixinOpenidGetParams apiParams)
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
				return "youzan.user.weixin.openid.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUserWeixinOpenidGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUserWeixinOpenidGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}