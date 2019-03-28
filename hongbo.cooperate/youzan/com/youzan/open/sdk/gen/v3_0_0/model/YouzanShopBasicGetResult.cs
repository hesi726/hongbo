namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanShopBasicGetResult : APIResult
	{



		/// <summary>
		/// 店铺ID
		/// </summary>
[Newtonsoft.Json.JsonProperty("sid")]//) private Nullable<long> sid;
		private long? sid;


		/// <summary>
		/// 店铺名称
		/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
		private string name;


		/// <summary>
		/// 店铺LOGO
		/// </summary>
[Newtonsoft.Json.JsonProperty("logo")]//) private String logo;
		private string logo;


		/// <summary>
		/// 店铺地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("url")]//) private String url;
		private string url;


		/// <summary>
		/// 门店地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("physical_url")]//) private String physicalUrl;
		private string physicalUrl;


		/// <summary>
		/// 认证类型（0 未认证 2 企业认证 3/4 个人认证 6/7/8/9 官方认证）
		/// </summary>
[Newtonsoft.Json.JsonProperty("cert_type")]//) private Nullable<long> certType;
		private long? certType;

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

		public virtual string Logo
		{
			set
			{
				this.logo = value;
			}
			get
			{
				return this.logo;
			}
		}

		public virtual string Url
		{
			set
			{
				this.url = value;
			}
			get
			{
				return this.url;
			}
		}

		public virtual string PhysicalUrl
		{
			set
			{
				this.physicalUrl = value;
			}
			get
			{
				return this.physicalUrl;
			}
		}

		public virtual long? CertType
		{
			set
			{
				this.certType = value;
			}
			get
			{
				return this.certType;
			}
		}



	}
}