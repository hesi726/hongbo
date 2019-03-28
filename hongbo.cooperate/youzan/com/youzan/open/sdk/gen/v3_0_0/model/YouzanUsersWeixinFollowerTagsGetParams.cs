using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanUsersWeixinFollowerTagsGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 微信粉丝用户ID。调用时，参数 weixin_openid 和 fans_id 选其一即可
		/// </summary>
		private string fansId;
		/// <summary>
		/// 微信粉丝用户的openid
		/// </summary>
		private string weixinOpenid;

		public virtual string FansId
		{
			set
			{
				this.fansId = value;
			}
			get
			{
				return this.fansId;
			}
		}


		public virtual string WeixinOpenid
		{
			set
			{
				this.weixinOpenid = value;
			}
			get
			{
				return this.weixinOpenid;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(fansId, null))
			{
				@params["fans_id"] = fansId;
			}
			if (!string.ReferenceEquals(weixinOpenid, null))
			{
				@params["weixin_openid"] = weixinOpenid;
			}
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}