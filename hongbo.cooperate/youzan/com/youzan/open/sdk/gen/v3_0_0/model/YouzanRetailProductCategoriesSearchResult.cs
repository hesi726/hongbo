using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductCategoriesSearchResult : APIResult
	{



		/// <summary>
		/// 分类详情列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("category_vo")]//) private CategoryVO[] categoryVo;
		private CategoryVO[] categoryVo;

		public virtual CategoryVO[] CategoryVo
		{
			set
			{
				this.categoryVo = value;
			}
			get
			{
				return this.categoryVo;
			}
		}


		public class CategoryVO
		{


			/// <summary>
			/// 唯一性序列号
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 关联的商户id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 父级节点的id
			/// </summary>
[Newtonsoft.Json.JsonProperty("parent_id")]//) private Nullable<long> parentId;
				internal long? parentId;


			/// <summary>
			/// 类目名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 类型：1 根节点 ，2树枝节点 3叶子节点
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private java.util.Date createdAt;
				internal DateTime createdAt;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updated_at")]//) private java.util.Date updatedAt;
				internal DateTime updatedAt;

				public virtual long? Id
				{
					set
					{
					this.id = value;
					}
					get
					{
					return this.id;
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


				public virtual long? ParentId
				{
					set
					{
					this.parentId = value;
					}
					get
					{
					return this.parentId;
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


				public virtual long? Type
				{
					set
					{
					this.type = value;
					}
					get
					{
					return this.type;
					}
				}


				public virtual DateTime CreatedAt
				{
					set
					{
					this.createdAt = value;
					}
					get
					{
					return this.createdAt;
					}
				}


				public virtual DateTime UpdatedAt
				{
					set
					{
					this.updatedAt = value;
					}
					get
					{
					return this.updatedAt;
					}
				}


		}


	}
}