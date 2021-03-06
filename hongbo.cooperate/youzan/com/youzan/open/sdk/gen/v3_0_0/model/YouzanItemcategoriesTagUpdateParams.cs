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

    public class YouzanItemcategoriesTagUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品分组的名称
		/// </summary>
		private string name;
		/// <summary>
		/// 商品分组ID
		/// </summary>
		private long? tagId;

		public virtual string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name;
			}
		}


		public virtual long? TagId
		{
			set
			{
				this.tagId = value;
			}
			get
			{
				return this.tagId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(name, null))
			{
				@params["name"] = name;
			}
			if (tagId != null)
			{
				@params["tag_id"] = tagId;
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