using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    //using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    //using Maps = com.google.common.collect.Maps;

    //using Multimap = com.google.common.collect.Multimap;

    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanCrmCustomerPointsDecreaseParams : APIParams, FileParams
	{

		/// <summary>
		/// 减少理由
		/// </summary>
		private string reason;
		/// <summary>
		/// 积分数
		/// </summary>
		private long? points;
		/// <summary>
		/// 用户手机号（mobile或fans_id至少传一个）
		/// </summary>
		private string mobile;
		/// <summary>
		/// 粉丝类型（自有粉丝: fans_type = 1）
		/// </summary>
		private long? fansType;
		/// <summary>
		/// 粉丝id（mobile或fans_id至少传一个）
		/// </summary>
		private long? fansId;
		/// <summary>
		/// 商家签名模式调用接口时的app_id, 若无则无需填写。
		/// </summary>
		private string appId;

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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(reason, null))
			{
				@params["reason"] = reason;
			}
			if (points != null)
			{
				@params["points"] = points;
			}
			if (!string.ReferenceEquals(mobile, null))
			{
				@params["mobile"] = mobile;
			}
			if (fansType != null)
			{
				@params["fans_type"] = fansType;
			}
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
			}
			if (!string.ReferenceEquals(appId, null))
			{
				@params["app_id"] = appId;
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