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

    public class YouzanPaySinglePayParams : APIParams, FileParams
	{

		/// <summary>
		/// 支付宝是否安装，使用支付宝支付时填入
		/// </summary>
		private bool? alipayInstalled;
		/// <summary>
		/// 条码对应的数字：微信支付扫码、支付宝扫码 必传。
		/// </summary>
		private string authCode;
		/// <summary>
		/// 币种，如人民币:CNY
		/// </summary>
		private string currencyCode;
		/// <summary>
		/// 参与折扣金额，单位:分
		/// </summary>
		private long? discountableAmount;
		/// <summary>
		/// 商品描述信息
		/// </summary>
		private string goodsDesc;
		/// <summary>
		/// 商户号
		/// </summary>
		private string mchId;
		/// <summary>
		/// 支付备注
		/// </summary>
		private string memo;
		/// <summary>
		/// 支付结果异步通知链接，需要接收有赞支付结果的就必填
		/// </summary>
		private string notifyUrl;
		/// <summary>
		/// 业务订单号，必须唯一，长度<=32位
		/// </summary>
		private string outBizNo;
		/// <summary>
		/// 服务商商户号，对于个人开发者填个人开发者对应的商户号。
		/// </summary>
		private string partnerId;
		/// <summary>
		/// 支付金额，单位:分
		/// </summary>
		private long? payAmount;
		/// <summary>
		/// 支付渠道，包含：WX_JS:微信公众号支付
		/// ALIPAY_WAP:支付宝WAP支付
		/// WX_BARCODE:微信条码支付
		/// ALIPAY_BARCODE:支付宝条码支付
		/// </summary>
		private string payTool;
		/// <summary>
		/// 付款方ID
		/// </summary>
		private string payerId;
		/// <summary>
		/// 付款方昵称
		/// </summary>
		private string payerNickName;
		/// <summary>
		/// 支付成功后，前端页面跳转链接，微信公众号支付和支付宝WAP支付必填
		/// </summary>
		private string returnUrl;
		/// <summary>
		/// 本次交易的描述
		/// </summary>
		private string tradeDesc;
		/// <summary>
		/// 不参与折扣金额，单位:分
		/// </summary>
		private long? undiscountableAmount;
		/// <summary>
		/// 有赞授权码，通过访问  https://h5.koudaitong.com/v2/common/YzAuth/get.html?redirect_url=http://www.xxx.com/receive 拿到
		/// </summary>
		private string yzAuthToken;

		public virtual bool? AlipayInstalled
		{
			set
			{
				this.alipayInstalled = value;
			}
			get
			{
				return this.alipayInstalled;
			}
		}


		public virtual string AuthCode
		{
			set
			{
				this.authCode = value;
			}
			get
			{
				return this.authCode;
			}
		}


		public virtual string CurrencyCode
		{
			set
			{
				this.currencyCode = value;
			}
			get
			{
				return this.currencyCode;
			}
		}


		public virtual long? DiscountableAmount
		{
			set
			{
				this.discountableAmount = value;
			}
			get
			{
				return this.discountableAmount;
			}
		}


		public virtual string GoodsDesc
		{
			set
			{
				this.goodsDesc = value;
			}
			get
			{
				return this.goodsDesc;
			}
		}


		public virtual string MchId
		{
			set
			{
				this.mchId = value;
			}
			get
			{
				return this.mchId;
			}
		}


		public virtual string Memo
		{
			set
			{
				this.memo = value;
			}
			get
			{
				return this.memo;
			}
		}


		public virtual string NotifyUrl
		{
			set
			{
				this.notifyUrl = value;
			}
			get
			{
				return this.notifyUrl;
			}
		}


		public virtual string OutBizNo
		{
			set
			{
				this.outBizNo = value;
			}
			get
			{
				return this.outBizNo;
			}
		}


		public virtual string PartnerId
		{
			set
			{
				this.partnerId = value;
			}
			get
			{
				return this.partnerId;
			}
		}


		public virtual long? PayAmount
		{
			set
			{
				this.payAmount = value;
			}
			get
			{
				return this.payAmount;
			}
		}


		public virtual string PayTool
		{
			set
			{
				this.payTool = value;
			}
			get
			{
				return this.payTool;
			}
		}


		public virtual string PayerId
		{
			set
			{
				this.payerId = value;
			}
			get
			{
				return this.payerId;
			}
		}


		public virtual string PayerNickName
		{
			set
			{
				this.payerNickName = value;
			}
			get
			{
				return this.payerNickName;
			}
		}


		public virtual string ReturnUrl
		{
			set
			{
				this.returnUrl = value;
			}
			get
			{
				return this.returnUrl;
			}
		}


		public virtual string TradeDesc
		{
			set
			{
				this.tradeDesc = value;
			}
			get
			{
				return this.tradeDesc;
			}
		}


		public virtual long? UndiscountableAmount
		{
			set
			{
				this.undiscountableAmount = value;
			}
			get
			{
				return this.undiscountableAmount;
			}
		}


		public virtual string YzAuthToken
		{
			set
			{
				this.yzAuthToken = value;
			}
			get
			{
				return this.yzAuthToken;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (alipayInstalled != null)
			{
				@params["alipay_installed"] = alipayInstalled;
			}
			if (!string.ReferenceEquals(authCode, null))
			{
				@params["auth_code"] = authCode;
			}
			if (!string.ReferenceEquals(currencyCode, null))
			{
				@params["currency_code"] = currencyCode;
			}
			if (discountableAmount != null)
			{
				@params["discountable_amount"] = discountableAmount;
			}
			if (!string.ReferenceEquals(goodsDesc, null))
			{
				@params["goods_desc"] = goodsDesc;
			}
			if (!string.ReferenceEquals(mchId, null))
			{
				@params["mch_id"] = mchId;
			}
			if (!string.ReferenceEquals(memo, null))
			{
				@params["memo"] = memo;
			}
			if (!string.ReferenceEquals(notifyUrl, null))
			{
				@params["notify_url"] = notifyUrl;
			}
			if (!string.ReferenceEquals(outBizNo, null))
			{
				@params["out_biz_no"] = outBizNo;
			}
			if (!string.ReferenceEquals(partnerId, null))
			{
				@params["partner_id"] = partnerId;
			}
			if (payAmount != null)
			{
				@params["pay_amount"] = payAmount;
			}
			if (!string.ReferenceEquals(payTool, null))
			{
				@params["pay_tool"] = payTool;
			}
			if (!string.ReferenceEquals(payerId, null))
			{
				@params["payer_id"] = payerId;
			}
			if (!string.ReferenceEquals(payerNickName, null))
			{
				@params["payer_nick_name"] = payerNickName;
			}
			if (!string.ReferenceEquals(returnUrl, null))
			{
				@params["return_url"] = returnUrl;
			}
			if (!string.ReferenceEquals(tradeDesc, null))
			{
				@params["trade_desc"] = tradeDesc;
			}
			if (undiscountableAmount != null)
			{
				@params["undiscountable_amount"] = undiscountableAmount;
			}
			if (!string.ReferenceEquals(yzAuthToken, null))
			{
				@params["yz_auth_token"] = yzAuthToken;
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