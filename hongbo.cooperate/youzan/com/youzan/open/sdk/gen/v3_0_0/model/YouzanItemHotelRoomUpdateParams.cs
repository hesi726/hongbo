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

    public class YouzanItemHotelRoomUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品Id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 房态详情列表，一次最多30条数据
		/// [{stock_date:"2017-10-31",status:1,price:322.01,stock_num:65}]
		/// </summary>
		private string roomStock;
		/// <summary>
		/// 规格Id，无规格商品不用填写
		/// </summary>
		private long? skuId;

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


		public virtual string RoomStock
		{
			set
			{
				this.roomStock = value;
			}
			get
			{
				return this.roomStock;
			}
		}


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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (!string.ReferenceEquals(roomStock, null))
			{
				@params["room_stock"] = roomStock;
			}
			if (skuId != null)
			{
				@params["sku_id"] = skuId;
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