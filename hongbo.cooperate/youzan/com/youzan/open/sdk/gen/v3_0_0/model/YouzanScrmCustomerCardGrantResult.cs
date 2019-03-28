namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCustomerCardGrantResult : APIResult
	{



		/// <summary>
		/// 是否成功
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private Nullable<bool> isSuccess;
		private bool? isSuccess;


		/// <summary>
		/// 用户会员卡号
		/// </summary>
[Newtonsoft.Json.JsonProperty("card_no")]//) private String cardNo;
		private string cardNo;

		public virtual bool? IsSuccess
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

		public virtual string CardNo
		{
			set
			{
				this.cardNo = value;
			}
			get
			{
				return this.cardNo;
			}
		}



	}
}