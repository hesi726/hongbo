namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanPayQrcodeGetResult : APIResult
	{



		/// <summary>
		/// 二维码图片id
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_id")]//) private Nullable<long> qrId;
		private long? qrId;


		/// <summary>
		/// 二维码名称
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_name")]//) private String qrName;
		private string qrName;


		/// <summary>
		/// 二维码金额，以分为单位
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_price")]//) private Nullable<long> qrPrice;
		private long? qrPrice;


		/// <summary>
		/// 图片源信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_code")]//) private String qrCode;
		private string qrCode;


		/// <summary>
		/// 二维码关联URL
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_url")]//) private String qrUrl;
		private string qrUrl;


		/// <summary>
		/// 二维码类型
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_type")]//) private String qrType;
		private string qrType;


		/// <summary>
		/// 二维码生成来源
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_source")]//) private String qrSource;
		private string qrSource;


		/// <summary>
		/// 优惠信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("activityInfo")]//) private String activityInfo;
		private string activityInfo;


		/// <summary>
		/// 生成时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_created_time")]//) private String qrCreatedTime;
		private string qrCreatedTime;

		public virtual long? QrId
		{
			set
			{
				this.qrId = value;
			}
			get
			{
				return this.qrId;
			}
		}

		public virtual string QrName
		{
			set
			{
				this.qrName = value;
			}
			get
			{
				return this.qrName;
			}
		}

		public virtual long? QrPrice
		{
			set
			{
				this.qrPrice = value;
			}
			get
			{
				return this.qrPrice;
			}
		}

		public virtual string QrCode
		{
			set
			{
				this.qrCode = value;
			}
			get
			{
				return this.qrCode;
			}
		}

		public virtual string QrUrl
		{
			set
			{
				this.qrUrl = value;
			}
			get
			{
				return this.qrUrl;
			}
		}

		public virtual string QrType
		{
			set
			{
				this.qrType = value;
			}
			get
			{
				return this.qrType;
			}
		}

		public virtual string QrSource
		{
			set
			{
				this.qrSource = value;
			}
			get
			{
				return this.qrSource;
			}
		}

		public virtual string ActivityInfo
		{
			set
			{
				this.activityInfo = value;
			}
			get
			{
				return this.activityInfo;
			}
		}

		public virtual string QrCreatedTime
		{
			set
			{
				this.qrCreatedTime = value;
			}
			get
			{
				return this.qrCreatedTime;
			}
		}



	}
}