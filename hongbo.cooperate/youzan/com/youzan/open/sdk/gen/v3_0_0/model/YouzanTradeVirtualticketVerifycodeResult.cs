namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeVirtualticketVerifycodeResult : APIResult
	{



		/// <summary>
		/// 是否成功
		/// </summary>
[Newtonsoft.Json.JsonProperty("successful")]//) private Nullable<bool> successful;
		private bool? successful;


		/// <summary>
		/// successful
		/// </summary>
[Newtonsoft.Json.JsonProperty("msg")]//) private String msg;
		private string msg;

		public virtual bool? Successful
		{
			set
			{
				this.successful = value;
			}
			get
			{
				return this.successful;
			}
		}

		public virtual string Msg
		{
			set
			{
				this.msg = value;
			}
			get
			{
				return this.msg;
			}
		}



	}
}