using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v1_0_1.model
{
    using global::youzan.com.youzan.open.sdk.model;

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;

    ////using Maps = com.google.common.collect.Maps;

    ////using Multimap = com.google.common.collect.Multimap;

    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanPayAcctransBillDetailGetListParams : APIParams, FileParams
	{

		/// <summary>
		/// 账户类型
		/// </summary>
		private long? accountType;
		/// <summary>
		/// 开始时间，单位为秒
		/// </summary>
		private long? beginTime;
		/// <summary>
		/// 结束时间，单位为秒
		/// </summary>
		private long? endTime;
		/// <summary>
		/// 收支记录类型
		/// </summary>
		private long? inoutLogType;
		/// <summary>
		/// 收支记录类型list
		/// </summary>
		private string inoutLogTypes;
		/// <summary>
		/// 外部业务号，例如订单号
		/// </summary>
		private string outBizNo;
		/// <summary>
		/// 分页编号
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 分页大小
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 商户号
		/// </summary>
		private string partnerId;

		public virtual long? AccountType
		{
			set
			{
				this.accountType = value;
			}
			get
			{
				return this.accountType;
			}
		}


		public virtual long? BeginTime
		{
			set
			{
				this.beginTime = value;
			}
			get
			{
				return this.beginTime;
			}
		}


		public virtual long? EndTime
		{
			set
			{
				this.endTime = value;
			}
			get
			{
				return this.endTime;
			}
		}


		public virtual long? InoutLogType
		{
			set
			{
				this.inoutLogType = value;
			}
			get
			{
				return this.inoutLogType;
			}
		}


		public virtual string InoutLogTypes
		{
			set
			{
				this.inoutLogTypes = value;
			}
			get
			{
				return this.inoutLogTypes;
			}
		}


		public virtual string OutBizNo
		{
			set
			{
				this.outBizNo = value;
			}
			get
			{
				return this.outBizNo;
			}
		}


		public virtual long? PageNo
		{
			set
			{
				this.pageNo = value;
			}
			get
			{
				return this.pageNo;
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


		public virtual string PartnerId
		{
			set
			{
				this.partnerId = value;
			}
			get
			{
				return this.partnerId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (accountType != null)
			{
				@params["account_type"] = accountType;
			}
			if (beginTime != null)
			{
				@params["begin_time"] = beginTime;
			}
			if (endTime != null)
			{
				@params["end_time"] = endTime;
			}
			if (inoutLogType != null)
			{
				@params["inout_log_type"] = inoutLogType;
			}
			if (!string.ReferenceEquals(inoutLogTypes, null))
			{
				@params["inout_log_types"] = inoutLogTypes;
			}
			if (!string.ReferenceEquals(outBizNo, null))
			{
				@params["out_biz_no"] = outBizNo;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(partnerId, null))
			{
				@params["partner_id"] = partnerId;
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