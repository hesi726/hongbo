using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUsersWeixinFollowerTagsGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowerTagsGetResult;
    using YouzanUsersWeixinFollowerTagsGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUsersWeixinFollowerTagsGetParams;

    public class YouzanUsersWeixinFollowerTagsGet : AbstractAPI <YouzanUsersWeixinFollowerTagsGetParams, YouzanUsersWeixinFollowerTagsGetResult>
	{

		public YouzanUsersWeixinFollowerTagsGet()
		{
		}

		public YouzanUsersWeixinFollowerTagsGet(YouzanUsersWeixinFollowerTagsGetParams apiParams)
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
				return "youzan.users.weixin.follower.tags.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerTagsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUsersWeixinFollowerTagsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}