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

    public class YouzanSalesmanAccountAddParams : APIParams, FileParams
	{

		/// <summary>
		/// 粉丝id（mobile 或 fans_id 选其一，另者置为0，都填以mobile为准）
		/// </summary>
		private long? fansId;
		/// <summary>
		/// 粉丝类型（自有粉丝: fans_type = 1）
		/// </summary>
		private long? fansType;
		/// <summary>
		/// 手机号（mobile 或 fans_id 选其一，另者置为0，都填以mobile为准）
		/// </summary>
		private string mobile;

		public virtual long? FansId
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


		public virtual long? FansType
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
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
			}
			if (fansType != null)
			{
				@params["fans_type"] = fansType;
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