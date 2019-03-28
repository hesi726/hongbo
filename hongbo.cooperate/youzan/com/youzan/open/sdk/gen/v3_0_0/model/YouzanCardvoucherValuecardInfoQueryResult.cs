namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanCardvoucherValuecardInfoQueryResult : APIResult
	{



		/// <summary>
		/// buyer_id
		/// </summary>
[Newtonsoft.Json.JsonProperty("buyer_id")]//) private Nullable<long> buyerId;
		private long? buyerId;


		/// <summary>
		/// 卡号
		/// </summary>
[Newtonsoft.Json.JsonProperty("card_no")]//) private String cardNo;
		private string cardNo;


		/// <summary>
		/// 赠送金余额
		/// </summary>
[Newtonsoft.Json.JsonProperty("bonus_denomination")]//) private Nullable<long> bonusDenomination;
		private long? bonusDenomination;


		/// <summary>
		/// 手机号码
		/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
		private string mobile;


		/// <summary>
		/// 本金余额
		/// </summary>
[Newtonsoft.Json.JsonProperty("principal_denomination")]//) private Nullable<long> principalDenomination;
		private long? principalDenomination;


		/// <summary>
		/// 总余额
		/// </summary>
[Newtonsoft.Json.JsonProperty("denomination")]//) private Nullable<long> denomination;
		private long? denomination;


		/// <summary>
		/// 发卡店铺号
		/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
		private long? kdtId;

		public virtual long? BuyerId
		{
			set
			{
				this.buyerId = value;
			}
			get
			{
				return this.buyerId;
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

		public virtual long? BonusDenomination
		{
			set
			{
				this.bonusDenomination = value;
			}
			get
			{
				return this.bonusDenomination;
			}
		}

		public virtual string Mobile
		{
			set
			{
				this.mobile = value;
			}
			get
			{
				return this.mobile;
			}
		}

		public virtual long? PrincipalDenomination
		{
			set
			{
				this.principalDenomination = value;
			}
			get
			{
				return this.principalDenomination;
			}
		}

		public virtual long? Denomination
		{
			set
			{
				this.denomination = value;
			}
			get
			{
				return this.denomination;
			}
		}

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



	}
}