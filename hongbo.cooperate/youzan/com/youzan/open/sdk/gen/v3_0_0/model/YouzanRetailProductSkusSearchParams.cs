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

    public class YouzanRetailProductSkusSearchParams : APIParams, FileParams
	{

		/// <summary>
		/// 返回属性（1, "商品基础信息"，3, "库存"）
		/// </summary>
		private string attributes;
		/// <summary>
		/// 批量筛选子类目id
		/// </summary>
		private string categoryIds;
		/// <summary>
		/// 类目筛选的时候是否包括子类目
		/// </summary>
		private bool? childCategory;
		/// <summary>
		/// 库存低值预警
		/// </summary>
		private bool? isLowWarning;
		/// <summary>
		/// 商品名称或商品编码
		/// </summary>
		private string nameOrSkuNo;
		/// <summary>
		/// 查询页面
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 一页数量（最大为50）
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 销售渠道过滤
		/// </summary>
		private long? sellingChannel;
		/// <summary>
		/// 排序字段
		/// </summary>
		private string sortName;
		/// <summary>
		/// 排序顺序  1 升序 2 降序
		/// </summary>
		private long? sortType;
		/// <summary>
		/// 来源
		/// </summary>
		private string source;
		/// <summary>
		/// 仓库id(目前仅支持查询单仓)
		/// </summary>
		private string warehouseIds;

		public virtual string Attributes
		{
			set
			{
				this.attributes = value;
			}
			get
			{
				return this.attributes;
			}
		}


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


		public virtual bool? IsLowWarning
		{
			set
			{
				this.isLowWarning = value;
			}
			get
			{
				return this.isLowWarning;
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


		public virtual long? SellingChannel
		{
			set
			{
				this.sellingChannel = value;
			}
			get
			{
				return this.sellingChannel;
			}
		}


		public virtual string SortName
		{
			set
			{
				this.sortName = value;
			}
			get
			{
				return this.sortName;
			}
		}


		public virtual long? SortType
		{
			set
			{
				this.sortType = value;
			}
			get
			{
				return this.sortType;
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


		public virtual string WarehouseIds
		{
			set
			{
				this.warehouseIds = value;
			}
			get
			{
				return this.warehouseIds;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(attributes, null))
			{
				@params["attributes"] = attributes;
			}
			if (!string.ReferenceEquals(categoryIds, null))
			{
				@params["category_ids"] = categoryIds;
			}
			if (childCategory != null)
			{
				@params["child_category"] = childCategory;
			}
			if (isLowWarning != null)
			{
				@params["is_low_warning"] = isLowWarning;
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
			if (sellingChannel != null)
			{
				@params["selling_channel"] = sellingChannel;
			}
			if (!string.ReferenceEquals(sortName, null))
			{
				@params["sort_name"] = sortName;
			}
			if (sortType != null)
			{
				@params["sort_type"] = sortType;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (!string.ReferenceEquals(warehouseIds, null))
			{
				@params["warehouse_ids"] = warehouseIds;
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