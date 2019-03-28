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

    public class YouzanUmpPresentGiveParams : APIParams, FileParams
	{

		/// <summary>
		/// 赠品活动ID
		/// </summary>
		private long? activityId;
		/// <summary>
		/// 有赞手机注册用户ID，fans_id和buyer_id至少要传一个
		/// </summary>
		private long? buyerId;
		/// <summary>
		/// 微信粉丝ID，fans_id和buyer_id至少要传一个
		/// </summary>
		private long? fansId;

		public virtual long? ActivityId
		{
			set
			{
				this.activityId = value;
			}
			get
			{
				return this.activityId;
			}
		}


		public virtual long? BuyerId
		{
			set
			{
				this.buyerId = value;
			}
			get
			{
				return this.buyerId;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (activityId != null)
			{
				@params["activity_id"] = activityId;
			}
			if (buyerId != null)
			{
				@params["buyer_id"] = buyerId;
			}
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
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