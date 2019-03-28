using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMultistoreOfflineSearchResult : APIResult
	{



		/// <summary>
		/// 网点信息列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("list")]//) private AccountShopOffline[] list;
		private AccountShopOffline[] list;


		/// <summary>
		/// 总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("count")]//) private Nullable<long> count;
		private long? count;

		public virtual AccountShopOffline[] List
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

		public virtual long? Count
		{
			set
			{
				this.count = value;
			}
			get
			{
				return this.count;
			}
		}


		public class AccountShopOffline
		{


			/// <summary>
			/// 网点图片
			/// </summary>
[Newtonsoft.Json.JsonProperty("image")]//) private Object image;
				internal object image;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_time")]//) private java.util.Date createdTime;
				internal DateTime createdTime;


			/// <summary>
			/// 邮编
			/// </summary>
[Newtonsoft.Json.JsonProperty("county_id")]//) private String countyId;
				internal string countyId;


			/// <summary>
			/// 营业时间,按天设置
			/// </summary>
[Newtonsoft.Json.JsonProperty("business_hours_advanced")]//) private Object businessHoursAdvanced;
				internal object businessHoursAdvanced;


			/// <summary>
			/// 经度
			/// </summary>
[Newtonsoft.Json.JsonProperty("lng")]//) private String lng;
				internal string lng;


			/// <summary>
			/// 网点编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 市
			/// </summary>
[Newtonsoft.Json.JsonProperty("city")]//) private String city;
				internal string city;


			/// <summary>
			/// 是否是门店
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_store")]//) private Nullable<long> isStore;
				internal long? isStore;


			/// <summary>
			/// 区
			/// </summary>
[Newtonsoft.Json.JsonProperty("area")]//) private String area;
				internal string area;


			/// <summary>
			/// 店铺编号（推荐使用sid）
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 是否是自提点
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_self_fetch")]//) private Nullable<long> isSelfFetch;
				internal long? isSelfFetch;


			/// <summary>
			/// 店铺编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("sid")]//) private Nullable<long> sid;
				internal long? sid;


			/// <summary>
			/// 网点索引图片
			/// </summary>
[Newtonsoft.Json.JsonProperty("image_thumb")]//) private Object imageThumb;
				internal object imageThumb;


			/// <summary>
			/// 省
			/// </summary>
[Newtonsoft.Json.JsonProperty("province")]//) private String province;
				internal string province;


			/// <summary>
			/// 描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("description")]//) private String description;
				internal string description;


			/// <summary>
			/// 电话号码
			/// </summary>
[Newtonsoft.Json.JsonProperty("phone2")]//) private String phone2;
				internal string phone2;


			/// <summary>
			/// 区号
			/// </summary>
[Newtonsoft.Json.JsonProperty("phone1")]//) private String phone1;
				internal string phone1;


			/// <summary>
			/// 地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("address")]//) private String address;
				internal string address;


			/// <summary>
			/// 纬度
			/// </summary>
[Newtonsoft.Json.JsonProperty("lat")]//) private String lat;
				internal string lat;


			/// <summary>
			/// 营业时间,不推荐使用
			/// </summary>
[Newtonsoft.Json.JsonProperty("business_hours")]//) private String businessHours;
				internal string businessHours;


			/// <summary>
			/// 网点名
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated_time")]//) private java.util.Date updatedTime;
				internal DateTime updatedTime;

				public virtual object Image
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


				public virtual DateTime CreatedTime
				{
					set
					{
					this.createdTime = value;
					}
					get
					{
					return this.createdTime;
					}
				}


				public virtual string CountyId
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


				public virtual object BusinessHoursAdvanced
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


				public virtual long? Sid
				{
					set
					{
					this.sid = value;
					}
					get
					{
					return this.sid;
					}
				}


				public virtual object ImageThumb
				{
					set
					{
					this.imageThumb = value;
					}
					get
					{
					return this.imageThumb;
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


				public virtual string BusinessHours
				{
					set
					{
					this.businessHours = value;
					}
					get
					{
					return this.businessHours;
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


				public virtual DateTime UpdatedTime
				{
					set
					{
					this.updatedTime = value;
					}
					get
					{
					return this.updatedTime;
					}
				}


		}


	}
}