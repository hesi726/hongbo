using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUsersWeixinFollowerTagsDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowerTagsDeleteResult;
    using YouzanUsersWeixinFollowerTagsDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowerTagsDeleteParams;

    public class YouzanUsersWeixinFollowerTagsDelete : AbstractAPI <YouzanUsersWeixinFollowerTagsDeleteParams, YouzanUsersWeixinFollowerTagsDeleteResult>
	{

		public YouzanUsersWeixinFollowerTagsDelete()
		{
		}

		public YouzanUsersWeixinFollowerTagsDelete(YouzanUsersWeixinFollowerTagsDeleteParams apiParams)
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
				return "youzan.users.weixin.follower.tags.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerTagsDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerTagsDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}