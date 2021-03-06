﻿using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanMultistoreGoodsDeliveryGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品id
		/// </summary>
		private long? numIid;
		/// <summary>
		/// 网点id
		/// </summary>
		private long? offlineId;

		public virtual long? NumIid
		{
			set
			{
				this.numIid = value;
			}
			get
			{
				return this.numIid;
			}
		}


		public virtual long? OfflineId
		{
			set
			{
				this.offlineId = value;
			}
			get
			{
				return this.offlineId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (numIid != null)
			{
				@params["num_iid"] = numIid;
			}
			if (offlineId != null)
			{
				@params["offline_id"] = offlineId;
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