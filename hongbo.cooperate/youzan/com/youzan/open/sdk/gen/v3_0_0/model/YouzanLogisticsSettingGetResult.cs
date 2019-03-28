namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanLogisticsSettingGetResult : APIResult
	{



		/// <summary>
		/// 店铺Id
		/// </summary>
[Newtonsoft.Json.JsonProperty("kdtId")]//) private Nullable<long> kdtId;
		private long? kdtId;


		/// <summary>
		/// 门店id
		/// </summary>
[Newtonsoft.Json.JsonProperty("offlineId")]//) private Nullable<long> offlineId;
		private long? offlineId;


		/// <summary>
		/// 是否支持同城定时达
		/// </summary>
[Newtonsoft.Json.JsonProperty("isLocalInTime")]//) private Nullable<bool> isLocalInTime;
		private bool? isLocalInTime;


		/// <summary>
		/// 是否支持快递
		/// </summary>
[Newtonsoft.Json.JsonProperty("isExpress")]//) private Nullable<bool> isExpress;
		private bool? isExpress;


		/// <summary>
		/// 是否支持自提
		/// </summary>
[Newtonsoft.Json.JsonProperty("isSelf")]//) private Nullable<bool> isSelf;
		private bool? isSelf;


		/// <summary>
		/// 是否支持同城
		/// </summary>
[Newtonsoft.Json.JsonProperty("isLocal")]//) private Nullable<bool> isLocal;
		private bool? isLocal;

		public virtual long? KdtId
		{
			set
			{
				this.kdtId = value;
			}
			get
			{
				return this.kdtId;
			}
		}

		public virtual long? OfflineId
		{
			set
			{
				this.offlineId = value;
			}
			get
			{
				return this.offlineId;
			}
		}

		public virtual bool? IsLocalInTime
		{
			set
			{
				this.isLocalInTime = value;
			}
			get
			{
				return this.isLocalInTime;
			}
		}

		public virtual bool? IsExpress
		{
			set
			{
				this.isExpress = value;
			}
			get
			{
				return this.isExpress;
			}
		}

		public virtual bool? IsSelf
		{
			set
			{
				this.isSelf = value;
			}
			get
			{
				return this.isSelf;
			}
		}

		public virtual bool? IsLocal
		{
			set
			{
				this.isLocal = value;
			}
			get
			{
				return this.isLocal;
			}
		}



	}
}