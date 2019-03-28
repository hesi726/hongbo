namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanShopStatusGetResult : APIResult
	{



		/// <summary>
		/// 店铺状态信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private AccountShopStatus status;
		private AccountShopStatus status;

		public virtual AccountShopStatus Status
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


		public class AccountShopStatus
		{


			/// <summary>
			/// 是否绑定了微信
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_bind_weixin")]//) private Nullable<bool> isBindWeixin;
				internal bool? isBindWeixin;


			/// <summary>
			/// 是否是微信认证服务号
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_weixin_service")]//) private Nullable<bool> isWeixinService;
				internal bool? isWeixinService;


			/// <summary>
			/// 是否是微信未认证服务号
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_weixin_unauthorized_service")]//) private Nullable<bool> isWeixinUnauthorizedService;
				internal bool? isWeixinUnauthorizedService;


			/// <summary>
			/// 是否是微信认证订阅号
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_weixin_publisher")]//) private Nullable<bool> isWeixinPublisher;
				internal bool? isWeixinPublisher;


			/// <summary>
			/// 是否是微信未认证订阅号
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_weixin_unauthorized_publisher")]//) private Nullable<bool> isWeixinUnauthorizedPublisher;
				internal bool? isWeixinUnauthorizedPublisher;


			/// <summary>
			/// 是否是担保交易
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_secured_transactions")]//) private Nullable<bool> isSecuredTransactions;
				internal bool? isSecuredTransactions;


			/// <summary>
			/// 是否设置购物车
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_set_shopping_cart")]//) private Nullable<bool> isSetShoppingCart;
				internal bool? isSetShoppingCart;


			/// <summary>
			/// 是否设置购买记录
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_set_buy_record")]//) private Nullable<bool> isSetBuyRecord;
				internal bool? isSetBuyRecord;


			/// <summary>
			/// 是否设置商品评价
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_set_customer_reviews")]//) private Nullable<bool> isSetCustomerReviews;
				internal bool? isSetCustomerReviews;


			/// <summary>
			/// 是否设置仅粉丝购买
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_set_fans_only")]//) private Nullable<bool> isSetFansOnly;
				internal bool? isSetFansOnly;

				public virtual bool? IsBindWeixin
				{
					set
					{
					this.isBindWeixin = value;
					}
					get
					{
					return this.isBindWeixin;
					}
				}


				public virtual bool? IsWeixinService
				{
					set
					{
					this.isWeixinService = value;
					}
					get
					{
					return this.isWeixinService;
					}
				}


				public virtual bool? IsWeixinUnauthorizedService
				{
					set
					{
					this.isWeixinUnauthorizedService = value;
					}
					get
					{
					return this.isWeixinUnauthorizedService;
					}
				}


				public virtual bool? IsWeixinPublisher
				{
					set
					{
					this.isWeixinPublisher = value;
					}
					get
					{
					return this.isWeixinPublisher;
					}
				}


				public virtual bool? IsWeixinUnauthorizedPublisher
				{
					set
					{
					this.isWeixinUnauthorizedPublisher = value;
					}
					get
					{
					return this.isWeixinUnauthorizedPublisher;
					}
				}


				public virtual bool? IsSecuredTransactions
				{
					set
					{
					this.isSecuredTransactions = value;
					}
					get
					{
					return this.isSecuredTransactions;
					}
				}


				public virtual bool? IsSetShoppingCart
				{
					set
					{
					this.isSetShoppingCart = value;
					}
					get
					{
					return this.isSetShoppingCart;
					}
				}


				public virtual bool? IsSetBuyRecord
				{
					set
					{
					this.isSetBuyRecord = value;
					}
					get
					{
					return this.isSetBuyRecord;
					}
				}


				public virtual bool? IsSetCustomerReviews
				{
					set
					{
					this.isSetCustomerReviews = value;
					}
					get
					{
					return this.isSetCustomerReviews;
					}
				}


				public virtual bool? IsSetFansOnly
				{
					set
					{
					this.isSetFansOnly = value;
					}
					get
					{
					return this.isSetFansOnly;
					}
				}


		}


	}
}