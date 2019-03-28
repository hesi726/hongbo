using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUsersWeixinFollowersInfoSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowersInfoSearchResult;
    using YouzanUsersWeixinFollowersInfoSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowersInfoSearchParams;

    public class YouzanUsersWeixinFollowersInfoSearch : AbstractAPI <YouzanUsersWeixinFollowersInfoSearchParams, YouzanUsersWeixinFollowersInfoSearchResult>
	{

		public YouzanUsersWeixinFollowersInfoSearch()
		{
		}

		public YouzanUsersWeixinFollowersInfoSearch(YouzanUsersWeixinFollowersInfoSearchParams apiParams)
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
				return "youzan.users.weixin.followers.info.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowersInfoSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowersInfoSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}