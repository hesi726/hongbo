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

    public class YouzanUmpPromotionGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 有赞手机注册账号id
		/// </summary>
		private string buyerId;
		/// <summary>
		/// 粉丝id
		/// </summary>
		private string fansId;
		/// <summary>
		/// 粉丝类型
		/// </summary>
		private string fansType;
		/// <summary>
		/// 商品别名。item_id和item_alias两者必须传一个
		/// </summary>
		private string itemAlias;
		/// <summary>
		/// 商品id。item_id和item_alias两者必须传一个
		/// </summary>
		private long? itemId;

		public virtual string BuyerId
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


		public virtual string FansId
		{
			set
			{
				this.fansId = value;
			}
			get
			{
				return this.fansId;
			}
		}


		public virtual string FansType
		{
			set
			{
				this.fansType = value;
			}
			get
			{
				return this.fansType;
			}
		}


		public virtual string ItemAlias
		{
			set
			{
				this.itemAlias = value;
			}
			get
			{
				return this.itemAlias;
			}
		}


		public virtual long? ItemId
		{
			set
			{
				this.itemId = value;
			}
			get
			{
				return this.itemId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(buyerId, null))
			{
				@params["buyer_id"] = buyerId;
			}
			if (!string.ReferenceEquals(fansId, null))
			{
				@params["fans_id"] = fansId;
			}
			if (!string.ReferenceEquals(fansType, null))
			{
				@params["fans_type"] = fansType;
			}
			if (!string.ReferenceEquals(itemAlias, null))
			{
				@params["item_alias"] = itemAlias;
			}
			if (itemId != null)
			{
				@params["item_id"] = itemId;
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