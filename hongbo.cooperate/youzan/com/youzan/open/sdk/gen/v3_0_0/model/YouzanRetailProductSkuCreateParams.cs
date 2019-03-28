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

    public class YouzanRetailProductSkuCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品库商品所属分类id
		/// </summary>
		private long? categoryId;
		/// <summary>
		/// 成本价（成本价最大为9999999元。单位：分）
		/// </summary>
		private long? costPrice;
		/// <summary>
		/// 商品库商品名称（名称最多100个字）
		/// </summary>
		private string name;
		/// <summary>
		/// 图片地址 （需先将图片上传素材银行，使用素材银行的图片地址进行发布 [{"url":"https://img.yzcdn.cn/public_files/2017/08/30/63a8d28bce4ca2e5d081e1e69926288e.jpg"},{"url":"https://img.yzcdn.cn/public_files/2017/08/30/63a8d28bce4ca2e5d081e1e69926288e.jpg"}]）
		/// </summary>
		private string photoUrl;
		/// <summary>
		/// 商品库商品编码（最多20个字符，仅限英文字符与数据组合。如果为空，系统自动生成）
		/// </summary>
		private string skuNo;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;
		/// <summary>
		/// 商品库商品规格（规格最多100个字）
		/// </summary>
		private string specifications;
		/// <summary>
		/// 库存数量，保留三位小数，传输值是实际库存值1000倍（初始库存量最大为100000*1000）
		/// </summary>
		private long? stockNum;
		/// <summary>
		/// 单位，如：克、千克
		/// </summary>
		private string unit;

		public virtual long? CategoryId
		{
			set
			{
				this.categoryId = value;
			}
			get
			{
				return this.categoryId;
			}
		}


		public virtual long? CostPrice
		{
			set
			{
				this.costPrice = value;
			}
			get
			{
				return this.costPrice;
			}
		}


		public virtual string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name;
			}
		}


		public virtual string PhotoUrl
		{
			set
			{
				this.photoUrl = value;
			}
			get
			{
				return this.photoUrl;
			}
		}


		public virtual string SkuNo
		{
			set
			{
				this.skuNo = value;
			}
			get
			{
				return this.skuNo;
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


		public virtual string Specifications
		{
			set
			{
				this.specifications = value;
			}
			get
			{
				return this.specifications;
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


		public virtual string Unit
		{
			set
			{
				this.unit = value;
			}
			get
			{
				return this.unit;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (categoryId != null)
			{
				@params["category_id"] = categoryId;
			}
			if (costPrice != null)
			{
				@params["cost_price"] = costPrice;
			}
			if (!string.ReferenceEquals(name, null))
			{
				@params["name"] = name;
			}
			if (!string.ReferenceEquals(photoUrl, null))
			{
				@params["photo_url"] = photoUrl;
			}
			if (!string.ReferenceEquals(skuNo, null))
			{
				@params["sku_no"] = skuNo;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (!string.ReferenceEquals(specifications, null))
			{
				@params["specifications"] = specifications;
			}
			if (stockNum != null)
			{
				@params["stock_num"] = stockNum;
			}
			if (!string.ReferenceEquals(unit, null))
			{
				@params["unit"] = unit;
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