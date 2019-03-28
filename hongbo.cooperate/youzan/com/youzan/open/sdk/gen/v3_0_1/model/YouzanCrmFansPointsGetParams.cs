using System.Collections.Generic;
using youzan.com.youzan.open.sdk.model;

namespace com.youzan.open.sdk.gen.v3_0_1.model
{
	//using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
	//using Maps = com.google.common.collect.Maps;
	//using Multimap = com.google.common.collect.Multimap;
	using APIParams = com.youzan.open.sdk.model.APIParams;
	using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
	using FileParams = com.youzan.open.sdk.model.FileParams;

	public class YouzanCrmFansPointsGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 粉丝id
		/// fans_id/open_user_id/mobile 三选一传入
		/// </summary>
		private long? fansId;
		/// <summary>
		/// 手机号
		/// fans_id/open_user_id/mobile 三选一传入
		/// </summary>
		private string mobile;
		/// <summary>
		/// 三方用户ID
		/// fans_id/open_user_id/mobile 三选一传入
		/// </summary>
		private string openUserId;

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


		public virtual string Mobile
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
			}
			if (!string.ReferenceEquals(mobile, null))
			{
				@params["mobile"] = mobile;
			}
			if (!string.ReferenceEquals(openUserId, null))
			{
				@params["open_user_id"] = openUserId;
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