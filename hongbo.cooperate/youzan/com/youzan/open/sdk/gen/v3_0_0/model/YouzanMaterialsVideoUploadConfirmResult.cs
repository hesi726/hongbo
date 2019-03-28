namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMaterialsVideoUploadConfirmResult : APIResult
	{



		/// <summary>
		/// 确认结果
		/// </summary>
[Newtonsoft.Json.JsonProperty("result")]//) private String result;
		private string result;

		public virtual string Result
		{
			set
			{
				this.result = value;
			}
			get
			{
				return this.result;
			}
		}



	}
}