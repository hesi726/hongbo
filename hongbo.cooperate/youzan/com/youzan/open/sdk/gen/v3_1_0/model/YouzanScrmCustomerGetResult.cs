namespace com.youzan.open.sdk.gen.v3_1_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;

    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCustomerGetResult : APIResult
	{



		/// <summary>
		/// 姓名
		/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
		private string name;


		/// <summary>
		/// 性别。0:未知；1:男；2:女
		/// </summary>
[Newtonsoft.Json.JsonProperty("gender")]//) private Nullable<long> gender;
		private long? gender;


		/// <summary>
		/// 生日
		/// </summary>
[Newtonsoft.Json.JsonProperty("birthday")]//) private String birthday;
		private string birthday;


		/// <summary>
		/// 手机号
		/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
		private string mobile;


		/// <summary>
		/// 是否为会员
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_member")]//) private Nullable<bool> isMember;
		private bool? isMember;


		/// <summary>
		/// 联系地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("contact_address")]//) private ContactAddress contactAddress;
		private ContactAddress contactAddress;

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

		public virtual long? Gender
		{
			set
			{
				this.gender = value;
			}
			get
			{
				return this.gender;
			}
		}

		public virtual string Birthday
		{
			set
			{
				this.birthday = value;
			}
			get
			{
				return this.birthday;
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

		public virtual bool? IsMember
		{
			set
			{
				this.isMember = value;
			}
			get
			{
				return this.isMember;
			}
		}

		public virtual void setContactAddress(ContactAddress contactAddress)
		{
			this.contactAddress = contactAddress;
		}

		public virtual ContactAddress getContactAddress()
		{
			return this.contactAddress;
		}

		public class ContactAddress
		{


			/// <summary>
			/// 地域编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("areaCode")]//) private Nullable<long> areaCode;
				internal long? areaCode;


			/// <summary>
			/// 省份
			/// </summary>
[Newtonsoft.Json.JsonProperty("province")]//) private String province;
				internal string province;


			/// <summary>
			/// 地级市
			/// </summary>
[Newtonsoft.Json.JsonProperty("city")]//) private String city;
				internal string city;


			/// <summary>
			/// 县级市、区
			/// </summary>
[Newtonsoft.Json.JsonProperty("county")]//) private String county;
				internal string county;


			/// <summary>
			/// 详细地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("address")]//) private String address;
				internal string address;

				public virtual long? AreaCode
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


		}


	}
}