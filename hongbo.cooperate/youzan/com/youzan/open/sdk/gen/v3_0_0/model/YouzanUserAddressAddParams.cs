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

    public class YouzanUserAddressAddParams : APIParams, FileParams
	{

		/// <summary>
		/// 详细地址
		/// </summary>
		private string addressDetail;
		/// <summary>
		/// 区号
		/// </summary>
		private string areaCode;
		/// <summary>
		/// 市
		/// </summary>
		private string city;
		/// <summary>
		/// 社区
		/// </summary>
		private string community;
		/// <summary>
		/// 县
		/// </summary>
		private string county;
		/// <summary>
		/// 纬度
		/// </summary>
		private string lat;
		/// <summary>
		/// 经度
		/// </summary>
		private string lon;
		/// <summary>
		/// 邮政编码
		/// </summary>
		private string postalCode;
		/// <summary>
		/// 省
		/// </summary>
		private string province;
		/// <summary>
		/// 手机号码
		/// </summary>
		private string tel;
		/// <summary>
		/// 用户名称
		/// </summary>
		private string userName;

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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(addressDetail, null))
			{
				@params["address_detail"] = addressDetail;
			}
			if (!string.ReferenceEquals(areaCode, null))
			{
				@params["area_code"] = areaCode;
			}
			if (!string.ReferenceEquals(city, null))
			{
				@params["city"] = city;
			}
			if (!string.ReferenceEquals(community, null))
			{
				@params["community"] = community;
			}
			if (!string.ReferenceEquals(county, null))
			{
				@params["county"] = county;
			}
			if (!string.ReferenceEquals(lat, null))
			{
				@params["lat"] = lat;
			}
			if (!string.ReferenceEquals(lon, null))
			{
				@params["lon"] = lon;
			}
			if (!string.ReferenceEquals(postalCode, null))
			{
				@params["postal_code"] = postalCode;
			}
			if (!string.ReferenceEquals(province, null))
			{
				@params["province"] = province;
			}
			if (!string.ReferenceEquals(tel, null))
			{
				@params["tel"] = tel;
			}
			if (!string.ReferenceEquals(userName, null))
			{
				@params["user_name"] = userName;
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