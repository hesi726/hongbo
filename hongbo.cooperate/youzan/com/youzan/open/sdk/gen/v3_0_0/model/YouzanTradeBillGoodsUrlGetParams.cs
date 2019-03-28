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

    public class YouzanTradeBillGoodsUrlGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品信息,goods_id，sku_id,num都为必填项
		/// </summary>
		private string itemList;
		/// <summary>
		/// 店铺id
		/// </summary>
		private long? kdtId;
		/// <summary>
		/// 是否来自购物车
		/// </summary>
		private string orderFrom;
		/// <summary>
		/// 订单类型，0表示普通订单，还有其他类型类似赠品、酒店、拼团等类型
		/// </summary>
		private long? orderType;
		/// <summary>
		/// 订单来源：购物车，卡门等
		/// </summary>
		private string source;

		public virtual string ItemList
		{
			set
			{
				this.itemList = value;
			}
			get
			{
				return this.itemList;
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


		public virtual string OrderFrom
		{
			set
			{
				this.orderFrom = value;
			}
			get
			{
				return this.orderFrom;
			}
		}


		public virtual long? OrderType
		{
			set
			{
				this.orderType = value;
			}
			get
			{
				return this.orderType;
			}
		}


		public virtual string Source
		{
			set
			{
				this.source = value;
			}
			get
			{
				return this.source;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(itemList, null))
			{
				@params["item_list"] = itemList;
			}
			if (kdtId != null)
			{
				@params["kdt_id"] = kdtId;
			}
			if (!string.ReferenceEquals(orderFrom, null))
			{
				@params["order_from"] = orderFrom;
			}
			if (orderType != null)
			{
				@params["order_type"] = orderType;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
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