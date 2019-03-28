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

    public class YouzanTradeGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 指到需要返回的交易对象字段，如tid,title,receiver_city等
		/// </summary>
		private string fields;
		/// <summary>
		/// 指定获取子交易的第几页，不传则获取全部
		/// </summary>
		private long? subTradePageNo;
		/// <summary>
		/// 指定获取子交易的第几页，不传则获取全部
		/// </summary>
		private long? subTradePageSize;
		/// <summary>
		/// 交易订单号
		/// </summary>
		private string tid;
		/// <summary>
		/// 是否需要获取子订单,true为需要，false为不需要
		/// </summary>
		private bool? withChilds;

		public virtual string Fields
		{
			set
			{
				this.fields = value;
			}
			get
			{
				return this.fields;
			}
		}


		public virtual long? SubTradePageNo
		{
			set
			{
				this.subTradePageNo = value;
			}
			get
			{
				return this.subTradePageNo;
			}
		}


		public virtual long? SubTradePageSize
		{
			set
			{
				this.subTradePageSize = value;
			}
			get
			{
				return this.subTradePageSize;
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


		public virtual bool? WithChilds
		{
			set
			{
				this.withChilds = value;
			}
			get
			{
				return this.withChilds;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(fields, null))
			{
				@params["fields"] = fields;
			}
			if (subTradePageNo != null)
			{
				@params["sub_trade_page_no"] = subTradePageNo;
			}
			if (subTradePageSize != null)
			{
				@params["sub_trade_page_size"] = subTradePageSize;
			}
			if (!string.ReferenceEquals(tid, null))
			{
				@params["tid"] = tid;
			}
			if (withChilds != null)
			{
				@params["with_childs"] = withChilds;
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