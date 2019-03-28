namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCustomerRemarkUpdateResult : APIResult
	{



		/// <summary>
		/// 更新是否成功
		/// </summary>
[Newtonsoft.Json.JsonProperty("response")]//) private Nullable<bool> response;
		private bool? response;

		public virtual bool? Response
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