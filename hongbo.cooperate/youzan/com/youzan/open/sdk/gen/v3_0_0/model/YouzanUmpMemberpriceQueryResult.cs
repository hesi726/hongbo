namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpMemberpriceQueryResult : APIResult
	{



		/// <summary>
		/// 自定义会员价
		/// </summary>
[Newtonsoft.Json.JsonProperty("response")]//) private ItemMemberPrice[] response;
		private ItemMemberPrice[] response;

		public virtual ItemMemberPrice[] Response
		{
			set
			{
				this.response = value;
			}
			get
			{
				return this.response;
			}
		}


		public class SkuMemberPrice
		{


			/// <summary>
			/// skuId
			/// </summary>
[Newtonsoft.Json.JsonProperty("skuId")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// 原价，单位分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;


			/// <summary>
			/// 自定义会员价信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("cards")]//) private MemberPrice[] cards;
				internal MemberPrice[] cards;

				public virtual long? SkuId
				{
					set
					{
					this.skuId = value;
					}
					get
					{
					return this.skuId;
					}
				}


				public virtual long? Price
				{
					set
					{
					this.price = value;
					}
					get
					{
					return this.price;
					}
				}


				public virtual MemberPrice[] Cards
				{
					set
					{
					this.cards = value;
					}
					get
					{
					return this.cards;
					}
				}


		}

		public class ItemMemberPrice
		{


			/// <summary>
			/// 商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("itemId")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// sku自定义会员价信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("skus")]//) private SkuMemberPrice[] skus;
				internal SkuMemberPrice[] skus;

				public virtual long? ItemId
				{
					set
					{
					this.itemId = value;
					}
					get
					{
					return this.itemId;
					}
				}


				public virtual SkuMemberPrice[] Skus
				{
					set
					{
					this.skus = value;
					}
					get
					{
					return this.skus;
					}
				}


		}

		public class MemberPrice
		{


			/// <summary>
			/// 会员卡id
			/// </summary>
[Newtonsoft.Json.JsonProperty("cardId")]//) private Nullable<long> cardId;
				internal long? cardId;


			/// <summary>
			/// 优惠类型 1：减钱 2：指定价格
			/// </summary>
[Newtonsoft.Json.JsonProperty("discountType")]//) private Nullable<long> discountType;
				internal long? discountType;


			/// <summary>
			/// 优惠值
			/// </summary>
[Newtonsoft.Json.JsonProperty("discountValue")]//) private Nullable<long> discountValue;
				internal long? discountValue;

				public virtual long? CardId
				{
					set
					{
					this.cardId = value;
					}
					get
					{
					return this.cardId;
					}
				}


				public virtual long? DiscountType
				{
					set
					{
					this.discountType = value;
					}
					get
					{
					return this.discountType;
					}
				}


				public virtual long? DiscountValue
				{
					set
					{
					this.discountValue = value;
					}
					get
					{
					return this.discountValue;
					}
				}


		}


	}
}