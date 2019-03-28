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

    public class YouzanItemHotelRoomSetParams : APIParams, FileParams
	{

		/// <summary>
		/// 开始日期,格式 yyyy-mm-dd
		/// </summary>
		private string beginDate;
		/// <summary>
		/// 结束日期,格式 yyyy-mm-dd
		/// </summary>
		private string endDate;
		/// <summary>
		/// 商品Id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 价格;单位元,精确到小数后2位
		/// </summary>
		private float? price;
		/// <summary>
		/// 规格ID,无规格商品不用填写
		/// </summary>
		private long? skuId;
		/// <summary>
		/// 一段时间内指定某几天设置,不填写默认全设置，多个逗号分隔；周一:1,周二:2,周三:3,周四:4,周五:5,周六:6,周日:7
		/// </summary>
		private string specialWeeks;
		/// <summary>
		/// 开关房: 1开启 0关闭
		/// </summary>
		private long? status;
		/// <summary>
		/// 库存数量
		/// </summary>
		private long? stockNum;

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


		public virtual float? Price
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


		public virtual string SpecialWeeks
		{
			set
			{
				this.specialWeeks = value;
			}
			get
			{
				return this.specialWeeks;
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
			if (price != null)
			{
				@params["price"] = price;
			}
			if (skuId != null)
			{
				@params["sku_id"] = skuId;
			}
			if (!string.ReferenceEquals(specialWeeks, null))
			{
				@params["special_weeks"] = specialWeeks;
			}
			if (status != null)
			{
				@params["status"] = status;
			}
			if (stockNum != null)
			{
				@params["stock_num"] = stockNum;
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