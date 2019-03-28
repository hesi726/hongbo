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

    public class YouzanRetailProductsOfflineSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 批量筛选类目id
		/// </summary>
		private string categoryIds;
		/// <summary>
		/// 类目筛选的时候是否包括子类目
		/// </summary>
		private bool? childCategory;
		/// <summary>
		/// 销售端产品状态（0:下架 1:上架）
		/// </summary>
		private string isDisplays;
		/// <summary>
		/// 称重类型（0计量, 10称重）
		/// </summary>
		private long? measurement;
		/// <summary>
		/// 商品名称或商品编码
		/// </summary>
		private string nameOrSkuNo;
		/// <summary>
		/// 查询页面
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 一页数量（最大50）
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 售罄状态（  
		/// 0: 在售, 对内表示sold_status in (0, 1, 3)
		/// 1: 售罄或部分售罄,对内表示 sold_status in (2, 3)
		/// 2： 全部，等同于不填
		/// 3: 有赞出售中，对内表示 1 出售中, 3 部分售罄
		/// 4. 有赞全部，对内表示：1, 2 全部售罄, 3
		/// 5. 全部售罄：对内: sold_status = 2
		/// 6. 部分售罄：对内： sold_status = 3）
		/// </summary>
		private long? showSoldOut;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;

		public virtual string CategoryIds
		{
			set
			{
				this.categoryIds = value;
			}
			get
			{
				return this.categoryIds;
			}
		}


		public virtual bool? ChildCategory
		{
			set
			{
				this.childCategory = value;
			}
			get
			{
				return this.childCategory;
			}
		}


		public virtual string IsDisplays
		{
			set
			{
				this.isDisplays = value;
			}
			get
			{
				return this.isDisplays;
			}
		}


		public virtual long? Measurement
		{
			set
			{
				this.measurement = value;
			}
			get
			{
				return this.measurement;
			}
		}


		public virtual string NameOrSkuNo
		{
			set
			{
				this.nameOrSkuNo = value;
			}
			get
			{
				return this.nameOrSkuNo;
			}
		}


		public virtual long? PageNo
		{
			set
			{
				this.pageNo = value;
			}
			get
			{
				return this.pageNo;
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


		public virtual long? ShowSoldOut
		{
			set
			{
				this.showSoldOut = value;
			}
			get
			{
				return this.showSoldOut;
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
			if (!string.ReferenceEquals(categoryIds, null))
			{
				@params["category_ids"] = categoryIds;
			}
			if (childCategory != null)
			{
				@params["child_category"] = childCategory;
			}
			if (!string.ReferenceEquals(isDisplays, null))
			{
				@params["is_displays"] = isDisplays;
			}
			if (measurement != null)
			{
				@params["measurement"] = measurement;
			}
			if (!string.ReferenceEquals(nameOrSkuNo, null))
			{
				@params["name_or_sku_no"] = nameOrSkuNo;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (showSoldOut != null)
			{
				@params["show_sold_out"] = showSoldOut;
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