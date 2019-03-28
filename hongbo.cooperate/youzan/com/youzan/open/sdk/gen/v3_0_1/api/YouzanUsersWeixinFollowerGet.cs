using System;

namespace com.youzan.open.sdk.gen.v3_0_1.api
{

    using com.youzan.open.sdk.api;
    using YouzanUsersWeixinFollowerGetResult = com.youzan.open.sdk.gen.v3_0_1.model.YouzanUsersWeixinFollowerGetResult;
    using YouzanUsersWeixinFollowerGetParams = com.youzan.open.sdk.gen.v3_0_1.model.YouzanUsersWeixinFollowerGetParams;

    public class YouzanUsersWeixinFollowerGet : AbstractAPI <YouzanUsersWeixinFollowerGetParams, YouzanUsersWeixinFollowerGetResult>
	{

		public YouzanUsersWeixinFollowerGet()
		{
		}

		public YouzanUsersWeixinFollowerGet(YouzanUsersWeixinFollowerGetParams apiParams)
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
				return "youzan.users.weixin.follower.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}