namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanPayMerchantProductSigncontractCreateResult : APIResult
	{



		/// <summary>
		/// 商户号
		/// </summary>
[Newtonsoft.Json.JsonProperty("user_no")]//) private String userNo;
		private string userNo;


		/// <summary>
		/// 签约编号
		/// </summary>
[Newtonsoft.Json.JsonProperty("contract_id")]//) private String contractId;
		private string contractId;

		public virtual string UserNo
		{
			set
			{
				this.userNo = value;
			}
			get
			{
				return this.userNo;
			}
		}

		public virtual string ContractId
		{
			set
			{
				this.contractId = value;
			}
			get
			{
				return this.contractId;
			}
		}



	}
}