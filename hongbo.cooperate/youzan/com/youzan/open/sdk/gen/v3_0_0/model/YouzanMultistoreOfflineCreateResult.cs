namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMultistoreOfflineCreateResult : APIResult
	{



		/// <summary>
		/// 成功时返回新增的网点id
		/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
		private long? id;

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



	}
}