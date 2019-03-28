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

    public class YouzanRegionsGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 需要返回的区域地名对象字段
		/// </summary>
		private string fields;
		/// <summary>
		/// 区域ID
		/// </summary>
		private long? id;
		/// <summary>
		/// 要获取的区域等级
		/// </summary>
		private long? level;
		/// <summary>
		/// 区域父级ID
		/// </summary>
		private long? parentId;

		public virtual string Fields
		{
			set
			{
				this.fields = value;
			}
			get
			{
				return this.fields;
			}
		}


		public virtual long? Id
		{
			set
			{
				this.id = value;
			}
			get
			{
				return this.id;
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


		public virtual long? ParentId
		{
			set
			{
				this.parentId = value;
			}
			get
			{
				return this.parentId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(fields, null))
			{
				@params["fields"] = fields;
			}
			if (id != null)
			{
				@params["id"] = id;
			}
			if (level != null)
			{
				@params["level"] = level;
			}
			if (parentId != null)
			{
				@params["parent_id"] = parentId;
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