namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemTemplateListSearchResult : APIResult
	{



		/// <summary>
		/// 商品详情模板
		/// </summary>
[Newtonsoft.Json.JsonProperty("temps")]//) private ItemDetailTempOpenModel temps;
		private ItemDetailTempOpenModel temps;

		public virtual ItemDetailTempOpenModel Temps
		{
			set
			{
				this.temps = value;
			}
			get
			{
				return this.temps;
			}
		}


		public class ItemDetailTempOpenModel
		{


			/// <summary>
			/// 模板Id
			/// </summary>
[Newtonsoft.Json.JsonProperty("detailTempId")]//) private Nullable<long> detailTempId;
				internal long? detailTempId;


			/// <summary>
			/// 标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 短地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
				internal string alias;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("components")]//) private String components;
				internal string components;
			/// 


[Newtonsoft.Json.JsonProperty("createdTime")]//) private String createdTime;
				internal string createdTime;

				public virtual long? DetailTempId
				{
					set
					{
					this.detailTempId = value;
					}
					get
					{
					return this.detailTempId;
					}
				}


				public virtual string Title
				{
					set
					{
					this.title = value;
					}
					get
					{
					return this.title;
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


				public virtual string Components
				{
					set
					{
					this.components = value;
					}
					get
					{
					return this.components;
					}
				}


				public virtual string CreatedTime
				{
					set
					{
					this.createdTime = value;
					}
					get
					{
					return this.createdTime;
					}
				}


		}


	}
}