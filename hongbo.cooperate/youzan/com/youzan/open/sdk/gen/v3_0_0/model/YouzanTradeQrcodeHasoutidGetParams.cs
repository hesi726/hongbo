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

    public class YouzanTradeQrcodeHasoutidGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 外部订单号
		/// </summary>
		private string outId;
		/// <summary>
		/// 外部来源（由有赞分配）
		/// </summary>
		private string outSource;

		public virtual string OutId
		{
			set
			{
				this.outId = value;
			}
			get
			{
				return this.outId;
			}
		}


		public virtual string OutSource
		{
			set
			{
				this.outSource = value;
			}
			get
			{
				return this.outSource;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(outId, null))
			{
				@params["out_id"] = outId;
			}
			if (!string.ReferenceEquals(outSource, null))
			{
				@params["out_source"] = outSource;
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