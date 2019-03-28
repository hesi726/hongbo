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

    public class YouzanPaySubmerchantAuthQueryParams : APIParams, FileParams
	{

		/// <summary>
		/// 子商户商户号
		/// </summary>
		private long? mchId;
		/// <summary>
		/// 服务商商户号
		/// </summary>
		private long? partnerId;

		public virtual long? MchId
		{
			set
			{
				this.mchId = value;
			}
			get
			{
				return this.mchId;
			}
		}


		public virtual long? PartnerId
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
			if (mchId != null)
			{
				@params["mch_id"] = mchId;
			}
			if (partnerId != null)
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