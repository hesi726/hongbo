namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeBillGoodsUrlGetResult : APIResult
	{



		/// <summary>
		/// 操作是否成功，true为成功，false为失败
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private Nullable<bool> isSuccess;
		private bool? isSuccess;


		/// <summary>
		/// 操作key
		/// </summary>
[Newtonsoft.Json.JsonProperty("book_key")]//) private String bookKey;
		private string bookKey;


		/// <summary>
		/// 多商品下单结算页url
		/// </summary>
[Newtonsoft.Json.JsonProperty("url")]//) private String url;
		private string url;

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

		public virtual string BookKey
		{
			set
			{
				this.bookKey = value;
			}
			get
			{
				return this.bookKey;
			}
		}

		public virtual string Url
		{
			set
			{
				this.url = value;
			}
			get
			{
				return this.url;
			}
		}



	}
}