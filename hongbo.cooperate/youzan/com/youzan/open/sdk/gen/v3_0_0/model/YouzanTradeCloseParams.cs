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

    public class YouzanTradeCloseParams : APIParams, FileParams
	{

		/// <summary>
		/// 关闭交易的原因
		/// </summary>
		private string closeReason;
		/// <summary>
		/// 关闭原因代码 10 => '无法联系上买家', 11 => '买家误拍或重拍了', 12 => '买家无诚意完成交易', 13 => '已通过银行线下汇款', 14 => '已通过同城见面交易', 15 => '已通过货到付款交易', 16 => '已通过网上银行直接汇款', 17 => '已经缺货无法交易'
		/// </summary>
		private string closeReasonId;
		/// <summary>
		/// 交易订单号
		/// </summary>
		private string tid;

		public virtual string CloseReason
		{
			set
			{
				this.closeReason = value;
			}
			get
			{
				return this.closeReason;
			}
		}


		public virtual string CloseReasonId
		{
			set
			{
				this.closeReasonId = value;
			}
			get
			{
				return this.closeReasonId;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(closeReason, null))
			{
				@params["close_reason"] = closeReason;
			}
			if (!string.ReferenceEquals(closeReasonId, null))
			{
				@params["close_reason_id"] = closeReasonId;
			}
			if (!string.ReferenceEquals(tid, null))
			{
				@params["tid"] = tid;
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