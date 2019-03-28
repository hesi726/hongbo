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

    public class YouzanTradeBillGoodUrlGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品活动别名,如果没有该值，填''
		/// </summary>
		private string activityAlias;
		/// <summary>
		/// 商品营销活动id,如果没有该值，填0
		/// </summary>
		private long? activityId;
		/// <summary>
		/// 商品应用营销活动类型,如果没有该值，填0
		/// </summary>
		private long? activityType;
		/// <summary>
		/// 商品id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 店铺id
		/// </summary>
		private long? kdtId;
		/// <summary>
		/// 商品留言，按商品设置的留言顺序将留言内容传入即可，图片留言请传入图片url。示例["文本测试", "123", "moyu@youzan.com", "2017-07-11", "16:08", "123456789012345678", "https://img.yzcdn.cn/upload_files/2017/02/22/148775750218475652.png"]
		/// </summary>
		private string message;
		/// <summary>
		/// 商品数量
		/// </summary>
		private long? num;
		/// <summary>
		/// 是否来自购物车
		/// </summary>
		private string orderFrom;
		/// <summary>
		/// 订单类型，0表示普通订单，还有其他类型类似赠品、酒店、拼团等类型
		/// </summary>
		private long? orderType;
		/// <summary>
		/// 价格，单位分
		/// </summary>
		private long? price;
		/// <summary>
		/// 规格id 无规格商品无需填写，多规格商品必须传
		/// </summary>
		private long? skuId;
		/// <summary>
		/// 订单来源：购物车，卡门等
		/// </summary>
		private string source;
		/// <summary>
		/// 是否支持微信支付
		/// </summary>
		private long? useWxpay;

		public virtual string ActivityAlias
		{
			set
			{
				this.activityAlias = value;
			}
			get
			{
				return this.activityAlias;
			}
		}


		public virtual long? ActivityId
		{
			set
			{
				this.activityId = value;
			}
			get
			{
				return this.activityId;
			}
		}


		public virtual long? ActivityType
		{
			set
			{
				this.activityType = value;
			}
			get
			{
				return this.activityType;
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


		public virtual string Message
		{
			set
			{
				this.message = value;
			}
			get
			{
				return this.message;
			}
		}


		public virtual long? Num
		{
			set
			{
				this.num = value;
			}
			get
			{
				return this.num;
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


		public virtual long? UseWxpay
		{
			set
			{
				this.useWxpay = value;
			}
			get
			{
				return this.useWxpay;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(activityAlias, null))
			{
				@params["activity_alias"] = activityAlias;
			}
			if (activityId != null)
			{
				@params["activity_id"] = activityId;
			}
			if (activityType != null)
			{
				@params["activity_type"] = activityType;
			}
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (kdtId != null)
			{
				@params["kdt_id"] = kdtId;
			}
			if (!string.ReferenceEquals(message, null))
			{
				@params["message"] = message;
			}
			if (num != null)
			{
				@params["num"] = num;
			}
			if (!string.ReferenceEquals(orderFrom, null))
			{
				@params["order_from"] = orderFrom;
			}
			if (orderType != null)
			{
				@params["order_type"] = orderType;
			}
			if (price != null)
			{
				@params["price"] = price;
			}
			if (skuId != null)
			{
				@params["sku_id"] = skuId;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (useWxpay != null)
			{
				@params["use_wxpay"] = useWxpay;
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