namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRegionsGetResult : APIResult
	{



		/// <summary>
		/// 区域地名列表信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("regions")]//) private CommonRegion[] regions;
		private CommonRegion[] regions;

		public virtual CommonRegion[] Regions
		{
			set
			{
				this.regions = value;
			}
			get
			{
				return this.regions;
			}
		}


		public class CommonRegion
		{


			/// <summary>
			/// 上级区域ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("parent_id")]//) private Nullable<long> parentId;
				internal long? parentId;


			/// <summary>
			/// 区域ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 区域全称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;

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


		}


	}
}