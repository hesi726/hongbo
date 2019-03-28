namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemcategoriesTagsGetResult : APIResult
	{



		/// <summary>
		/// 分组返回信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("tags")]//) private ItemGroupOpenModel[] tags;
		private ItemGroupOpenModel[] tags;

		public virtual ItemGroupOpenModel[] Tags
		{
			set
			{
				this.tags = value;
			}
			get
			{
				return this.tags;
			}
		}


		public class ItemGroupOpenModel
		{


			/// <summary>
			/// id
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 分组类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 别名
			/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
				internal string alias;


			/// <summary>
			/// 分组链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("tag_url")]//) private String tagUrl;
				internal string tagUrl;


			/// <summary>
			/// 分享链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("share_url")]//) private String shareUrl;
				internal string shareUrl;


			/// <summary>
			/// 商品数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_num")]//) private Nullable<long> itemNum;
				internal long? itemNum;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private String created;
				internal string created;


			/// <summary>
			/// 描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;


			/// <summary>
			/// 分组名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;

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


				public virtual string TagUrl
				{
					set
					{
					this.tagUrl = value;
					}
					get
					{
					return this.tagUrl;
					}
				}


				public virtual string ShareUrl
				{
					set
					{
					this.shareUrl = value;
					}
					get
					{
					return this.shareUrl;
					}
				}


				public virtual long? ItemNum
				{
					set
					{
					this.itemNum = value;
					}
					get
					{
					return this.itemNum;
					}
				}


				public virtual string Created
				{
					set
					{
					this.created = value;
					}
					get
					{
					return this.created;
					}
				}


				public virtual string Desc
				{
					set
					{
					this.desc = value;
					}
					get
					{
					return this.desc;
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


		}


	}
}