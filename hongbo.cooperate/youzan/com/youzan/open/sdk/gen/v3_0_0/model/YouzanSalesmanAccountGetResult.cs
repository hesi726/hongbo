namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanSalesmanAccountGetResult : APIResult
	{



		/// <summary>
		/// 手机号
		/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
		private string mobile;


		/// <summary>
		/// 昵称
		/// </summary>
[Newtonsoft.Json.JsonProperty("nickname")]//) private String nickname;
		private string nickname;


		/// <summary>
		/// 标识码
		/// </summary>
[Newtonsoft.Json.JsonProperty("seller")]//) private String seller;
		private string seller;


		/// <summary>
		/// 累计成交笔数
		/// </summary>
[Newtonsoft.Json.JsonProperty("order_num")]//) private Nullable<long> orderNum;
		private long? orderNum;


		/// <summary>
		/// 累计成交金额(元)
		/// </summary>
[Newtonsoft.Json.JsonProperty("money")]//) private String money;
		private string money;


		/// <summary>
		/// 创建时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private String createdAt;
		private string createdAt;


		/// <summary>
		/// 邀请方手机号
		/// </summary>
[Newtonsoft.Json.JsonProperty("from_buyer_mobile")]//) private String fromBuyerMobile;
		private string fromBuyerMobile;


		/// <summary>
		/// 店铺自有粉丝id，绑定认证服务号的店铺才有。
		/// </summary>
[Newtonsoft.Json.JsonProperty("fans_id")]//) private Nullable<long> fansId;
		private long? fansId;

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

		public virtual string Nickname
		{
			set
			{
				this.nickname = value;
			}
			get
			{
				return this.nickname;
			}
		}

		public virtual string Seller
		{
			set
			{
				this.seller = value;
			}
			get
			{
				return this.seller;
			}
		}

		public virtual long? OrderNum
		{
			set
			{
				this.orderNum = value;
			}
			get
			{
				return this.orderNum;
			}
		}

		public virtual string Money
		{
			set
			{
				this.money = value;
			}
			get
			{
				return this.money;
			}
		}

		public virtual string CreatedAt
		{
			set
			{
				this.createdAt = value;
			}
			get
			{
				return this.createdAt;
			}
		}

		public virtual string FromBuyerMobile
		{
			set
			{
				this.fromBuyerMobile = value;
			}
			get
			{
				return this.fromBuyerMobile;
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



	}
}