namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUmpPresentGiveResult : APIResult
	{



		/// <summary>
		/// 是否领取成功 
		/// </summary>
[Newtonsoft.Json.JsonProperty("is_success")]//) private Nullable<bool> isSuccess;
		private bool? isSuccess;


		/// <summary>
		/// 赠品ID
		/// </summary>
[Newtonsoft.Json.JsonProperty("present_id")]//) private Nullable<long> presentId;
		private long? presentId;


		/// <summary>
		/// 赠品名
		/// </summary>
[Newtonsoft.Json.JsonProperty("present_name")]//) private String presentName;
		private string presentName;


		/// <summary>
		/// 赠品领取链接
		/// </summary>
[Newtonsoft.Json.JsonProperty("receive_address")]//) private String receiveAddress;
		private string receiveAddress;

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

		public virtual long? PresentId
		{
			set
			{
				this.presentId = value;
			}
			get
			{
				return this.presentId;
			}
		}

		public virtual string PresentName
		{
			set
			{
				this.presentName = value;
			}
			get
			{
				return this.presentName;
			}
		}

		public virtual string ReceiveAddress
		{
			set
			{
				this.receiveAddress = value;
			}
			get
			{
				return this.receiveAddress;
			}
		}



	}
}