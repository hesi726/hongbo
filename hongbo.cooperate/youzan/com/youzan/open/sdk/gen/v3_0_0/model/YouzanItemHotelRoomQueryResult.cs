namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemHotelRoomQueryResult : APIResult
	{



		/// <summary>
		/// 房态列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("hotel_skus")]//) private HotelSkuModel[] hotelSkus;
		private HotelSkuModel[] hotelSkus;

		public virtual HotelSkuModel[] HotelSkus
		{
			set
			{
				this.hotelSkus = value;
			}
			get
			{
				return this.hotelSkus;
			}
		}


		public class HotelSkuModel
		{


			/// <summary>
			/// 酒店库存ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("hotelSkuId")]//) private Nullable<long> hotelSkuId;
				internal long? hotelSkuId;


			/// <summary>
			/// 商品ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("itemId")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// 店铺ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdtId")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 酒店库存日期
			/// </summary>
[Newtonsoft.Json.JsonProperty("stockDate")]//) private String stockDate;
				internal string stockDate;


			/// <summary>
			/// goods_sku 表的id
			/// </summary>
[Newtonsoft.Json.JsonProperty("itemSkuId")]//) private Nullable<long> itemSkuId;
				internal long? itemSkuId;


			/// <summary>
			/// 房间状态: 0 关闭, 1 开启
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
				internal long? status;


			/// <summary>
			/// 库存数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("stockNum")]//) private Nullable<long> stockNum;
				internal long? stockNum;


			/// <summary>
			/// 房间价格（分）
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;

				public virtual long? HotelSkuId
				{
					set
					{
					this.hotelSkuId = value;
					}
					get
					{
					return this.hotelSkuId;
					}
				}


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


				public virtual long? KdtId
				{
					set
					{
					this.kdtId = value;
					}
					get
					{
					return this.kdtId;
					}
				}


				public virtual string StockDate
				{
					set
					{
					this.stockDate = value;
					}
					get
					{
					return this.stockDate;
					}
				}


				public virtual long? ItemSkuId
				{
					set
					{
					this.itemSkuId = value;
					}
					get
					{
					return this.itemSkuId;
					}
				}


				public virtual long? Status
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


				public virtual long? StockNum
				{
					set
					{
					this.stockNum = value;
					}
					get
					{
					return this.stockNum;
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


		}


	}
}