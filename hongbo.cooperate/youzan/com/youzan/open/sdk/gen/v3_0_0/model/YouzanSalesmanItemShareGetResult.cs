namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanSalesmanItemShareGetResult : APIResult
	{



		/// <summary>
		/// 商品推广地址
		/// </summary>
[Newtonsoft.Json.JsonProperty("link")]//) private String link;
		private string link;

		public virtual string Link
		{
			set
			{
				this.link = value;
			}
			get
			{
				return this.link;
			}
		}



	}
}