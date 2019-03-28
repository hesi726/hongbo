namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUserAddressGetResult : APIResult
	{



		/// <summary>
		/// 国家
		/// </summary>
[Newtonsoft.Json.JsonProperty("country")]//) private String country;
		private string country;


		/// <summary>
		/// 城市
		/// </summary>
[Newtonsoft.Json.JsonProperty("city")]//) private String city;
		private string city;


		/// <summary>
		/// 收货人
		/// </summary>
[Newtonsoft.Json.JsonProperty("user_name")]//) private String userName;
		private string userName;


		/// <summary>
		/// 区域码
		/// </summary>
[Newtonsoft.Json.JsonProperty("area_code")]//) private String areaCode;
		private string areaCode;


		/// <summary>
		/// 区
		/// </summary>
[Newtonsoft.Json.JsonProperty("county")]//) private String county;
		private string county;


		/// <summary>
		/// 经度
		/// </summary>
[Newtonsoft.Json.JsonProperty("lon")]//) private String lon;
		private string lon;


		/// <summary>
		/// 纬度
		/// </summary>
[Newtonsoft.Json.JsonProperty("lat")]//) private String lat;
		private string lat;


		/// <summary>
		/// 社区
		/// </summary>
[Newtonsoft.Json.JsonProperty("community")]//) private String community;
		private string community;


		/// <summary>
		/// 默认地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_default")]//) private Nullable<long> isDefault;
		private long? isDefault;


		/// <summary>
		/// 地址详情
		/// </summary>
[Newtonsoft.Json.JsonProperty("address_detail")]//) private String addressDetail;
		private string addressDetail;


		/// <summary>
		/// 省份
		/// </summary>
[Newtonsoft.Json.JsonProperty("province")]//) private String province;
		private string province;


		/// <summary>
		/// 帐号id
		/// </summary>
[Newtonsoft.Json.JsonProperty("user_id")]//) private Nullable<long> userId;
		private long? userId;


		/// <summary>
		/// 联系人电话
		/// </summary>
[Newtonsoft.Json.JsonProperty("tel")]//) private String tel;
		private string tel;


		/// <summary>
		/// 地址id
		/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
		private long? id;


		/// <summary>
		/// 邮政编码
		/// </summary>
[Newtonsoft.Json.JsonProperty("postal_code")]//) private String postalCode;
		private string postalCode;

		public virtual string Country
		{
			set
			{
				this.country = value;
			}
			get
			{
				return this.country;
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

		public virtual string UserName
		{
			set
			{
				this.userName = value;
			}
			get
			{
				return this.userName;
			}
		}

		public virtual string AreaCode
		{
			set
			{
				this.areaCode = value;
			}
			get
			{
				return this.areaCode;
			}
		}

		public virtual string County
		{
			set
			{
				this.county = value;
			}
			get
			{
				return this.county;
			}
		}

		public virtual string Lon
		{
			set
			{
				this.lon = value;
			}
			get
			{
				return this.lon;
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

		public virtual string Community
		{
			set
			{
				this.community = value;
			}
			get
			{
				return this.community;
			}
		}

		public virtual long? IsDefault
		{
			set
			{
				this.isDefault = value;
			}
			get
			{
				return this.isDefault;
			}
		}

		public virtual string AddressDetail
		{
			set
			{
				this.addressDetail = value;
			}
			get
			{
				return this.addressDetail;
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

		public virtual long? UserId
		{
			set
			{
				this.userId = value;
			}
			get
			{
				return this.userId;
			}
		}

		public virtual string Tel
		{
			set
			{
				this.tel = value;
			}
			get
			{
				return this.tel;
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

		public virtual string PostalCode
		{
			set
			{
				this.postalCode = value;
			}
			get
			{
				return this.postalCode;
			}
		}



	}
}