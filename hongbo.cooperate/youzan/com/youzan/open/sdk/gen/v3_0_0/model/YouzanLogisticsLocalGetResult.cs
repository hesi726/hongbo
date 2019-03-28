namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanLogisticsLocalGetResult : APIResult
	{



		/// <summary>
		/// 最多提前几天下订单, 类型, 默认 DAY
		/// </summary>
[Newtonsoft.Json.JsonProperty("aheadMaxType")]//) private String aheadMaxType;
		private string aheadMaxType;


		/// <summary>
		/// 径度
		/// </summary>
[Newtonsoft.Json.JsonProperty("lng")]//) private Nullable<long> lng;
		private long? lng;


		/// <summary>
		/// 店铺id
		/// </summary>
[Newtonsoft.Json.JsonProperty("kdtId")]//) private Nullable<long> kdtId;
		private long? kdtId;


		/// <summary>
		/// 订单开始的偏移量
		/// </summary>
[Newtonsoft.Json.JsonProperty("aheadMin")]//) private Nullable<long> aheadMin;
		private long? aheadMin;


		/// <summary>
		/// 配送费用
		/// </summary>
[Newtonsoft.Json.JsonProperty("deliveryFee")]//) private Nullable<long> deliveryFee;
		private long? deliveryFee;


		/// <summary>
		/// 开启定时达功能
		/// </summary>
[Newtonsoft.Json.JsonProperty("isOpen")]//) private Nullable<bool> isOpen;
		private bool? isOpen;


		/// <summary>
		/// 订单结束的偏移量   目前默认单位：DAY 日；HOUR 小时；HALFHOUR分钟
		/// </summary>
[Newtonsoft.Json.JsonProperty("aheadMinType")]//) private String aheadMinType;
		private string aheadMinType;


		/// <summary>
		/// 多边形区域配置
		/// </summary>
[Newtonsoft.Json.JsonProperty("polygon")]//) private String polygon;
		private string polygon;


		/// <summary>
		/// 0：简单 1：半径 2：自定义
		/// </summary>
[Newtonsoft.Json.JsonProperty("scopeType")]//) private Nullable<long> scopeType;
		private long? scopeType;


		/// <summary>
		/// 本地配送范围(里）
		/// </summary>
[Newtonsoft.Json.JsonProperty("scope")]//) private Nullable<long> scope;
		private long? scope;


		/// <summary>
		/// 配送区域图片
		/// </summary>
[Newtonsoft.Json.JsonProperty("attachPic")]//) private String attachPic;
		private string attachPic;


		/// <summary>
		/// 订单起送金额
		/// </summary>
[Newtonsoft.Json.JsonProperty("startFee")]//) private Nullable<long> startFee;
		private long? startFee;


		/// <summary>
		/// 最多提前几天下订单, 仅限当天：0
		/// </summary>
[Newtonsoft.Json.JsonProperty("aheadMax")]//) private Nullable<long> aheadMax;
		private long? aheadMax;


		/// <summary>
		/// 送达时间细分 DAY 天；MEAL 上午下午晚上； HOUR 小时；HALFHOUR 半小时
		/// </summary>
[Newtonsoft.Json.JsonProperty("timeSpan")]//) private String timeSpan;
		private string timeSpan;


		/// <summary>
		/// 营业时间周期，2进制表示7天的开关，第一位是周一
		/// </summary>
[Newtonsoft.Json.JsonProperty("timeBucket")]//) private LogisticsLocalDeliveryTimeBucketParam[] timeBucket;
		private LogisticsLocalDeliveryTimeBucketParam[] timeBucket;


		/// <summary>
		/// 纬度
		/// </summary>
[Newtonsoft.Json.JsonProperty("lat")]//) private Nullable<long> lat;
		private long? lat;


		/// <summary>
		/// 配送区域介绍
		/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
		private string desc;

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

		public virtual long? Lng
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

		public virtual long? KdtId
		{
			set
			{
				this.kdtId = value;
			}
			get
			{
				return this.kdtId;
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

		public virtual LogisticsLocalDeliveryTimeBucketParam[] TimeBucket
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

		public virtual long? Lat
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


		public class LogisticsLocalDeliveryTimeBucketParam
		{

		}


	}
}