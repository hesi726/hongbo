namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMultistoreOfflineGetResult : APIResult
	{



		/// <summary>
		/// 网点id
		/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
		private long? id;


		/// <summary>
		/// 网点名称
		/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
		private string name;


		/// <summary>
		/// 是否是门店。只有是门店才能设置同城配送
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_store")]//) private Nullable<long> isStore;
		private long? isStore;


		/// <summary>
		/// 是否是自提点。只有是自提点才能设置到店自提
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_self_fetch")]//) private Nullable<long> isSelfFetch;
		private long? isSelfFetch;


		/// <summary>
		/// 是否支持同城配送
		/// </summary>
[Newtonsoft.Json.JsonProperty("support_local_delivery")]//) private Nullable<long> supportLocalDelivery;
		private long? supportLocalDelivery;


		/// <summary>
		/// 同城配送范围，单位米。
		/// </summary>
[Newtonsoft.Json.JsonProperty("local_delivery_scope")]//) private Nullable<long> localDeliveryScope;
		private long? localDeliveryScope;


		/// <summary>
		/// 同城配送起送金额，单位分
		/// </summary>
[Newtonsoft.Json.JsonProperty("local_delivery_start_amount")]//) private Nullable<long> localDeliveryStartAmount;
		private long? localDeliveryStartAmount;


		/// <summary>
		/// 同城配送费，单位分
		/// </summary>
[Newtonsoft.Json.JsonProperty("local_delivery_fee")]//) private Nullable<long> localDeliveryFee;
		private long? localDeliveryFee;


		/// <summary>
		/// 电话区号
		/// </summary>
[Newtonsoft.Json.JsonProperty("phone1")]//) private String phone1;
		private string phone1;


		/// <summary>
		/// 电话号码
		/// </summary>
[Newtonsoft.Json.JsonProperty("phone2")]//) private String phone2;
		private string phone2;


		/// <summary>
		/// 省
		/// </summary>
[Newtonsoft.Json.JsonProperty("province")]//) private String province;
		private string province;


		/// <summary>
		/// 市
		/// </summary>
[Newtonsoft.Json.JsonProperty("city")]//) private String city;
		private string city;


		/// <summary>
		/// 区
		/// </summary>
[Newtonsoft.Json.JsonProperty("area")]//) private String area;
		private string area;


		/// <summary>
		/// 详细地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("address")]//) private String address;
		private string address;


		/// <summary>
		/// 省市区编码
		/// </summary>
[Newtonsoft.Json.JsonProperty("county_id")]//) private Nullable<long> countyId;
		private long? countyId;


		/// <summary>
		/// 经度
		/// </summary>
[Newtonsoft.Json.JsonProperty("lng")]//) private String lng;
		private string lng;


		/// <summary>
		/// 纬度
		/// </summary>
[Newtonsoft.Json.JsonProperty("lat")]//) private String lat;
		private string lat;


		/// <summary>
		/// 营业时间设置数组
		/// </summary>
[Newtonsoft.Json.JsonProperty("business_hours_advanced")]//) private String businessHoursAdvanced;
		private string businessHoursAdvanced;


		/// <summary>
		/// 图片链接数组
		/// </summary>
[Newtonsoft.Json.JsonProperty("image")]//) private String[] image;
		private string[] image;


		/// <summary>
		/// 网点描述
		/// </summary>
[Newtonsoft.Json.JsonProperty("description")]//) private String description;
		private string description;

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

		public virtual long? IsStore
		{
			set
			{
				this.isStore = value;
			}
			get
			{
				return this.isStore;
			}
		}

		public virtual long? IsSelfFetch
		{
			set
			{
				this.isSelfFetch = value;
			}
			get
			{
				return this.isSelfFetch;
			}
		}

		public virtual long? SupportLocalDelivery
		{
			set
			{
				this.supportLocalDelivery = value;
			}
			get
			{
				return this.supportLocalDelivery;
			}
		}

		public virtual long? LocalDeliveryScope
		{
			set
			{
				this.localDeliveryScope = value;
			}
			get
			{
				return this.localDeliveryScope;
			}
		}

		public virtual long? LocalDeliveryStartAmount
		{
			set
			{
				this.localDeliveryStartAmount = value;
			}
			get
			{
				return this.localDeliveryStartAmount;
			}
		}

		public virtual long? LocalDeliveryFee
		{
			set
			{
				this.localDeliveryFee = value;
			}
			get
			{
				return this.localDeliveryFee;
			}
		}

		public virtual string Phone1
		{
			set
			{
				this.phone1 = value;
			}
			get
			{
				return this.phone1;
			}
		}

		public virtual string Phone2
		{
			set
			{
				this.phone2 = value;
			}
			get
			{
				return this.phone2;
			}
		}

		public virtual string Province
		{
			set
			{
				this.province = value;
			}
			get
			{
				return this.province;
			}
		}

		public virtual string City
		{
			set
			{
				this.city = value;
			}
			get
			{
				return this.city;
			}
		}

		public virtual string Area
		{
			set
			{
				this.area = value;
			}
			get
			{
				return this.area;
			}
		}

		public virtual string Address
		{
			set
			{
				this.address = value;
			}
			get
			{
				return this.address;
			}
		}

		public virtual long? CountyId
		{
			set
			{
				this.countyId = value;
			}
			get
			{
				return this.countyId;
			}
		}

		public virtual string Lng
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

		public virtual string Lat
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

		public virtual string BusinessHoursAdvanced
		{
			set
			{
				this.businessHoursAdvanced = value;
			}
			get
			{
				return this.businessHoursAdvanced;
			}
		}

		public virtual string[] Image
		{
			set
			{
				this.image = value;
			}
			get
			{
				return this.image;
			}
		}

		public virtual string Description
		{
			set
			{
				this.description = value;
			}
			get
			{
				return this.description;
			}
		}



	}
}