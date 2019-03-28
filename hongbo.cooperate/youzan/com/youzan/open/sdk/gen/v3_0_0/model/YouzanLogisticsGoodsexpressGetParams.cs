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

    public class YouzanLogisticsGoodsexpressGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 快递公司id
		/// </summary>
		private long? expressId;
		/// <summary>
		/// 物流单号
		/// </summary>
		private string expressNo;

		public virtual long? ExpressId
		{
			set
			{
				this.expressId = value;
			}
			get
			{
				return this.expressId;
			}
		}


		public virtual string ExpressNo
		{
			set
			{
				this.expressNo = value;
			}
			get
			{
				return this.expressNo;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (expressId != null)
			{
				@params["express_id"] = expressId;
			}
			if (!string.ReferenceEquals(expressNo, null))
			{
				@params["express_no"] = expressNo;
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