using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using KdtUsersWeixinFollowersGetResult = com.youzan.open.sdk.gen.v1_0_0.model.KdtUsersWeixinFollowersGetResult;
    using KdtUsersWeixinFollowersGetParams = com.youzan.open.sdk.gen.v1_0_0.model.KdtUsersWeixinFollowersGetParams;

    public class KdtUsersWeixinFollowersGet : AbstractAPI <KdtUsersWeixinFollowersGetParams, KdtUsersWeixinFollowersGetResult>
	{

		public KdtUsersWeixinFollowersGet()
		{
		}

		public KdtUsersWeixinFollowersGet(KdtUsersWeixinFollowersGetParams apiParams)
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
				return "1.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "kdt.users.weixin.followers.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(KdtUsersWeixinFollowersGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(KdtUsersWeixinFollowersGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}