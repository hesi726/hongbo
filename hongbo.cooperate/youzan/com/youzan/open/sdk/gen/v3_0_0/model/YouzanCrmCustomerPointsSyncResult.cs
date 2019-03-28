namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanCrmCustomerPointsSyncResult : APIResult
	{



		/// <summary>
		/// true表示操作成功，false表示操作失败
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private String isSuccess;
		private string isSuccess;

		public virtual string IsSuccess
		{
			set
			{
				this.isSuccess = value;
			}
			get
			{
				return this.isSuccess;
			}
		}



	}
}