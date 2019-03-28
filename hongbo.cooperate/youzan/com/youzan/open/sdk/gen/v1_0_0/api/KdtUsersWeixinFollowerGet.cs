using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using KdtUsersWeixinFollowerGetResult = com.youzan.open.sdk.gen.v1_0_0.model.KdtUsersWeixinFollowerGetResult;
    using KdtUsersWeixinFollowerGetParams = com.youzan.open.sdk.gen.v1_0_0.model.KdtUsersWeixinFollowerGetParams;

    public class KdtUsersWeixinFollowerGet : AbstractAPI <KdtUsersWeixinFollowerGetParams, KdtUsersWeixinFollowerGetResult>
	{

		public KdtUsersWeixinFollowerGet()
		{
		}

		public KdtUsersWeixinFollowerGet(KdtUsersWeixinFollowerGetParams apiParams)
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
				return "kdt.users.weixin.follower.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(KdtUsersWeixinFollowerGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(KdtUsersWeixinFollowerGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}