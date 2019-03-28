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

    public class YouzanRetailProductSkucategoriesUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 分类Id
		/// </summary>
		private long? categoryId;
		/// <summary>
		/// 待修改skuId列表
		/// </summary>
		private string skuIds;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;

		public virtual long? CategoryId
		{
			set
			{
				this.categoryId = value;
			}
			get
			{
				return this.categoryId;
			}
		}


		public virtual string SkuIds
		{
			set
			{
				this.skuIds = value;
			}
			get
			{
				return this.skuIds;
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
			if (categoryId != null)
			{
				@params["category_id"] = categoryId;
			}
			if (!string.ReferenceEquals(skuIds, null))
			{
				@params["sku_ids"] = skuIds;
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