namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMultistoreSettingGetResult : APIResult
	{



		/// <summary>
		/// 0表示关闭多门店，1表示开启多门店
		/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private Nullable<long> status;
		private long? status;


		/// <summary>
		/// 设为总店的网点id
		/// </summary>
[Newtonsoft.Json.JsonProperty("default_offline_id")]//) private Nullable<long> defaultOfflineId;
		private long? defaultOfflineId;


		/// <summary>
		/// 1表示开启独立库存，0表示关闭。（注意：独立价格和独立库存必须同时开启，同时关闭）
		/// </summary>
[Newtonsoft.Json.JsonProperty("separate_stock")]//) private Nullable<long> separateStock;
		private long? separateStock;


		/// <summary>
		/// 1表示开启独立价格，0表示关闭。（注意：独立价格和独立库存必须同时开启，同时关闭）
		/// </summary>
[Newtonsoft.Json.JsonProperty("separate_price")]//) private Nullable<long> separatePrice;
		private long? separatePrice;


		/// <summary>
		/// 1表示开启商品售罄时推荐可售网点，0表示关闭
		/// </summary>
[Newtonsoft.Json.JsonProperty("sold_out_recommend")]//) private Nullable<long> soldOutRecommend;
		private long? soldOutRecommend;

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

		public virtual long? DefaultOfflineId
		{
			set
			{
				this.defaultOfflineId = value;
			}
			get
			{
				return this.defaultOfflineId;
			}
		}

		public virtual long? SeparateStock
		{
			set
			{
				this.separateStock = value;
			}
			get
			{
				return this.separateStock;
			}
		}

		public virtual long? SeparatePrice
		{
			set
			{
				this.separatePrice = value;
			}
			get
			{
				return this.separatePrice;
			}
		}

		public virtual long? SoldOutRecommend
		{
			set
			{
				this.soldOutRecommend = value;
			}
			get
			{
				return this.soldOutRecommend;
			}
		}



	}
}