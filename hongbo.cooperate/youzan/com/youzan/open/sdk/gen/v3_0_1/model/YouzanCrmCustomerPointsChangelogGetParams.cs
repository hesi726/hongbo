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

    public class YouzanCrmCustomerPointsChangelogGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 商家签名模式调用接口时的app_id, 若无则无需填写。
		/// </summary>
		private string appId;
		/// <summary>
		/// 结束时间（以start_date开始7天内的某个时刻）
		/// </summary>
		private string endDate;
		/// <summary>
		/// 粉丝id
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
		/// 页码
		/// </summary>
		private long? page;
		/// <summary>
		/// 分页大小
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 起始时间（30天内的某个时刻, 默认取7天内的记录）例如20170821080808
		/// </summary>
		private string startDate;

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


		public virtual string EndDate
		{
			set
			{
				this.endDate = value;
			}
			get
			{
				return this.endDate;
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


		public virtual long? Page
		{
			set
			{
				this.page = value;
			}
			get
			{
				return this.page;
			}
		}


		public virtual long? PageSize
		{
			set
			{
				this.pageSize = value;
			}
			get
			{
				return this.pageSize;
			}
		}


		public virtual string StartDate
		{
			set
			{
				this.startDate = value;
			}
			get
			{
				return this.startDate;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(appId, null))
			{
				@params["app_id"] = appId;
			}
			if (!string.ReferenceEquals(endDate, null))
			{
				@params["end_date"] = endDate;
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
			if (page != null)
			{
				@params["page"] = page;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(startDate, null))
			{
				@params["start_date"] = startDate;
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