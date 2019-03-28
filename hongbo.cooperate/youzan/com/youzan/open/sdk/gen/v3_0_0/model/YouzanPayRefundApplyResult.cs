namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanPayRefundApplyResult : APIResult
	{



		/// <summary>
		/// 退款查询结果码
		/// </summary>
[Newtonsoft.Json.JsonProperty("result_code")]//) private String resultCode;
		private string resultCode;


		/// <summary>
		/// 错误信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("error_msg")]//) private String errorMsg;
		private string errorMsg;

		public virtual string ResultCode
		{
			set
			{
				this.resultCode = value;
			}
			get
			{
				return this.resultCode;
			}
		}

		public virtual string ErrorMsg
		{
			set
			{
				this.errorMsg = value;
			}
			get
			{
				return this.errorMsg;
			}
		}



	}
}