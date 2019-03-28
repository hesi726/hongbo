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

    public class YouzanMultistoreOfflineCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 详细地址
		/// </summary>
		private string address;
		/// <summary>
		/// 区
		/// </summary>
		private string area;
		/// <summary>
		/// 营业时间,按天设置。示例[{"open_time":"00:10","close_time":"16:00","weekdays":["周一","周二","周三","周四","周五"]},{"open_time":"00:10","close_time":"20:00","weekdays":["周六","周日"]}]
		/// </summary>
		private string businessHoursAdvanced;
		/// <summary>
		/// 市
		/// </summary>
		private string city;
		/// <summary>
		/// 行政区划代码。参考高德城市编码表 http://lbs.amap.com/api/webservice/download
		/// </summary>
		private string countyId;
		/// <summary>
		/// 描述
		/// </summary>
		private string description;
		/// <summary>
		/// 图片地址，逗号分隔
		/// </summary>
		private string image;
		/// <summary>
		/// 是否需要买家选择自提时间。1表示需要，0表示不需要
		/// </summary>
		private long? isOptionalSelfFetchTime;
		/// <summary>
		/// 是否是自提点。1表示是，0表示否
		/// </summary>
		private long? isSelfFetch;
		/// <summary>
		/// 是否是门店。1表示是，0表示否
		/// </summary>
		private long? isStore;
		/// <summary>
		/// 纬度（百度坐标系）
		/// </summary>
		private string lat;
		/// <summary>
		/// 经度（百度坐标系）
		/// </summary>
		private string lng;
		/// <summary>
		/// 同城配送范围多边形,只有当local_delivery_scope_type=2时生效。格式如：点1经度,点1纬度|点2经度,点2纬度|点3经度，点3纬度|点4经度，点4纬度...（百度坐标系）
		/// </summary>
		private string localDeliveryPolygon;
		/// <summary>
		/// 配送范围。单位米
		/// </summary>
		private string localDeliveryScope;
		/// <summary>
		/// 同城配送范围划分方式：1半径 2多边形
		/// </summary>
		private long? localDeliveryScopeType;
		/// <summary>
		/// 起送金额。单位分
		/// </summary>
		private string localDeliveryStartAmount;
		/// <summary>
		/// 网点名称
		/// </summary>
		private string name;
		/// <summary>
		/// 线下自提时间。格式同business_hours_advanced
		/// </summary>
		private string offlineBusinessHours;
		/// <summary>
		/// 区号
		/// </summary>
		private string phone1;
		/// <summary>
		/// 电话或者手机号
		/// </summary>
		private string phone2;
		/// <summary>
		/// 省
		/// </summary>
		private string province;
		/// <summary>
		/// 是否支持本地配送。1表示支持，0表示不支持
		/// </summary>
		private long? supportLocalDelivery;
		/// <summary>
		/// 标签id列表，逗号分隔。需要先创建网点分组
		/// </summary>
		private string tagIds;

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


		public virtual string Image
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


		public virtual long? IsOptionalSelfFetchTime
		{
			set
			{
				this.isOptionalSelfFetchTime = value;
			}
			get
			{
				return this.isOptionalSelfFetchTime;
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


		public virtual string LocalDeliveryPolygon
		{
			set
			{
				this.localDeliveryPolygon = value;
			}
			get
			{
				return this.localDeliveryPolygon;
			}
		}


		public virtual string LocalDeliveryScope
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


		public virtual long? LocalDeliveryScopeType
		{
			set
			{
				this.localDeliveryScopeType = value;
			}
			get
			{
				return this.localDeliveryScopeType;
			}
		}


		public virtual string LocalDeliveryStartAmount
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


		public virtual string OfflineBusinessHours
		{
			set
			{
				this.offlineBusinessHours = value;
			}
			get
			{
				return this.offlineBusinessHours;
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


		public virtual string TagIds
		{
			set
			{
				this.tagIds = value;
			}
			get
			{
				return this.tagIds;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(address, null))
			{
				@params["address"] = address;
			}
			if (!string.ReferenceEquals(area, null))
			{
				@params["area"] = area;
			}
			if (!string.ReferenceEquals(businessHoursAdvanced, null))
			{
				@params["business_hours_advanced"] = businessHoursAdvanced;
			}
			if (!string.ReferenceEquals(city, null))
			{
				@params["city"] = city;
			}
			if (!string.ReferenceEquals(countyId, null))
			{
				@params["county_id"] = countyId;
			}
			if (!string.ReferenceEquals(description, null))
			{
				@params["description"] = description;
			}
			if (!string.ReferenceEquals(image, null))
			{
				@params["image"] = image;
			}
			if (isOptionalSelfFetchTime != null)
			{
				@params["is_optional_self_fetch_time"] = isOptionalSelfFetchTime;
			}
			if (isSelfFetch != null)
			{
				@params["is_self_fetch"] = isSelfFetch;
			}
			if (isStore != null)
			{
				@params["is_store"] = isStore;
			}
			if (!string.ReferenceEquals(lat, null))
			{
				@params["lat"] = lat;
			}
			if (!string.ReferenceEquals(lng, null))
			{
				@params["lng"] = lng;
			}
			if (!string.ReferenceEquals(localDeliveryPolygon, null))
			{
				@params["local_delivery_polygon"] = localDeliveryPolygon;
			}
			if (!string.ReferenceEquals(localDeliveryScope, null))
			{
				@params["local_delivery_scope"] = localDeliveryScope;
			}
			if (localDeliveryScopeType != null)
			{
				@params["local_delivery_scope_type"] = localDeliveryScopeType;
			}
			if (!string.ReferenceEquals(localDeliveryStartAmount, null))
			{
				@params["local_delivery_start_amount"] = localDeliveryStartAmount;
			}
			if (!string.ReferenceEquals(name, null))
			{
				@params["name"] = name;
			}
			if (!string.ReferenceEquals(offlineBusinessHours, null))
			{
				@params["offline_business_hours"] = offlineBusinessHours;
			}
			if (!string.ReferenceEquals(phone1, null))
			{
				@params["phone1"] = phone1;
			}
			if (!string.ReferenceEquals(phone2, null))
			{
				@params["phone2"] = phone2;
			}
			if (!string.ReferenceEquals(province, null))
			{
				@params["province"] = province;
			}
			if (supportLocalDelivery != null)
			{
				@params["support_local_delivery"] = supportLocalDelivery;
			}
			if (!string.ReferenceEquals(tagIds, null))
			{
				@params["tag_ids"] = tagIds;
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