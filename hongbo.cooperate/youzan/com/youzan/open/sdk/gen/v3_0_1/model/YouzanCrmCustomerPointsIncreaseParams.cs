using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_1.model
{

    //	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    //	using Maps = com.google.common.collect.Maps;

    //	using Multimap = com.google.common.collect.Multimap;

    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanCrmCustomerPointsIncreaseParams : APIParams, FileParams
	{

		/// <summary>
		/// 商家签名模式调用接口时的app_id, 若无则无需填写。
		/// </summary>
		private string appId;
		/// <summary>
		/// 粉丝Id
		/// mobile/fans_id/open_user_id 三选一传入
		/// </summary>
		private long? fansId;
		/// <summary>
		/// 粉丝类型（自有粉丝: fans_type = 1）
		/// </summary>
		private long? fansType;
		/// <summary>
		/// 用户手机号
		/// mobile/fans_id/open_user_id 三选一传入
		/// </summary>
		private string mobile;
		/// <summary>
		/// 三方用户ID
		/// mobile/fans_id/open_user_id 三选一传入
		/// </summary>
		private string openUserId;
		/// <summary>
		/// 积分数
		/// </summary>
		private long? points;
		/// <summary>
		/// 增加描述
		/// </summary>
		private string reason;

		public virtual string AppId
		{
			set
			{
				this.appId = value;
			}
			get
			{
				return this.appId;
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


		public virtual long? FansType
		{
			set
			{
				this.fansType = value;
			}
			get
			{
				return this.fansType;
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


		public virtual long? Points
		{
			set
			{
				this.points = value;
			}
			get
			{
				return this.points;
			}
		}


		public virtual string Reason
		{
			set
			{
				this.reason = value;
			}
			get
			{
				return this.reason;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(appId, null))
			{
				@params["app_id"] = appId;
			}
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
			}
			if (fansType != null)
			{
				@params["fans_type"] = fansType;
			}
			if (!string.ReferenceEquals(mobile, null))
			{
				@params["mobile"] = mobile;
			}
			if (!string.ReferenceEquals(openUserId, null))
			{
				@params["open_user_id"] = openUserId;
			}
			if (points != null)
			{
				@params["points"] = points;
			}
			if (!string.ReferenceEquals(reason, null))
			{
				@params["reason"] = reason;
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