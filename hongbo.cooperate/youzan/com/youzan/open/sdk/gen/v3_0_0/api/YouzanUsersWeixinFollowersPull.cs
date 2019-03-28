using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUsersWeixinFollowersPullResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowersPullResult;
    using YouzanUsersWeixinFollowersPullParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowersPullParams;

    public class YouzanUsersWeixinFollowersPull : AbstractAPI <YouzanUsersWeixinFollowersPullParams, YouzanUsersWeixinFollowersPullResult>
	{

		public YouzanUsersWeixinFollowersPull()
		{
		}

		public YouzanUsersWeixinFollowersPull(YouzanUsersWeixinFollowersPullParams apiParams)
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
				return "youzan.users.weixin.followers.pull";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowersPullResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowersPullParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}