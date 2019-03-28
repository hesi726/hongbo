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

    public class YouzanScrmCustomerCardGrantParams : APIParams, FileParams
	{

		/// <summary>
		/// 商家会员卡的唯一标识
		/// </summary>
		private string cardAlias;
		/// <summary>
		/// 粉丝ID，与 fans_type 同时出现，如果没有写0
		/// mobile/fans_id/open_user_id 三选一传入
		/// </summary>
		private long? fansId;
		/// <summary>
		/// 粉丝类型（自有粉丝: fans_type = 1）   
		/// </summary>
		private long? fansType;
		/// <summary>
		/// 手机号，如果没有则写 0
		/// mobile/fans_id/open_user_id 三选一传入
		/// </summary>
		private string mobile;
		/// <summary>
		/// 三方用户ID
		/// mobile/fans_id/open_user_id 三选一传入
		/// </summary>
		private string openUserId;

		public virtual string CardAlias
		{
			set
			{
				this.cardAlias = value;
			}
			get
			{
				return this.cardAlias;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(cardAlias, null))
			{
				@params["card_alias"] = cardAlias;
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
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}