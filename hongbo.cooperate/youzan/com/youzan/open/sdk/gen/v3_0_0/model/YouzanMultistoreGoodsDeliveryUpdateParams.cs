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

    public class YouzanMultistoreGoodsDeliveryUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 网点id
		/// </summary>
		private long? offlineId;
		/// <summary>
		/// 商品配送方式,json字符串,结构如：{"335438058":{"express":1,"local_delivery":0,"self_fetch":0}} 其中 express 为快递；local_delivery 为同城送；self_fetch 为到店自提。1为开启0为关闭。
		/// </summary>
		private string settings;

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


		public virtual string Settings
		{
			set
			{
				this.settings = value;
			}
			get
			{
				return this.settings;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (offlineId != null)
			{
				@params["offline_id"] = offlineId;
			}
			if (!string.ReferenceEquals(settings, null))
			{
				@params["settings"] = settings;
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