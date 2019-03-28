using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUsersWeixinFollowerTagsAddResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowerTagsAddResult;
    using YouzanUsersWeixinFollowerTagsAddParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowerTagsAddParams;

    public class YouzanUsersWeixinFollowerTagsAdd : AbstractAPI <YouzanUsersWeixinFollowerTagsAddParams, YouzanUsersWeixinFollowerTagsAddResult>
	{

		public YouzanUsersWeixinFollowerTagsAdd()
		{
		}

		public YouzanUsersWeixinFollowerTagsAdd(YouzanUsersWeixinFollowerTagsAddParams apiParams)
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
				return "youzan.users.weixin.follower.tags.add";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerTagsAddResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerTagsAddParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}