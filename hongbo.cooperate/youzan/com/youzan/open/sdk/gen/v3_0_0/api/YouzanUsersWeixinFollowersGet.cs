using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUsersWeixinFollowersGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowersGetResult;
    using YouzanUsersWeixinFollowersGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowersGetParams;

    public class YouzanUsersWeixinFollowersGet : AbstractAPI <YouzanUsersWeixinFollowersGetParams, YouzanUsersWeixinFollowersGetResult>
	{

		public YouzanUsersWeixinFollowersGet()
		{
		}

		public YouzanUsersWeixinFollowersGet(YouzanUsersWeixinFollowersGetParams apiParams)
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
				return "youzan.users.weixin.followers.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowersGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowersGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}