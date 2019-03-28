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

    public class YouzanRetailProductCategoriesSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品分类id列表（根据分类id查询时要传）
		/// </summary>
		private string categoryIds;
		/// <summary>
		/// 商品分类层级(0代表所有子分类，1表示不需求子分类，2表示获取单层子分类)
		/// </summary>
		private long? level;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;

		public virtual string CategoryIds
		{
			set
			{
				this.categoryIds = value;
			}
			get
			{
				return this.categoryIds;
			}
		}


		public virtual long? Level
		{
			set
			{
				this.level = value;
			}
			get
			{
				return this.level;
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
			if (!string.ReferenceEquals(categoryIds, null))
			{
				@params["category_ids"] = categoryIds;
			}
			if (level != null)
			{
				@params["level"] = level;
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