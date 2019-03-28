using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v1_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanItemStandardGetbycodeParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品条码，通用编码，不是商家编码
		/// </summary>
		private string code;
		/// <summary>
		/// 商品类型
		/// </summary>
		private long? itemType;

		public virtual string Code
		{
			set
			{
				this.code = value;
			}
			get
			{
				return this.code;
			}
		}


		public virtual long? ItemType
		{
			set
			{
				this.itemType = value;
			}
			get
			{
				return this.itemType;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(code, null))
			{
				@params["code"] = code;
			}
			if (itemType != null)
			{
				@params["item_type"] = itemType;
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