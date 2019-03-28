using System.Collections.Generic;
using youzan.com.youzan.open.sdk.model;

namespace com.youzan.open.sdk.gen.v4_0_0.model
{

	//using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
	//using Maps = com.google.common.collect.Maps;
	//using Multimap = com.google.common.collect.Multimap;
	using APIParams = com.youzan.open.sdk.model.APIParams;
	using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
	using FileParams = com.youzan.open.sdk.model.FileParams;

	public class YouzanTradeGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 订单号
		/// </summary>
		private string tid;

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