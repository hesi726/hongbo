using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanShopAddressListResult : APIResult
	{



		/// <summary>
		/// 地址总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<long> total;
		private long? total;


		/// <summary>
		/// 地址列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("list")]//) private ShopAddress[] list;
		private ShopAddress[] list;

		public virtual long? Total
		{
			set
			{
				this.total = value;
			}
			get
			{
				return this.total;
			}
		}

		public virtual ShopAddress[] List
		{
			set
			{
				this.list = value;
			}
			get
			{
				return this.list;
			}
		}


		public class ShopAddress
		{


			/// <summary>
			/// 地区id
			/// </summary>
[Newtonsoft.Json.JsonProperty("region_id")]//) private Nullable<long> regionId;
				internal long? regionId;


			/// <summary>
			/// 省市区
			/// </summary>
[Newtonsoft.Json.JsonProperty("area")]//) private String area;
				internal string area;


			/// <summary>
			/// 联系手机
			/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
				internal string mobile;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private java.util.Date createdAt;
				internal DateTime createdAt;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated_at")]//) private java.util.Date updatedAt;
				internal DateTime updatedAt;


			/// <summary>
			/// 是否是默认地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_default")]//) private Nullable<long> isDefault;
				internal long? isDefault;


			/// <summary>
			/// 手机区号
			/// </summary>
[Newtonsoft.Json.JsonProperty("country_code")]//) private String countryCode;
				internal string countryCode;


			/// <summary>
			/// 详细地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("address")]//) private String address;
				internal string address;


			/// <summary>
			/// 地区类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("region_type")]//) private String regionType;
				internal string regionType;


			/// <summary>
			/// 联系人
			/// </summary>
[Newtonsoft.Json.JsonProperty("contact_name")]//) private String contactName;
				internal string contactName;


			/// <summary>
			/// 地址id
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;

				public virtual long? RegionId
				{
					set
					{
					this.regionId = value;
					}
					get
					{
					return this.regionId;
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


				public virtual DateTime CreatedAt
				{
					set
					{
					this.createdAt = value;
					}
					get
					{
					return this.createdAt;
					}
				}


				public virtual DateTime UpdatedAt
				{
					set
					{
					this.updatedAt = value;
					}
					get
					{
					return this.updatedAt;
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


				public virtual string CountryCode
				{
					set
					{
					this.countryCode = value;
					}
					get
					{
					return this.countryCode;
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


				public virtual string RegionType
				{
					set
					{
					this.regionType = value;
					}
					get
					{
					return this.regionType;
					}
				}


				public virtual string ContactName
				{
					set
					{
					this.contactName = value;
					}
					get
					{
					return this.contactName;
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


		}


	}
}