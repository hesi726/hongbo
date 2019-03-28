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

    public class YouzanTradeCartAddParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品活动别名
		/// </summary>
		private string activityAlias;
		/// <summary>
		/// 商品营销活动id
		/// </summary>
		private long? activityId;
		/// <summary>
		/// 商品营销活动类型
		/// </summary>
		private long? activityType;
		/// <summary>
		/// 扩展字段
		/// </summary>
		private string bizTracePointExt;
		/// <summary>
		/// 商品id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 店铺id
		/// </summary>
		private long? kdtId;
		/// <summary>
		/// 商品留言
		/// </summary>
		private string message;
		/// <summary>
		/// 商品数量
		/// </summary>
		private long? num;
		/// <summary>
		/// 商品skuid
		/// </summary>
		private long? skuId;
		/// <summary>
		/// 门店id,多门店时才会涉及到，不是多门店的情况填0
		/// </summary>
		private long? storeId;

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


		public virtual string BizTracePointExt
		{
			set
			{
				this.bizTracePointExt = value;
			}
			get
			{
				return this.bizTracePointExt;
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


		public virtual long? StoreId
		{
			set
			{
				this.storeId = value;
			}
			get
			{
				return this.storeId;
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
			if (!string.ReferenceEquals(bizTracePointExt, null))
			{
				@params["biz_trace_point_ext"] = bizTracePointExt;
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
			if (skuId != null)
			{
				@params["sku_id"] = skuId;
			}
			if (storeId != null)
			{
				@params["store_id"] = storeId;
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