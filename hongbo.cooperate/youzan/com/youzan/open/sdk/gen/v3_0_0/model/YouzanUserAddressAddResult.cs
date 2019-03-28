namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUserAddressAddResult : APIResult
	{



		/// <summary>
		/// 地址id
		/// </summary>
[Newtonsoft.Json.JsonProperty("response")]//) private Nullable<long> response;
		private long? response;

		public virtual long? Response
		{
			set
			{
				this.response = value;
			}
			get
			{
				return this.response;
			}
		}



	}
}