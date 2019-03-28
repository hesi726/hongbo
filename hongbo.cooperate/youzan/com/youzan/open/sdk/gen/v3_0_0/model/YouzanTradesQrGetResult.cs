using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradesQrGetResult : APIResult
	{



		/// <summary>
		/// 搜索到的交易列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("qr_trades")]//) private TradePayQrcode[] qrTrades;
		private TradePayQrcode[] qrTrades;


		/// <summary>
		/// 搜索到的交易总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total_results")]//) private Nullable<long> totalResults;
		private long? totalResults;

		public virtual TradePayQrcode[] QrTrades
		{
			set
			{
				this.qrTrades = value;
			}
			get
			{
				return this.qrTrades;
			}
		}

		public virtual long? TotalResults
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


		public class TradePayQrcode
		{


			/// <summary>
			/// 交易状态。取值范围：<br>WAIT_RECEIVED（待收款）<br>TRADE_RECEIVED（已收款）<br>TRADE_EXPIRED（已过期，即：48小时内未付款）
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private String status;
				internal string status;


			/// <summary>
			/// 支付类型。取值范围：<br>WXPAY (微信支付)<br>ALIWAP (支付宝付款)<br>ALIPAY (支付宝pc付款)<br>UNIONPAY (银行卡付款)<br>TENPAY (财付通付款)<br>UNIONWAP (银行卡付款)<br>PEERPAY (找人代付)<br>UMPAY (信用卡付款)<br>CODPAY (货到付款)<br>WXPAY_BIGUNSIGN (微信支付)<br>WXPAY_BIGSIGN (微信支付)<br>BAIDUWAP (储蓄卡付款)<br>WXAPPPAY (微信支付)<br>MERGED_PAY (分销采购单合并付款)<br>PRESENT
			/// </summary>
[Newtonsoft.Json.JsonProperty("pay_type")]//) private String payType;
				internal string payType;


			/// <summary>
			/// 收款理由
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_name")]//) private String qrName;
				internal string qrName;


			/// <summary>
			/// 收款金额。精确到2位小数；单位：元。
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_price")]//) private Nullable<float> qrPrice;
				internal float? qrPrice;


			/// <summary>
			/// 外部交易编号。比如，如果支付方式是微信支付，就是财付通的交易单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("outer_tid")]//) private String outerTid;
				internal string outerTid;


			/// <summary>
			/// 交易创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_date")]//) private java.util.Date createdDate;
				internal DateTime createdDate;


			/// <summary>
			/// 付款者昵称
			/// </summary>
[Newtonsoft.Json.JsonProperty("payer_nick")]//) private String payerNick;
				internal string payerNick;


			/// <summary>
			/// 实际收款金额。精确到2位小数；单位：元。
			/// </summary>
[Newtonsoft.Json.JsonProperty("real_price")]//) private Nullable<float> realPrice;
				internal float? realPrice;


			/// <summary>
			/// 支付时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("pay_date")]//) private java.util.Date payDate;
				internal DateTime payDate;


			/// <summary>
			/// 二维码编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_id")]//) private String qrId;
				internal string qrId;


			/// <summary>
			/// 预定时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("book_date")]//) private java.util.Date bookDate;
				internal DateTime bookDate;


			/// <summary>
			/// 交易编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("tid")]//) private String tid;
				internal string tid;


			/// <summary>
			/// 可以访问的支付页URL
			/// </summary>
[Newtonsoft.Json.JsonProperty("qr_url")]//) private String qrUrl;
				internal string qrUrl;

				public virtual string Status
				{
					set
					{
					this.status = value;
					}
					get
					{
					return this.status;
					}
				}


				public virtual string PayType
				{
					set
					{
					this.payType = value;
					}
					get
					{
					return this.payType;
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


				public virtual string OuterTid
				{
					set
					{
					this.outerTid = value;
					}
					get
					{
					return this.outerTid;
					}
				}


				public virtual DateTime CreatedDate
				{
					set
					{
					this.createdDate = value;
					}
					get
					{
					return this.createdDate;
					}
				}


				public virtual string PayerNick
				{
					set
					{
					this.payerNick = value;
					}
					get
					{
					return this.payerNick;
					}
				}


				public virtual float? RealPrice
				{
					set
					{
					this.realPrice = value;
					}
					get
					{
					return this.realPrice;
					}
				}


				public virtual DateTime PayDate
				{
					set
					{
					this.payDate = value;
					}
					get
					{
					return this.payDate;
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


				public virtual DateTime BookDate
				{
					set
					{
					this.bookDate = value;
					}
					get
					{
					return this.bookDate;
					}
				}


				public virtual string Tid
				{
					set
					{
					this.tid = value;
					}
					get
					{
					return this.tid;
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
}