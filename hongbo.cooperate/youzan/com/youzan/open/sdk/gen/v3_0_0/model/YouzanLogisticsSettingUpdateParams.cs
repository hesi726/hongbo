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

    public class YouzanLogisticsSettingUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 计费类型
		/// </summary>
		private long? calcType;
		/// <summary>
		/// 是否支持快递
		/// </summary>
		private bool? isExpress;
		/// <summary>
		/// 是否支持同城
		/// </summary>
		private bool? isLocal;
		/// <summary>
		/// 是否支持自提
		/// </summary>
		private bool? isSelf;
		/// <summary>
		/// 门店id 可不传，预留字段
		/// </summary>
		private long? offlineId;

		public virtual long? CalcType
		{
			set
			{
				this.calcType = value;
			}
			get
			{
				return this.calcType;
			}
		}


		public virtual bool? IsExpress
		{
			set
			{
				this.isExpress = value;
			}
			get
			{
				return this.isExpress;
			}
		}


		public virtual bool? IsLocal
		{
			set
			{
				this.isLocal = value;
			}
			get
			{
				return this.isLocal;
			}
		}


		public virtual bool? IsSelf
		{
			set
			{
				this.isSelf = value;
			}
			get
			{
				return this.isSelf;
			}
		}


		public virtual long? OfflineId
		{
			set
			{
				this.offlineId = value;
			}
			get
			{
				return this.offlineId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (calcType != null)
			{
				@params["calc_type"] = calcType;
			}
			if (isExpress != null)
			{
				@params["is_express"] = isExpress;
			}
			if (isLocal != null)
			{
				@params["is_local"] = isLocal;
			}
			if (isSelf != null)
			{
				@params["is_self"] = isSelf;
			}
			if (offlineId != null)
			{
				@params["offline_id"] = offlineId;
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