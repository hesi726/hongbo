using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUsersWeixinFollowerGetResult : APIResult
	{



		/// <summary>
		/// 微信粉丝用户信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("user")]//) private CrmWeixinFans user;
		private CrmWeixinFans user;

		public virtual CrmWeixinFans User
		{
			set
			{
				this.user = value;
			}
			get
			{
				return this.user;
			}
		}


		public class CrmUserTag
		{


			/// <summary>
			/// 标签ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 标签名
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;

				public virtual long? Id
				{
					set
					{
					this.id = value;
					}
					get
					{
					return this.id;
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

		public class CrmWeixinFans
		{


			/// <summary>
			/// 微信粉丝用户ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("user_id")]//) private Nullable<long> userId;
				internal long? userId;


			/// <summary>
			/// 微信粉丝用户的openid，可用于微信Api
			/// </summary>
[Newtonsoft.Json.JsonProperty("weixin_openid")]//) private String weixinOpenid;
				internal string weixinOpenid;


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
[Newtonsoft.Json.JsonProperty("follow_time")]//) private java.util.Date followTime;
				internal DateTime followTime;


			/// <summary>
			/// 性别。可选值：m(男)，f(女)。未知则为空
			/// </summary>
[Newtonsoft.Json.JsonProperty("sex")]//) private String sex;
				internal string sex;


			/// <summary>
			/// 所在身份
			/// </summary>
[Newtonsoft.Json.JsonProperty("province")]//) private String province;
				internal string province;


			/// <summary>
			/// 所在城市
			/// </summary>
[Newtonsoft.Json.JsonProperty("city")]//) private String city;
				internal string city;


			/// <summary>
			/// 当前积分
			/// </summary>
[Newtonsoft.Json.JsonProperty("points")]//) private Nullable<long> points;
				internal long? points;


			/// <summary>
			/// 成交订单笔数
			/// </summary>
[Newtonsoft.Json.JsonProperty("traded_num")]//) private Nullable<long> tradedNum;
				internal long? tradedNum;


			/// <summary>
			/// 成交订单总额。单位：元
			/// </summary>
[Newtonsoft.Json.JsonProperty("traded_money")]//) private Nullable<float> tradedMoney;
				internal float? tradedMoney;


			/// <summary>
			/// 用户标签
			/// </summary>
[Newtonsoft.Json.JsonProperty("tags")]//) private CrmUserTag[] tags;
				internal CrmUserTag[] tags;


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


			/// <summary>
			/// 微信粉丝用户的unionid，可用于微信Api
			/// </summary>
[Newtonsoft.Json.JsonProperty("union_id")]//) private String unionId;
				internal string unionId;

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


				public virtual string WeixinOpenid
				{
					set
					{
					this.weixinOpenid = value;
					}
					get
					{
					return this.weixinOpenid;
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


				public virtual DateTime FollowTime
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


				public virtual float? TradedMoney
				{
					set
					{
					this.tradedMoney = value;
					}
					get
					{
					return this.tradedMoney;
					}
				}


				public virtual CrmUserTag[] Tags
				{
					set
					{
					this.tags = value;
					}
					get
					{
					return this.tags;
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


				public virtual string UnionId
				{
					set
					{
					this.unionId = value;
					}
					get
					{
					return this.unionId;
					}
				}


		}


	}
}