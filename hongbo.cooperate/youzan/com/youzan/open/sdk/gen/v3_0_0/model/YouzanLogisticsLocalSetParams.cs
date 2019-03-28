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

    public class YouzanLogisticsLocalSetParams : APIParams, FileParams
	{

		/// <summary>
		/// 最多提前几天下订单, 仅限当天：0
		/// </summary>
		private long? aheadMax;
		/// <summary>
		/// 最多提前几天下订单, 类型, 默认 DAY
		/// </summary>
		private string aheadMaxType;
		/// <summary>
		/// 订单开始的偏移量
		/// </summary>
		private long? aheadMin;
		/// <summary>
		/// 订单结束的偏移量   目前默认单位：DAY 日；HOUR 小时；HALFHOUR分钟
		/// </summary>
		private string aheadMinType;
		/// <summary>
		/// 配送区域图片
		/// </summary>
		private string attachPic;
		/// <summary>
		/// 配送费用
		/// </summary>
		private long? deliveryFee;
		/// <summary>
		/// 配送区域介绍
		/// </summary>
		private string desc;
		/// <summary>
		/// 开启定时达功能,定时达功能开启后timeBucket参数必填
		/// </summary>
		private bool? isOpen;
		/// <summary>
		/// 纬度
		/// </summary>
		private float? lat;
		/// <summary>
		/// 径度
		/// </summary>
		private float? lng;
		/// <summary>
		/// 多边形区域配置
		/// </summary>
		private string polygon;
		/// <summary>
		/// 本地配送范围(里）
		/// </summary>
		private long? scope;
		/// <summary>
		/// 0：简单 1：半径 2：自定义
		/// </summary>
		private long? scopeType;
		/// <summary>
		/// 订单起送金额
		/// </summary>
		private long? startFee;
		/// <summary>
		/// 营业时间周期，2进制表示7天的开关，第一位是周一转换成List<LocalDeliveryTimeBucketParam>
		/// </summary>
		private string timeBucket;
		/// <summary>
		/// 送达时间细分 DAY 天；MEAL 上午下午晚上； HOUR 小时；HALFHOUR 半小时
		/// </summary>
		private string timeSpan;

		public virtual long? AheadMax
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


		public virtual long? AheadMin
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


		public virtual string AttachPic
		{
			set
			{
				this.attachPic = value;
			}
			get
			{
				return this.attachPic;
			}
		}


		public virtual long? DeliveryFee
		{
			set
			{
				this.deliveryFee = value;
			}
			get
			{
				return this.deliveryFee;
			}
		}


		public virtual string Desc
		{
			set
			{
				this.desc = value;
			}
			get
			{
				return this.desc;
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


		public virtual float? Lat
		{
			set
			{
				this.lat = value;
			}
			get
			{
				return this.lat;
			}
		}


		public virtual float? Lng
		{
			set
			{
				this.lng = value;
			}
			get
			{
				return this.lng;
			}
		}


		public virtual string Polygon
		{
			set
			{
				this.polygon = value;
			}
			get
			{
				return this.polygon;
			}
		}


		public virtual long? Scope
		{
			set
			{
				this.scope = value;
			}
			get
			{
				return this.scope;
			}
		}


		public virtual long? ScopeType
		{
			set
			{
				this.scopeType = value;
			}
			get
			{
				return this.scopeType;
			}
		}


		public virtual long? StartFee
		{
			set
			{
				this.startFee = value;
			}
			get
			{
				return this.startFee;
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
			if (!string.ReferenceEquals(attachPic, null))
			{
				@params["attach_pic"] = attachPic;
			}
			if (deliveryFee != null)
			{
				@params["delivery_fee"] = deliveryFee;
			}
			if (!string.ReferenceEquals(desc, null))
			{
				@params["desc"] = desc;
			}
			if (isOpen != null)
			{
				@params["is_open"] = isOpen;
			}
			if (lat != null)
			{
				@params["lat"] = lat;
			}
			if (lng != null)
			{
				@params["lng"] = lng;
			}
			if (!string.ReferenceEquals(polygon, null))
			{
				@params["polygon"] = polygon;
			}
			if (scope != null)
			{
				@params["scope"] = scope;
			}
			if (scopeType != null)
			{
				@params["scope_type"] = scopeType;
			}
			if (startFee != null)
			{
				@params["start_fee"] = startFee;
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