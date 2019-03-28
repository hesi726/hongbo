namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCustomerInfoGetResult : APIResult
	{



		/// <summary>
		/// 会员卡名称
		/// </summary>
[Newtonsoft.Json.JsonProperty("card_name")]//) private String cardName;
		private string cardName;


		/// <summary>
		/// 姓名
		/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
		private string name;


		/// <summary>
		/// 手机号码
		/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
		private string mobile;


		/// <summary>
		/// 粉丝id
		/// </summary>
[Newtonsoft.Json.JsonProperty("fans_id")]//) private Nullable<long> fansId;
		private long? fansId;


		/// <summary>
		/// 粉丝类型
		/// </summary>
[Newtonsoft.Json.JsonProperty("fans_type")]//) private Nullable<long> fansType;
		private long? fansType;


		/// <summary>
		/// 会员卡别名
		/// </summary>
[Newtonsoft.Json.JsonProperty("card_alias")]//) private String cardAlias;
		private string cardAlias;

		public virtual string CardName
		{
			set
			{
				this.cardName = value;
			}
			get
			{
				return this.cardName;
			}
		}

		public virtual string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name;
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

		public virtual long? FansId
		{
			set
			{
				this.fansId = value;
			}
			get
			{
				return this.fansId;
			}
		}

		public virtual long? FansType
		{
			set
			{
				this.fansType = value;
			}
			get
			{
				return this.fansType;
			}
		}

		public virtual string CardAlias
		{
			set
			{
				this.cardAlias = value;
			}
			get
			{
				return this.cardAlias;
			}
		}



	}
}