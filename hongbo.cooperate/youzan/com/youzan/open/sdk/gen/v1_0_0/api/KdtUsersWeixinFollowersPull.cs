using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using KdtUsersWeixinFollowersPullResult = com.youzan.open.sdk.gen.v1_0_0.model.KdtUsersWeixinFollowersPullResult;
    using KdtUsersWeixinFollowersPullParams = com.youzan.open.sdk.gen.v1_0_0.model.KdtUsersWeixinFollowersPullParams;

    public class KdtUsersWeixinFollowersPull : AbstractAPI <KdtUsersWeixinFollowersPullParams, KdtUsersWeixinFollowersPullResult>
	{

		public KdtUsersWeixinFollowersPull()
		{
		}

		public KdtUsersWeixinFollowersPull(KdtUsersWeixinFollowersPullParams apiParams)
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
				return "kdt.users.weixin.followers.pull";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(KdtUsersWeixinFollowersPullResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(KdtUsersWeixinFollowersPullParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}