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

    public class YouzanTradeCartDeleteParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品列表信息，goods_id(商品id)、sku_id(sku id)、kdt_id(店铺id)。
		/// 例如
		/// [{"kdt_id":55,"goods_id":1103945,"sku_id":2722}]
		/// </summary>
		private string itemList;
		/// <summary>
		/// 会话key,如果没有该值，填
		/// </summary>
		private string nobody;

		public virtual string ItemList
		{
			set
			{
				this.itemList = value;
			}
			get
			{
				return this.itemList;
			}
		}


		public virtual string Nobody
		{
			set
			{
				this.nobody = value;
			}
			get
			{
				return this.nobody;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(itemList, null))
			{
				@params["item_list"] = itemList;
			}
			if (!string.ReferenceEquals(nobody, null))
			{
				@params["nobody"] = nobody;
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