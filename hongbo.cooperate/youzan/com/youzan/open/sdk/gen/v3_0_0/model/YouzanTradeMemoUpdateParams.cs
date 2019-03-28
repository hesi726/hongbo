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

    public class YouzanTradeMemoUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 订单备注加星标，取值为1-5
		/// </summary>
		private string flag;
		/// <summary>
		/// 订单备注
		/// </summary>
		private string memo;
		/// <summary>
		/// 订单号
		/// </summary>
		private string tid;

		public virtual string Flag
		{
			set
			{
				this.flag = value;
			}
			get
			{
				return this.flag;
			}
		}


		public virtual string Memo
		{
			set
			{
				this.memo = value;
			}
			get
			{
				return this.memo;
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
			if (!string.ReferenceEquals(flag, null))
			{
				@params["flag"] = flag;
			}
			if (!string.ReferenceEquals(memo, null))
			{
				@params["memo"] = memo;
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