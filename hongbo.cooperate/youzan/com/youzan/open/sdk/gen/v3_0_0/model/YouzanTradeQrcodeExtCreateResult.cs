namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeQrcodeExtCreateResult : APIResult
	{



		/// <summary>
		/// 二维码id
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_id")]//) private Nullable<long> qrId;
		private long? qrId;


		/// <summary>
		/// 二维码名称
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_name")]//) private String qrName;
		private string qrName;


		/// <summary>
		/// 二维码金额(单位/分)
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_price")]//) private Nullable<long> qrPrice;
		private long? qrPrice;


		/// <summary>
		/// 二维码图片data
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_code")]//) private String qrCode;
		private string qrCode;


		/// <summary>
		/// 扫码连接
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_url")]//) private String qrUrl;
		private string qrUrl;

		public virtual long? QrId
		{
			set
			{
				this.qrId = value;
			}
			get
			{
				return this.qrId;
			}
		}

		public virtual string QrName
		{
			set
			{
				this.qrName = value;
			}
			get
			{
				return this.qrName;
			}
		}

		public virtual long? QrPrice
		{
			set
			{
				this.qrPrice = value;
			}
			get
			{
				return this.qrPrice;
			}
		}

		public virtual string QrCode
		{
			set
			{
				this.qrCode = value;
			}
			get
			{
				return this.qrCode;
			}
		}

		public virtual string QrUrl
		{
			set
			{
				this.qrUrl = value;
			}
			get
			{
				return this.qrUrl;
			}
		}



	}
}