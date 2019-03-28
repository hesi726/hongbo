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

    public class YouzanRetailStockVendorsSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 供应商名称
		/// </summary>
		private string name;
		/// <summary>
		/// 名称or手机
		/// </summary>
		private string nameOrPhone;
		/// <summary>
		/// 是否仅启用
		/// </summary>
		private bool? onlyEnable;
		/// <summary>
		/// 分页index
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 分页大小
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 调用来源
		/// </summary>
		private string source;

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


		public virtual string NameOrPhone
		{
			set
			{
				this.nameOrPhone = value;
			}
			get
			{
				return this.nameOrPhone;
			}
		}


		public virtual bool? OnlyEnable
		{
			set
			{
				this.onlyEnable = value;
			}
			get
			{
				return this.onlyEnable;
			}
		}


		public virtual long? PageNo
		{
			set
			{
				this.pageNo = value;
			}
			get
			{
				return this.pageNo;
			}
		}


		public virtual long? PageSize
		{
			set
			{
				this.pageSize = value;
			}
			get
			{
				return this.pageSize;
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
			if (!string.ReferenceEquals(name, null))
			{
				@params["name"] = name;
			}
			if (!string.ReferenceEquals(nameOrPhone, null))
			{
				@params["name_or_phone"] = nameOrPhone;
			}
			if (onlyEnable != null)
			{
				@params["only_enable"] = onlyEnable;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
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