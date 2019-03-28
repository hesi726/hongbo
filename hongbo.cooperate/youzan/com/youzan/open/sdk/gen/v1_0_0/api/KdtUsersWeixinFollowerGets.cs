using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using KdtUsersWeixinFollowerGetsResult = com.youzan.open.sdk.gen.v1_0_0.model.KdtUsersWeixinFollowerGetsResult;
    using KdtUsersWeixinFollowerGetsParams = com.youzan.open.sdk.gen.v1_0_0.model.KdtUsersWeixinFollowerGetsParams;

    public class KdtUsersWeixinFollowerGets : AbstractAPI <KdtUsersWeixinFollowerGetsParams, KdtUsersWeixinFollowerGetsResult>
	{

		public KdtUsersWeixinFollowerGets()
		{
		}

		public KdtUsersWeixinFollowerGets(KdtUsersWeixinFollowerGetsParams apiParams)
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
				return "kdt.users.weixin.follower.gets";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(KdtUsersWeixinFollowerGetsResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(KdtUsersWeixinFollowerGetsParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}