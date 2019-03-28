namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductOfflineUpdateResult : APIResult
	{



		/// <summary>
		/// 是否编辑成功
		/// </summary>
[Newtonsoft.Json.JsonProperty("update_result")]//) private Nullable<bool> updateResult;
		private bool? updateResult;

		public virtual bool? UpdateResult
		{
			set
			{
				this.updateResult = value;
			}
			get
			{
				return this.updateResult;
			}
		}



	}
}