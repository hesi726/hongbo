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

    public class YouzanItemHotelRoomQueryParams : APIParams, FileParams
	{

		/// <summary>
		/// 房态开始时间
		/// </summary>
		private string beginDate;
		/// <summary>
		/// 房态结束时间
		/// </summary>
		private string endDate;
		/// <summary>
		/// 商品Id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// skuIds, 多个id用,隔开
		/// </summary>
		private string skuIds;

		public virtual string BeginDate
		{
			set
			{
				this.beginDate = value;
			}
			get
			{
				return this.beginDate;
			}
		}


		public virtual string EndDate
		{
			set
			{
				this.endDate = value;
			}
			get
			{
				return this.endDate;
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


		public virtual string SkuIds
		{
			set
			{
				this.skuIds = value;
			}
			get
			{
				return this.skuIds;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(beginDate, null))
			{
				@params["begin_date"] = beginDate;
			}
			if (!string.ReferenceEquals(endDate, null))
			{
				@params["end_date"] = endDate;
			}
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (!string.ReferenceEquals(skuIds, null))
			{
				@params["sku_ids"] = skuIds;
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