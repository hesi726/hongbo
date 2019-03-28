namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemcategoriesTagAddResult : APIResult
	{



		/// <summary>
		/// 商品标签的描述
		/// </summary>
[Newtonsoft.Json.JsonProperty("tag")]//) private GoodsTag tag;
		private GoodsTag tag;

		public virtual GoodsTag Tag
		{
			set
			{
				this.tag = value;
			}
			get
			{
				return this.tag;
			}
		}


		public class GoodsTag
		{


			/// <summary>
			/// 商品标签的ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 商品标签的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 商品标签类型，0 自定义，1 未分类，2 最新，3 最热，4 隐藏
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 商品标签创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private String created;
				internal string created;


			/// <summary>
			/// 商品标签内的商品数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_num")]//) private Nullable<long> itemNum;
				internal long? itemNum;


			/// <summary>
			/// 商品标签的展示的URL地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("tag_url")]//) private String tagUrl;
				internal string tagUrl;


			/// <summary>
			/// 分享出去的商品标签展示地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("share_url")]//) private String shareUrl;
				internal string shareUrl;


			/// <summary>
			/// 商品标签描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;

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


		}


	}
}