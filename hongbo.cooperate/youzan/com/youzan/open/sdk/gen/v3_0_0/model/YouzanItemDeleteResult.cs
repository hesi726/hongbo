namespace com.youzan.open.sdk.gen.v3_0_0.model
{
    using APIResult = com.youzan.open.sdk.model.APIResult;

    public class YouzanItemDeleteResult : APIResult
	{



		/// <summary>
		/// 被删除的商品id
		/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
		private long? itemId;


		/// <summary>
		/// 是否操作成功，成功为true
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private Nullable<bool> isSuccess;
		private bool? isSuccess;

		public virtual long? ItemId
		{
			set
			{
				this.itemId = value;
			}
			get
			{
				return this.itemId;
			}
		}

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



	}
}