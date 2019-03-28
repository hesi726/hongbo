namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanLogisticsExpressGetResult : APIResult
	{



		/// <summary>
		/// 所有物流公司地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("allExpress")]//) private LogisticsExpressOpenApiModel[] allExpress;
		private LogisticsExpressOpenApiModel[] allExpress;

		public virtual LogisticsExpressOpenApiModel[] AllExpress
		{
			set
			{
				this.allExpress = value;
			}
			get
			{
				return this.allExpress;
			}
		}


		public class LogisticsExpressOpenApiModel
		{


			/// <summary>
			/// 物流公司编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 物流公司名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 是否显示 0显示 1不显示
			/// </summary>
[Newtonsoft.Json.JsonProperty("display")]//) private Nullable<long> display;
				internal long? display;

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


				public virtual long? Display
				{
					set
					{
					this.display = value;
					}
					get
					{
					return this.display;
					}
				}


		}


	}
}