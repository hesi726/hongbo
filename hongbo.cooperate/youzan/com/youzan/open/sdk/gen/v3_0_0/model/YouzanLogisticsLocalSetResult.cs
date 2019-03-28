namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanLogisticsLocalSetResult : APIResult
	{



		/// <summary>
		/// 是否成功
		/// </summary>
[Newtonsoft.Json.JsonProperty("isSucess")]//) private Nullable<bool> isSucess;
		private bool? isSucess;

		public virtual bool? IsSucess
		{
			set
			{
				this.isSucess = value;
			}
			get
			{
				return this.isSucess;
			}
		}



	}
}