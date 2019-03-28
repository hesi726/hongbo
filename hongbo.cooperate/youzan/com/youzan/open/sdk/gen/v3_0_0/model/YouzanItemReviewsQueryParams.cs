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

    public class YouzanItemReviewsQueryParams : APIParams, FileParams
	{

		/// <summary>
		/// alias，短url，唯一字符串
		/// </summary>
		private string alias;
		/// <summary>
		/// 是否获取头像的信息，（注：1是；0否）,必填项
		/// </summary>
		private long? avatar;
		/// <summary>
		/// 买家id
		/// </summary>
		private long? buyerId;
		/// <summary>
		/// 粉丝id
		/// </summary>
		private long? fansId;
		/// <summary>
		/// 粉丝类型
		/// </summary>
		private long? fansType;
		/// <summary>
		/// 商品id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 最新的评价id
		/// </summary>
		private long? lastReviewId;
		/// <summary>
		/// 页数
		/// </summary>
		private long? page;
		/// <summary>
		/// 每页大小
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 图片
		/// </summary>
		private string picture;
		/// <summary>
		/// 评价的数值
		/// </summary>
		private long? rate;
		/// <summary>
		/// 评价内容
		/// </summary>
		private string review;
		/// <summary>
		/// 供货商采购订单编号
		/// </summary>
		private string sellerTid;
		/// <summary>
		/// skuId
		/// </summary>
		private long? skuId;
		/// <summary>
		/// 供应商的店铺goodsId，必填，如果是分销商品，则supplierGoodsId为供应商的goodsId，如是普通商品则supplierGoodsId为当前的goodsId
		/// </summary>
		private long? supplierItemId;
		/// <summary>
		/// 供应商的店铺kdtId，必填，如果是分销商品，则supplierKdtId为供应商的kdtId，如是普通商品则supplierKdtId为自己店铺kdtId
		/// </summary>
		private long? supplierKdtId;
		/// <summary>
		/// 供应商skuId
		/// </summary>
		private long? supplierSkuId;
		/// <summary>
		/// 订单号
		/// </summary>
		private string tid;

		public virtual string Alias
		{
			set
			{
				this.alias = value;
			}
			get
			{
				return this.alias;
			}
		}


		public virtual long? Avatar
		{
			set
			{
				this.avatar = value;
			}
			get
			{
				return this.avatar;
			}
		}


		public virtual long? BuyerId
		{
			set
			{
				this.buyerId = value;
			}
			get
			{
				return this.buyerId;
			}
		}


		public virtual long? FansId
		{
			set
			{
				this.fansId = value;
			}
			get
			{
				return this.fansId;
			}
		}


		public virtual long? FansType
		{
			set
			{
				this.fansType = value;
			}
			get
			{
				return this.fansType;
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


		public virtual long? LastReviewId
		{
			set
			{
				this.lastReviewId = value;
			}
			get
			{
				return this.lastReviewId;
			}
		}


		public virtual long? Page
		{
			set
			{
				this.page = value;
			}
			get
			{
				return this.page;
			}
		}


		public virtual long? PageSize
		{
			set
			{
				this.pageSize = value;
			}
			get
			{
				return this.pageSize;
			}
		}


		public virtual string Picture
		{
			set
			{
				this.picture = value;
			}
			get
			{
				return this.picture;
			}
		}


		public virtual long? Rate
		{
			set
			{
				this.rate = value;
			}
			get
			{
				return this.rate;
			}
		}


		public virtual string Review
		{
			set
			{
				this.review = value;
			}
			get
			{
				return this.review;
			}
		}


		public virtual string SellerTid
		{
			set
			{
				this.sellerTid = value;
			}
			get
			{
				return this.sellerTid;
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


		public virtual long? SupplierItemId
		{
			set
			{
				this.supplierItemId = value;
			}
			get
			{
				return this.supplierItemId;
			}
		}


		public virtual long? SupplierKdtId
		{
			set
			{
				this.supplierKdtId = value;
			}
			get
			{
				return this.supplierKdtId;
			}
		}


		public virtual long? SupplierSkuId
		{
			set
			{
				this.supplierSkuId = value;
			}
			get
			{
				return this.supplierSkuId;
			}
		}


		public virtual string Tid
		{
			set
			{
				this.tid = value;
			}
			get
			{
				return this.tid;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(alias, null))
			{
				@params["alias"] = alias;
			}
			if (avatar != null)
			{
				@params["avatar"] = avatar;
			}
			if (buyerId != null)
			{
				@params["buyer_id"] = buyerId;
			}
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
			}
			if (fansType != null)
			{
				@params["fans_type"] = fansType;
			}
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (lastReviewId != null)
			{
				@params["last_review_id"] = lastReviewId;
			}
			if (page != null)
			{
				@params["page"] = page;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(picture, null))
			{
				@params["picture"] = picture;
			}
			if (rate != null)
			{
				@params["rate"] = rate;
			}
			if (!string.ReferenceEquals(review, null))
			{
				@params["review"] = review;
			}
			if (!string.ReferenceEquals(sellerTid, null))
			{
				@params["seller_tid"] = sellerTid;
			}
			if (skuId != null)
			{
				@params["sku_id"] = skuId;
			}
			if (supplierItemId != null)
			{
				@params["supplier_item_id"] = supplierItemId;
			}
			if (supplierKdtId != null)
			{
				@params["supplier_kdt_id"] = supplierKdtId;
			}
			if (supplierSkuId != null)
			{
				@params["supplier_sku_id"] = supplierSkuId;
			}
			if (!string.ReferenceEquals(tid, null))
			{
				@params["tid"] = tid;
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