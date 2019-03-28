namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanShopAddressCreateResult : APIResult
	{



		/// <summary>
		/// 是否成功
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private Nullable<bool> isSuccess;
		private bool? isSuccess;


		/// <summary>
		/// 新增的地址id
		/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
		private long? id;

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

		public virtual long? Id
		{
			set
			{
				this.id = value;
			}
			get
			{
				return this.id;
			}
		}



	}
}