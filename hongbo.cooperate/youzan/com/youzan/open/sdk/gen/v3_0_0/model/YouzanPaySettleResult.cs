namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanPaySettleResult : APIResult
	{



		/// <summary>
		/// 收单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("acquire_no")]//) private String acquireNo;
		private string acquireNo;


		/// <summary>
		/// 外部订单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("out_biz_no")]//) private String outBizNo;
		private string outBizNo;


		/// <summary>
		/// 结果状态:
		/// SUCCESS:成功
		/// FAIL:失败
		/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private String status;
		private string status;


		/// <summary>
		/// 扩展字段，kv格式
		/// </summary>
[Newtonsoft.Json.JsonProperty("extend_info")]//) private String extendInfo;
		private string extendInfo;

		public virtual string AcquireNo
		{
			set
			{
				this.acquireNo = value;
			}
			get
			{
				return this.acquireNo;
			}
		}

		public virtual string OutBizNo
		{
			set
			{
				this.outBizNo = value;
			}
			get
			{
				return this.outBizNo;
			}
		}

		public virtual string Status
		{
			set
			{
				this.status = value;
			}
			get
			{
				return this.status;
			}
		}

		public virtual string ExtendInfo
		{
			set
			{
				this.extendInfo = value;
			}
			get
			{
				return this.extendInfo;
			}
		}



	}
}