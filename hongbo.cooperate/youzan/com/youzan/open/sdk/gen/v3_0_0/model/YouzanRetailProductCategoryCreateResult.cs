namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductCategoryCreateResult : APIResult
	{



		/// <summary>
		/// 创建成功分类id
		/// </summary>
[Newtonsoft.Json.JsonProperty("create_result")]//) private Nullable<long> createResult;
		private long? createResult;

		public virtual long? CreateResult
		{
			set
			{
				this.createResult = value;
			}
			get
			{
				return this.createResult;
			}
		}



	}
}