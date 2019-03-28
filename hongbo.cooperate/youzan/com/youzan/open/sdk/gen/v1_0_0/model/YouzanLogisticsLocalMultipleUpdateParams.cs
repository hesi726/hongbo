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

    public class YouzanLogisticsLocalMultipleUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 商家最长预约时间，和ahead_max_type配对使用，默认0
		/// </summary>
		private int? aheadMax;
		/// <summary>
		/// 商家最长预约时间类型   目前默认单位：day 日，目前只支持day
		/// </summary>
		private string aheadMaxType;
		/// <summary>
		/// 商家预约下单提前时间，和ahead_min_type配对使用，默认0
		/// </summary>
		private int? aheadMin;
		/// <summary>
		/// 商家预约下单提前时间类型   目前默认单位：day 日；hour 小时；minute分钟
		/// </summary>
		private string aheadMinType;
		/// <summary>
		/// 多区域对象信息，参数为list对象的json字符串
		/// </summary>
		private string areaParamList;
		/// <summary>
		/// 是否开启定时达功能，true:开启，false:关闭
		/// </summary>
		private bool? isOpen;
		/// <summary>
		/// 多网点id，单门店不填，该值默认就是0
		/// </summary>
		private long? offlineId;
		/// <summary>
		/// 买家配送时段，定时达不开启可以不传，参数为list对象的json字符串
		/// </summary>
		private string timeBucket;
		/// <summary>
		/// 买家可选的送达时间细分 day 天；meal 上午下午晚上； hour 小时；halfhour 半小时
		/// </summary>
		private string timeSpan;

		public virtual int? AheadMax
		{
			set
			{
				this.aheadMax = value;
			}
			get
			{
				return this.aheadMax;
			}
		}


		public virtual string AheadMaxType
		{
			set
			{
				this.aheadMaxType = value;
			}
			get
			{
				return this.aheadMaxType;
			}
		}


		public virtual int? AheadMin
		{
			set
			{
				this.aheadMin = value;
			}
			get
			{
				return this.aheadMin;
			}
		}


		public virtual string AheadMinType
		{
			set
			{
				this.aheadMinType = value;
			}
			get
			{
				return this.aheadMinType;
			}
		}


		public virtual string AreaParamList
		{
			set
			{
				this.areaParamList = value;
			}
			get
			{
				return this.areaParamList;
			}
		}


		public virtual bool? IsOpen
		{
			set
			{
				this.isOpen = value;
			}
			get
			{
				return this.isOpen;
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


		public virtual string TimeBucket
		{
			set
			{
				this.timeBucket = value;
			}
			get
			{
				return this.timeBucket;
			}
		}


		public virtual string TimeSpan
		{
			set
			{
				this.timeSpan = value;
			}
			get
			{
				return this.timeSpan;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (aheadMax != null)
			{
				@params["ahead_max"] = aheadMax;
			}
			if (!string.ReferenceEquals(aheadMaxType, null))
			{
				@params["ahead_max_type"] = aheadMaxType;
			}
			if (aheadMin != null)
			{
				@params["ahead_min"] = aheadMin;
			}
			if (!string.ReferenceEquals(aheadMinType, null))
			{
				@params["ahead_min_type"] = aheadMinType;
			}
			if (!string.ReferenceEquals(areaParamList, null))
			{
				@params["area_param_list"] = areaParamList;
			}
			if (isOpen != null)
			{
				@params["is_open"] = isOpen;
			}
			if (offlineId != null)
			{
				@params["offline_id"] = offlineId;
			}
			if (!string.ReferenceEquals(timeBucket, null))
			{
				@params["time_bucket"] = timeBucket;
			}
			if (!string.ReferenceEquals(timeSpan, null))
			{
				@params["time_span"] = timeSpan;
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