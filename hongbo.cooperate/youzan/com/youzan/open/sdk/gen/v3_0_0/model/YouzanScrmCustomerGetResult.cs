namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCustomerGetResult : APIResult
	{



		/// <summary>
		/// 姓名
		/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
		private string name;


		/// <summary>
		/// 性别 1:男 2:女 0:未知
		/// </summary>
[Newtonsoft.Json.JsonProperty("gender")]//) private Nullable<long> gender;
		private long? gender;


		/// <summary>
		/// 生日
		/// </summary>
[Newtonsoft.Json.JsonProperty("birthday")]//) private String birthday;
		private string birthday;


		/// <summary>
		/// 地域
		/// </summary>
[Newtonsoft.Json.JsonProperty("area")]//) private String area;
		private string area;


		/// <summary>
		/// 手机号
		/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
		private string mobile;


		/// <summary>
		/// 来源: 0:未知 100:关注公众号 200:普通下单 201:收银台下单 202 : 有赞买家版下单 300:外部导入 301: 开放接口导入 400: 网店客户登记 401: 门店版客户登记 500: 批发客户 600:储值充值客户
		/// </summary>
[Newtonsoft.Json.JsonProperty("source_type")]//) private Nullable<long> sourceType;
		private long? sourceType;


		/// <summary>
		/// 标签，以"，"分隔
		/// </summary>
[Newtonsoft.Json.JsonProperty("tag_names")]//) private String tagNames;
		private string tagNames;


		/// <summary>
		/// 备注
		/// </summary>
[Newtonsoft.Json.JsonProperty("remark")]//) private String remark;
		private string remark;


		/// <summary>
		/// 当前可用积分
		/// </summary>
[Newtonsoft.Json.JsonProperty("current_points")]//) private Nullable<long> currentPoints;
		private long? currentPoints;


		/// <summary>
		/// 购次
		/// </summary>
[Newtonsoft.Json.JsonProperty("trade_count")]//) private Nullable<long> tradeCount;
		private long? tradeCount;


		/// <summary>
		/// 最后购买时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("last_trade_time")]//) private String lastTradeTime;
		private string lastTradeTime;


		/// <summary>
		/// 首次成为会员的时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("first_time")]//) private String firstTime;
		private string firstTime;

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

		public virtual long? Gender
		{
			set
			{
				this.gender = value;
			}
			get
			{
				return this.gender;
			}
		}

		public virtual string Birthday
		{
			set
			{
				this.birthday = value;
			}
			get
			{
				return this.birthday;
			}
		}

		public virtual string Area
		{
			set
			{
				this.area = value;
			}
			get
			{
				return this.area;
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

		public virtual long? SourceType
		{
			set
			{
				this.sourceType = value;
			}
			get
			{
				return this.sourceType;
			}
		}

		public virtual string TagNames
		{
			set
			{
				this.tagNames = value;
			}
			get
			{
				return this.tagNames;
			}
		}

		public virtual string Remark
		{
			set
			{
				this.remark = value;
			}
			get
			{
				return this.remark;
			}
		}

		public virtual long? CurrentPoints
		{
			set
			{
				this.currentPoints = value;
			}
			get
			{
				return this.currentPoints;
			}
		}

		public virtual long? TradeCount
		{
			set
			{
				this.tradeCount = value;
			}
			get
			{
				return this.tradeCount;
			}
		}

		public virtual string LastTradeTime
		{
			set
			{
				this.lastTradeTime = value;
			}
			get
			{
				return this.lastTradeTime;
			}
		}

		public virtual string FirstTime
		{
			set
			{
				this.firstTime = value;
			}
			get
			{
				return this.firstTime;
			}
		}



	}
}