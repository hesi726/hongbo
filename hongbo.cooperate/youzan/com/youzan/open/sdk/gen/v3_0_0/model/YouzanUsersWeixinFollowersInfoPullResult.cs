namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUsersWeixinFollowersInfoPullResult : APIResult
	{



		/// <summary>
		/// 搜索到的微信粉丝用户详细信息列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("users")]//) private WeixinFansCustomerInfo[] users;
		private WeixinFansCustomerInfo[] users;


		/// <summary>
		/// 是否有下一页数据
		/// </summary>
[Newtonsoft.Json.JsonProperty("has_next")]//) private Nullable<bool> hasNext;
		private bool? hasNext;


		/// <summary>
		/// 当前列表中最后一个粉丝编码
		/// </summary>
[Newtonsoft.Json.JsonProperty("last_fans_id")]//) private Nullable<long> lastFansId;
		private long? lastFansId;

		public virtual WeixinFansCustomerInfo[] Users
		{
			set
			{
				this.users = value;
			}
			get
			{
				return this.users;
			}
		}

		public virtual bool? HasNext
		{
			set
			{
				this.hasNext = value;
			}
			get
			{
				return this.hasNext;
			}
		}

		public virtual long? LastFansId
		{
			set
			{
				this.lastFansId = value;
			}
			get
			{
				return this.lastFansId;
			}
		}


		public class WeixinFansCustomerInfo
		{


			/// <summary>
			/// 微信粉丝用户ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("user_id")]//) private Nullable<long> userId;
				internal long? userId;


			/// <summary>
			/// 微信粉丝用户的openid，可用于微信Api
			/// </summary>
[Newtonsoft.Json.JsonProperty("weixin_open_id")]//) private String weixinOpenId;
				internal string weixinOpenId;


			/// <summary>
			/// 微信粉丝用户的昵称
			/// </summary>
[Newtonsoft.Json.JsonProperty("nick")]//) private String nick;
				internal string nick;


			/// <summary>
			/// 微信粉丝用户的头像Url
			/// </summary>
[Newtonsoft.Json.JsonProperty("avatar")]//) private String avatar;
				internal string avatar;


			/// <summary>
			/// 关注时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("follow_time")]//) private Nullable<long> followTime;
				internal long? followTime;


			/// <summary>
			/// 性别。可选值：m(男)，f(女)。未知则为空
			/// </summary>
[Newtonsoft.Json.JsonProperty("sex")]//) private String sex;
				internal string sex;


			/// <summary>
			/// 所在城市
			/// </summary>
[Newtonsoft.Json.JsonProperty("city")]//) private String city;
				internal string city;


			/// <summary>
			/// 所在身份
			/// </summary>
[Newtonsoft.Json.JsonProperty("province")]//) private String province;
				internal string province;


			/// <summary>
			/// 所在国家
			/// </summary>
[Newtonsoft.Json.JsonProperty("country")]//) private String country;
				internal string country;


			/// <summary>
			/// 当前积分（当入参fields字段传入"points"枚举值才会返回该字段。）
			/// </summary>
[Newtonsoft.Json.JsonProperty("points")]//) private Nullable<long> points;
				internal long? points;


			/// <summary>
			/// 成交订单笔数（当入参fields字段传入"trade"枚举值才会返回该字段。）
			/// </summary>
[Newtonsoft.Json.JsonProperty("traded_num")]//) private Nullable<long> tradedNum;
				internal long? tradedNum;


			/// <summary>
			/// 成交订单总额。单位：元。（当入参fields字段传入"trade"枚举值才会返回该字段。）
			/// </summary>
[Newtonsoft.Json.JsonProperty("trade_money")]//) private Nullable<float> tradeMoney;
				internal float? tradeMoney;


			/// <summary>
			/// 粉丝会员等级的数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("level_info")]//) private CrmFansLevel levelInfo;
				internal CrmFansLevel levelInfo;


			/// <summary>
			/// 是否关注
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_follow")]//) private Nullable<bool> isFollow;
				internal bool? isFollow;

				public virtual long? UserId
				{
					set
					{
					this.userId = value;
					}
					get
					{
					return this.userId;
					}
				}


				public virtual string WeixinOpenId
				{
					set
					{
					this.weixinOpenId = value;
					}
					get
					{
					return this.weixinOpenId;
					}
				}


				public virtual string Nick
				{
					set
					{
					this.nick = value;
					}
					get
					{
					return this.nick;
					}
				}


				public virtual string Avatar
				{
					set
					{
					this.avatar = value;
					}
					get
					{
					return this.avatar;
					}
				}


				public virtual long? FollowTime
				{
					set
					{
					this.followTime = value;
					}
					get
					{
					return this.followTime;
					}
				}


				public virtual string Sex
				{
					set
					{
					this.sex = value;
					}
					get
					{
					return this.sex;
					}
				}


				public virtual string City
				{
					set
					{
					this.city = value;
					}
					get
					{
					return this.city;
					}
				}


				public virtual string Province
				{
					set
					{
					this.province = value;
					}
					get
					{
					return this.province;
					}
				}


				public virtual string Country
				{
					set
					{
					this.country = value;
					}
					get
					{
					return this.country;
					}
				}


				public virtual long? Points
				{
					set
					{
					this.points = value;
					}
					get
					{
					return this.points;
					}
				}


				public virtual long? TradedNum
				{
					set
					{
					this.tradedNum = value;
					}
					get
					{
					return this.tradedNum;
					}
				}


				public virtual float? TradeMoney
				{
					set
					{
					this.tradeMoney = value;
					}
					get
					{
					return this.tradeMoney;
					}
				}


				public virtual CrmFansLevel LevelInfo
				{
					set
					{
					this.levelInfo = value;
					}
					get
					{
					return this.levelInfo;
					}
				}


				public virtual bool? IsFollow
				{
					set
					{
					this.isFollow = value;
					}
					get
					{
					return this.isFollow;
					}
				}


		}

		public class CrmFansLevel
		{


			/// <summary>
			/// 会员等级编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("level_id")]//) private Nullable<long> levelId;
				internal long? levelId;


			/// <summary>
			/// 会员等级名
			/// </summary>
[Newtonsoft.Json.JsonProperty("level_name")]//) private String levelName;
				internal string levelName;

				public virtual long? LevelId
				{
					set
					{
					this.levelId = value;
					}
					get
					{
					return this.levelId;
					}
				}


				public virtual string LevelName
				{
					set
					{
					this.levelName = value;
					}
					get
					{
					return this.levelName;
					}
				}


		}


	}
}