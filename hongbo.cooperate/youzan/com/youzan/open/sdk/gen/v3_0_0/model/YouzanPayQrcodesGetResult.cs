namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanPayQrcodesGetResult : APIResult
	{



		/// <summary>
		/// 搜索到符合条件的结果总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total_results")]//) private QrTotalResult totalResults;
		private QrTotalResult totalResults;


		/// <summary>
		/// 二维码生成记录,包含is_discount(是否有折扣)、activityInfo(折扣详情)，如果没有折扣则is_discount、activityInfo两个字段不返回
		/// </summary>
[Newtonsoft.Json.JsonProperty("qrcodes")]//) private TradeCashierQrcode[] qrcodes;
		private TradeCashierQrcode[] qrcodes;

		public virtual QrTotalResult TotalResults
		{
			set
			{
				this.totalResults = value;
			}
			get
			{
				return this.totalResults;
			}
		}

		public virtual TradeCashierQrcode[] Qrcodes
		{
			set
			{
				this.qrcodes = value;
			}
			get
			{
				return this.qrcodes;
			}
		}


		public class TradeCashierQrcode
		{


			/// <summary>
			/// 收款名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_name")]//) private String qrName;
				internal string qrName;


			/// <summary>
			/// 收款金额。精确到2位小数；单位：元。
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_price")]//) private Nullable<float> qrPrice;
				internal float? qrPrice;


			/// <summary>
			/// 收款码编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_code")]//) private String qrCode;
				internal string qrCode;


			/// <summary>
			/// 收款码当前关联优惠信息。
			/// </summary>
[Newtonsoft.Json.JsonProperty("activityInfo")]//) private String activityInfo;
				internal string activityInfo;


			/// <summary>
			/// 收款码创建类型标记。<br>类型有：<br>INSIDE（内部创建）<br>OUTSIDE（外部创建）
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_source")]//) private String qrSource;
				internal string qrSource;


			/// <summary>
			/// 收款码类型。<br>类型有：<br>QR_TYPE_FIXED（收款码和店铺绑定并且可多次支付）<br>QR_TYPE_NOLIMIT（收款码可多次支付）<br>QR_TYPE_DYNAMIC（收款码只能被支付一次）
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_type")]//) private String qrType;
				internal string qrType;


			/// <summary>
			/// 收款码编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_id")]//) private String qrId;
				internal string qrId;


			/// <summary>
			/// 可以访问的支付页URL
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_url")]//) private String qrUrl;
				internal string qrUrl;


			/// <summary>
			/// 收款码创建日期
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_created_time")]//) private String qrCreatedTime;
				internal string qrCreatedTime;

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


				public virtual float? QrPrice
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


				public virtual string ActivityInfo
				{
					set
					{
					this.activityInfo = value;
					}
					get
					{
					return this.activityInfo;
					}
				}


				public virtual string QrSource
				{
					set
					{
					this.qrSource = value;
					}
					get
					{
					return this.qrSource;
					}
				}


				public virtual string QrType
				{
					set
					{
					this.qrType = value;
					}
					get
					{
					return this.qrType;
					}
				}


				public virtual string QrId
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


				public virtual string QrCreatedTime
				{
					set
					{
					this.qrCreatedTime = value;
					}
					get
					{
					return this.qrCreatedTime;
					}
				}


		}

		public class QrTotalResult
		{


			/// <summary>
			/// 结果总数
			/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<int> total;
				internal int? total;

				public virtual int? Total
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


		}


	}
}