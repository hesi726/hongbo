using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    //using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    //using Maps = com.google.common.collect.Maps;

    //using Multimap = com.google.common.collect.Multimap;

    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanCardvoucherValuecardInfoQueryParams : APIParams, FileParams
	{

		/// <summary>
		/// 用户buyerId（手机号码或者 buyer_id 二选一）
		/// </summary>
		private long? buyerId;
		/// <summary>
		/// 卡号
		/// </summary>
		private string cardNo;
		/// <summary>
		/// 用户手机号码（手机号码或者 buyer_id 二选一）
		/// </summary>
		private string mobile;

		public virtual long? BuyerId
		{
			set
			{
				this.buyerId = value;
			}
			get
			{
				return this.buyerId;
			}
		}


		public virtual string CardNo
		{
			set
			{
				this.cardNo = value;
			}
			get
			{
				return this.cardNo;
			}
		}


		public virtual string Mobile
		{
			set
			{
				this.mobile = value;
			}
			get
			{
				return this.mobile;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (buyerId != null)
			{
				@params["buyer_id"] = buyerId;
			}
			if (!string.ReferenceEquals(cardNo, null))
			{
				@params["card_no"] = cardNo;
			}
			if (!string.ReferenceEquals(mobile, null))
			{
				@params["mobile"] = mobile;
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