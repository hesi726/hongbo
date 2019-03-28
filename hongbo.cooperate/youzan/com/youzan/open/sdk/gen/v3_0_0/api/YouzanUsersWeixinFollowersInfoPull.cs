using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUsersWeixinFollowersInfoPullResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowersInfoPullResult;
    using YouzanUsersWeixinFollowersInfoPullParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowersInfoPullParams;

    public class YouzanUsersWeixinFollowersInfoPull : AbstractAPI <YouzanUsersWeixinFollowersInfoPullParams, YouzanUsersWeixinFollowersInfoPullResult>
	{

		public YouzanUsersWeixinFollowersInfoPull()
		{
		}

		public YouzanUsersWeixinFollowersInfoPull(YouzanUsersWeixinFollowersInfoPullParams apiParams)
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
				return "youzan.users.weixin.followers.info.pull";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowersInfoPullResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowersInfoPullParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}