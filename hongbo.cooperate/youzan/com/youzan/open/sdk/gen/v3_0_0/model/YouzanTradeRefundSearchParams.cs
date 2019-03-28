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

    public class YouzanTradeRefundSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 时间范围查询 退款创建截止时间时间戳 (单位为秒) 例如:1513868400
		/// </summary>
		private long? createTimeEnd;
		/// <summary>
		/// 时间范围查询 退款创建起始时间时间戳 (单位为秒) 例如:1513785600
		/// </summary>
		private long? createTimeStart;
		/// <summary>
		/// 分页数
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页显示个数
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 退款号
		/// </summary>
		private string refundId;
		/// <summary>
		/// 退款状态:
		/// WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意)，
		/// WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货)，
		/// WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货)，
		/// SELLER_REFUSE_BUYER(卖家拒绝退款)，
		/// CLOSED(退款关闭)，
		/// SUCCESS(退款成功)。
		/// </summary>
		private string status;
		/// <summary>
		/// 订单号
		/// </summary>
		private string tid;
		/// <summary>
		/// 时间范围查询 退款更新截止时间时间戳 （单位为秒）例如:1513868400
		/// </summary>
		private long? updateTimeEnd;
		/// <summary>
		/// 时间范围查询 退款更新起始时间时间戳 （单位为秒）例如:1513785600
		/// </summary>
		private long? updateTimeStart;

		public virtual long? CreateTimeEnd
		{
			set
			{
				this.createTimeEnd = value;
			}
			get
			{
				return this.createTimeEnd;
			}
		}


		public virtual long? CreateTimeStart
		{
			set
			{
				this.createTimeStart = value;
			}
			get
			{
				return this.createTimeStart;
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


		public virtual string RefundId
		{
			set
			{
				this.refundId = value;
			}
			get
			{
				return this.refundId;
			}
		}


		public virtual string Status
		{
			set
			{
				this.status = value;
			}
			get
			{
				return this.status;
			}
		}


		public virtual string Tid
		{
			set
			{
				this.tid = value;
			}
			get
			{
				return this.tid;
			}
		}


		public virtual long? UpdateTimeEnd
		{
			set
			{
				this.updateTimeEnd = value;
			}
			get
			{
				return this.updateTimeEnd;
			}
		}


		public virtual long? UpdateTimeStart
		{
			set
			{
				this.updateTimeStart = value;
			}
			get
			{
				return this.updateTimeStart;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (createTimeEnd != null)
			{
				@params["create_time_end"] = createTimeEnd;
			}
			if (createTimeStart != null)
			{
				@params["create_time_start"] = createTimeStart;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(refundId, null))
			{
				@params["refund_id"] = refundId;
			}
			if (!string.ReferenceEquals(status, null))
			{
				@params["status"] = status;
			}
			if (!string.ReferenceEquals(tid, null))
			{
				@params["tid"] = tid;
			}
			if (updateTimeEnd != null)
			{
				@params["update_time_end"] = updateTimeEnd;
			}
			if (updateTimeStart != null)
			{
				@params["update_time_start"] = updateTimeStart;
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