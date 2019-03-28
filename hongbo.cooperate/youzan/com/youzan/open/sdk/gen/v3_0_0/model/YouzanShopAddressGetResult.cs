namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanShopAddressGetResult : APIResult
	{



		/// <summary>
		/// 地址id
		/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
		private long? id;


		/// <summary>
		/// 联系人
		/// </summary>
[Newtonsoft.Json.JsonProperty("contact_name")]//) private String contactName;
		private string contactName;


		/// <summary>
		/// 联系手机号
		/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
		private string mobile;


		/// <summary>
		/// 地区类型
		/// </summary>
[Newtonsoft.Json.JsonProperty("region_type")]//) private String regionType;
		private string regionType;


		/// <summary>
		/// 地区id
		/// </summary>
[Newtonsoft.Json.JsonProperty("region_id")]//) private Nullable<long> regionId;
		private long? regionId;


		/// <summary>
		/// 省市区
		/// </summary>
[Newtonsoft.Json.JsonProperty("area")]//) private String area;
		private string area;


		/// <summary>
		/// 详细地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("address")]//) private String address;
		private string address;


		/// <summary>
		/// 是否是退货地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_return")]//) private Nullable<long> isReturn;
		private long? isReturn;


		/// <summary>
		/// 是否是发票地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_invoice")]//) private Nullable<long> isInvoice;
		private long? isInvoice;


		/// <summary>
		/// 是否是默认退货地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_return_default")]//) private Nullable<long> isReturnDefault;
		private long? isReturnDefault;


		/// <summary>
		/// 是否是默认发票地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_invoice_default")]//) private Nullable<long> isInvoiceDefault;
		private long? isInvoiceDefault;


		/// <summary>
		/// 手机区号
		/// </summary>
[Newtonsoft.Json.JsonProperty("country_code")]//) private String countryCode;
		private string countryCode;


		/// <summary>
		/// 创建时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private String createdAt;
		private string createdAt;


		/// <summary>
		/// 更新时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("updated_at")]//) private String updatedAt;
		private string updatedAt;

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

		public virtual string CreatedAt
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

		public virtual string UpdatedAt
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



	}
}