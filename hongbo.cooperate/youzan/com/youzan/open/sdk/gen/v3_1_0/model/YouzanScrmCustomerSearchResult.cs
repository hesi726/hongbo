namespace com.youzan.open.sdk.gen.v3_1_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;

    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanScrmCustomerSearchResult : APIResult
	{



		/// <summary>
		/// 列表总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<long> total;
		private long? total;


		/// <summary>
		/// 客户列表返回对象列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("record_list")]//) private CustomerResultDTO[] recordList;
		private CustomerResultDTO[] recordList;

		public virtual long? Total
		{
			set
			{
				this.total = value;
			}
			get
			{
				return this.total;
			}
		}

		public virtual CustomerResultDTO[] RecordList
		{
			set
			{
				this.recordList = value;
			}
			get
			{
				return this.recordList;
			}
		}


		public class CustomerResultDTO
		{


			/// <summary>
			/// 姓名
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 性别
			/// </summary>
[Newtonsoft.Json.JsonProperty("gender")]//) private Nullable<long> gender;
				internal long? gender;


			/// <summary>
			/// 用户ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("yz_uid")]//) private Nullable<long> yzUid;
				internal long? yzUid;


			/// <summary>
			/// 手机号
			/// </summary>
[Newtonsoft.Json.JsonProperty("mobile")]//) private String mobile;
				internal string mobile;


			/// <summary>
			/// 粉丝ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("weixin_fans_id")]//) private Nullable<long> weixinFansId;
				internal long? weixinFansId;


			/// <summary>
			/// 是否是会员
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_member")]//) private Nullable<long> isMember;
				internal long? isMember;


			/// <summary>
			/// 购次
			/// </summary>
[Newtonsoft.Json.JsonProperty("trade_count")]//) private Nullable<long> tradeCount;
				internal long? tradeCount;


			/// <summary>
			/// 积分
			/// </summary>
[Newtonsoft.Json.JsonProperty("points")]//) private Nullable<long> points;
				internal long? points;


			/// <summary>
			/// 会员卡ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("card_ids")]//) private string[] cardIds;
				internal string[] cardIds;


			/// <summary>
			/// 成为客户的时间，时间戳格式，单位秒
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_at")]//) private Nullable<long> createdAt;
				internal long? createdAt;


			/// <summary>
			/// 成为会员的时间，时间戳格式，单位秒
			/// </summary>
[Newtonsoft.Json.JsonProperty("member_created_at")]//) private Nullable<long> memberCreatedAt;
				internal long? memberCreatedAt;

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


				public virtual long? YzUid
				{
					set
					{
					this.yzUid = value;
					}
					get
					{
					return this.yzUid;
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


				public virtual long? WeixinFansId
				{
					set
					{
					this.weixinFansId = value;
					}
					get
					{
					return this.weixinFansId;
					}
				}


				public virtual long? IsMember
				{
					set
					{
					this.isMember = value;
					}
					get
					{
					return this.isMember;
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


				public virtual string[] CardIds
				{
					set
					{
					this.cardIds = value;
					}
					get
					{
					return this.cardIds;
					}
				}


				public virtual long? CreatedAt
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


				public virtual long? MemberCreatedAt
				{
					set
					{
					this.memberCreatedAt = value;
					}
					get
					{
					return this.memberCreatedAt;
					}
				}


		}


	}
}