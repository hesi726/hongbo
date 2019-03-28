namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUserWeixinOpenidGetResult : APIResult
	{



		/// <summary>
		/// 获取到的用户open_id
		/// </summary>
[Newtonsoft.Json.JsonProperty("open_id")]//) private String openId;
		private string openId;

		public virtual string OpenId
		{
			set
			{
				this.openId = value;
			}
			get
			{
				return this.openId;
			}
		}



	}
}