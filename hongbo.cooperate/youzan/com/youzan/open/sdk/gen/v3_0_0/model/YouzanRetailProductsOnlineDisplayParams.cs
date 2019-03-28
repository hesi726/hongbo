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

    public class YouzanRetailProductsOnlineDisplayParams : APIParams, FileParams
	{

		/// <summary>
		/// 上下架状态（0为下架， 1为上架）
		/// </summary>
		private long? display;
		/// <summary>
		/// 批量更新的网店商品id列表
		/// </summary>
		private string itemIds;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;

		public virtual long? Display
		{
			set
			{
				this.display = value;
			}
			get
			{
				return this.display;
			}
		}


		public virtual string ItemIds
		{
			set
			{
				this.itemIds = value;
			}
			get
			{
				return this.itemIds;
			}
		}


		public virtual string Source
		{
			set
			{
				this.source = value;
			}
			get
			{
				return this.source;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (display != null)
			{
				@params["display"] = display;
			}
			if (!string.ReferenceEquals(itemIds, null))
			{
				@params["item_ids"] = itemIds;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
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