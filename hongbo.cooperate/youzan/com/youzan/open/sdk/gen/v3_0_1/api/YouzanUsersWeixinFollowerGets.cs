using System;

namespace com.youzan.open.sdk.gen.v3_0_1.api
{

    using com.youzan.open.sdk.api;
    using YouzanUsersWeixinFollowerGetsResult = com.youzan.open.sdk.gen.v3_0_1.model.YouzanUsersWeixinFollowerGetsResult;
    using YouzanUsersWeixinFollowerGetsParams = com.youzan.open.sdk.gen.v3_0_1.model.YouzanUsersWeixinFollowerGetsParams;

    public class YouzanUsersWeixinFollowerGets : AbstractAPI <YouzanUsersWeixinFollowerGetsParams, YouzanUsersWeixinFollowerGetsResult>
	{

		public YouzanUsersWeixinFollowerGets()
		{
		}

		public YouzanUsersWeixinFollowerGets(YouzanUsersWeixinFollowerGetsParams apiParams)
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
				return "youzan.users.weixin.follower.gets";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerGetsResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerGetsParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}