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

    public class YouzanLogisticsOnlineConfirmParams : APIParams, FileParams
	{

		/// <summary>
		/// 发货是否无需物流(0表示否，1表示是)，默认为 0  。  如果为 0 则必须传递物流参数（out_stype和out_sid）；如果为 1 则无需传递物流参数（out_stype和out_sid）；
		/// </summary>
		private long? isNoExpress;
		/// <summary>
		/// 配送期次，周期购订单专用，例如：1，表示配送第1期
		/// </summary>
		private long? issue;
		/// <summary>
		/// 如果需要拆单发货，使用该字段指定要发货的商品交易明细编号，多个明细编号用半角逗号","分隔；  不需要拆单发货，则该字段不传或值为空；可通过订单列表接口获取，如https://www.youzanyun.com/apilist/detail/group_trade/trade/youzan.trades.sold.get
		/// </summary>
		private string oids;
		/// <summary>
		/// 快递单号（具体一个物流公司的真实快递单号），当is_no_express=0 时，为必传参数
		/// </summary>
		private string outSid;
		/// <summary>
		/// 物流公司编号，可以通过请求 youzan.logistics.express.get 该接口获得。当is_no_express=0 时，为必传参数
		/// </summary>
		private string outStype;
		/// <summary>
		/// 外部交易编号
		/// </summary>
		private string outerTid;
		/// <summary>
		/// 交易订单号，可通过订单列表接口获取，如https://www.youzanyun.com/apilist/detail/group_trade/trade/youzan.trades.sold.get
		/// </summary>
		private string tid;

		public virtual long? IsNoExpress
		{
			set
			{
				this.isNoExpress = value;
			}
			get
			{
				return this.isNoExpress;
			}
		}


		public virtual long? Issue
		{
			set
			{
				this.issue = value;
			}
			get
			{
				return this.issue;
			}
		}


		public virtual string Oids
		{
			set
			{
				this.oids = value;
			}
			get
			{
				return this.oids;
			}
		}


		public virtual string OutSid
		{
			set
			{
				this.outSid = value;
			}
			get
			{
				return this.outSid;
			}
		}


		public virtual string OutStype
		{
			set
			{
				this.outStype = value;
			}
			get
			{
				return this.outStype;
			}
		}


		public virtual string OuterTid
		{
			set
			{
				this.outerTid = value;
			}
			get
			{
				return this.outerTid;
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
			if (isNoExpress != null)
			{
				@params["is_no_express"] = isNoExpress;
			}
			if (issue != null)
			{
				@params["issue"] = issue;
			}
			if (!string.ReferenceEquals(oids, null))
			{
				@params["oids"] = oids;
			}
			if (!string.ReferenceEquals(outSid, null))
			{
				@params["out_sid"] = outSid;
			}
			if (!string.ReferenceEquals(outStype, null))
			{
				@params["out_stype"] = outStype;
			}
			if (!string.ReferenceEquals(outerTid, null))
			{
				@params["outer_tid"] = outerTid;
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