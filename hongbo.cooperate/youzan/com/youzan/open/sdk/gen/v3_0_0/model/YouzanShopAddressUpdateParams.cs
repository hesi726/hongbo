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

    public class YouzanShopAddressUpdateParams : APIParams, FileParams
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
		/// 市
		/// </summary>
		private string city;
		/// <summary>
		/// 联系人
		/// </summary>
		private string contactName;
		/// <summary>
		/// 地址id
		/// </summary>
		private long? id;
		/// <summary>
		/// 是否发票地址
		/// </summary>
		private long? isInvoice;
		/// <summary>
		/// 是否默认发票地址
		/// </summary>
		private long? isInvoiceDefault;
		/// <summary>
		/// 是否退货地址
		/// </summary>
		private long? isReturn;
		/// <summary>
		/// 是否默认退货地址
		/// </summary>
		private long? isReturnDefault;
		/// <summary>
		/// 手机号
		/// </summary>
		private string mobile;
		/// <summary>
		/// 省
		/// </summary>
		private string province;
		/// <summary>
		/// 地区id
		/// </summary>
		private long? regionId;

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


		public virtual long? IsInvoice
		{
			set
			{
				this.isInvoice = value;
			}
			get
			{
				return this.isInvoice;
			}
		}


		public virtual long? IsInvoiceDefault
		{
			set
			{
				this.isInvoiceDefault = value;
			}
			get
			{
				return this.isInvoiceDefault;
			}
		}


		public virtual long? IsReturn
		{
			set
			{
				this.isReturn = value;
			}
			get
			{
				return this.isReturn;
			}
		}


		public virtual long? IsReturnDefault
		{
			set
			{
				this.isReturnDefault = value;
			}
			get
			{
				return this.isReturnDefault;
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
			if (!string.ReferenceEquals(city, null))
			{
				@params["city"] = city;
			}
			if (!string.ReferenceEquals(contactName, null))
			{
				@params["contact_name"] = contactName;
			}
			if (id != null)
			{
				@params["id"] = id;
			}
			if (isInvoice != null)
			{
				@params["is_invoice"] = isInvoice;
			}
			if (isInvoiceDefault != null)
			{
				@params["is_invoice_default"] = isInvoiceDefault;
			}
			if (isReturn != null)
			{
				@params["is_return"] = isReturn;
			}
			if (isReturnDefault != null)
			{
				@params["is_return_default"] = isReturnDefault;
			}
			if (!string.ReferenceEquals(mobile, null))
			{
				@params["mobile"] = mobile;
			}
			if (!string.ReferenceEquals(province, null))
			{
				@params["province"] = province;
			}
			if (regionId != null)
			{
				@params["region_id"] = regionId;
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