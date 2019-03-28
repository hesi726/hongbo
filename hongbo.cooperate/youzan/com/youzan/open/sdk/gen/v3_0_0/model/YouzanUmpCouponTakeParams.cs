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

    public class YouzanUmpCouponTakeParams : APIParams, FileParams
	{

		/// <summary>
		/// 优惠券码组id
		/// </summary>
		private long? couponGroupId;
		/// <summary>
		/// 粉丝id，fans_id与weixin_openid存在一个即可
		/// </summary>
		private long? fansId;
		/// <summary>
		/// mobile，weixin_openid，fans_id，open_user_id任传一个即可。首先通过mobile查找，其次weixin_openid和fans_id，最后open_user_id
		/// </summary>
		private long? mobile;
		/// <summary>
		/// 三方用户id
		/// </summary>
		private string openUserId;
		/// <summary>
		/// 微信用户对应的openid
		/// </summary>
		private string weixinOpenid;

		public virtual long? CouponGroupId
		{
			set
			{
				this.couponGroupId = value;
			}
			get
			{
				return this.couponGroupId;
			}
		}


		public virtual long? FansId
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


		public virtual long? Mobile
		{
			set
			{
				this.mobile = value;
			}
			get
			{
				return this.mobile;
			}
		}


		public virtual string OpenUserId
		{
			set
			{
				this.openUserId = value;
			}
			get
			{
				return this.openUserId;
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
			if (couponGroupId != null)
			{
				@params["coupon_group_id"] = couponGroupId;
			}
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
			}
			if (mobile != null)
			{
				@params["mobile"] = mobile;
			}
			if (!string.ReferenceEquals(openUserId, null))
			{
				@params["open_user_id"] = openUserId;
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