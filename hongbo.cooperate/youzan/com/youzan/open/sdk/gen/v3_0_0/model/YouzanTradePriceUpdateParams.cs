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

    public class YouzanTradePriceUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 改价后允许是否允许买家再使用其他优惠，0 表示不允许，1 表示允许
		/// </summary>
		private long? isAllowPreference;
		/// <summary>
		/// 邮费价格(单位:元）
		/// </summary>
		private string postFee;
		/// <summary>
		/// 价格增减(单位:元）
		/// </summary>
		private string priceChange;
		/// <summary>
		/// 交易编号
		/// </summary>
		private string tid;

		public virtual long? IsAllowPreference
		{
			set
			{
				this.isAllowPreference = value;
			}
			get
			{
				return this.isAllowPreference;
			}
		}


		public virtual string PostFee
		{
			set
			{
				this.postFee = value;
			}
			get
			{
				return this.postFee;
			}
		}


		public virtual string PriceChange
		{
			set
			{
				this.priceChange = value;
			}
			get
			{
				return this.priceChange;
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
			if (isAllowPreference != null)
			{
				@params["is_allow_preference"] = isAllowPreference;
			}
			if (!string.ReferenceEquals(postFee, null))
			{
				@params["post_fee"] = postFee;
			}
			if (!string.ReferenceEquals(priceChange, null))
			{
				@params["price_change"] = priceChange;
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