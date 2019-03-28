namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanLogisticsExpressbyordernoSearchResult : APIResult
	{



		/// <summary>
		/// 物流详情列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("orderExpressList")]//) private LogisticsGoodsOrderExpressModel[] orderExpressList;
		private LogisticsGoodsOrderExpressModel[] orderExpressList;

		public virtual LogisticsGoodsOrderExpressModel[] OrderExpressList
		{
			set
			{
				this.orderExpressList = value;
			}
			get
			{
				return this.orderExpressList;
			}
		}


		public class LogisticsGoodsOrderExpressModel
		{


			/// <summary>
			/// id
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 物流单号
			/// </summary>
[Newtonsoft.Json.JsonProperty("nu")]//) private String nu;
				internal string nu;


			/// <summary>
			/// 物流公司编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("com")]//) private String com;
				internal string com;


			/// <summary>
			/// 无意义，请忽略
			/// </summary>
[Newtonsoft.Json.JsonProperty("message")]//) private String message;
				internal string message;


			/// <summary>
			/// 无意义，请忽略
			/// </summary>
[Newtonsoft.Json.JsonProperty("ep_condition")]//) private String epCondition;
				internal string epCondition;


			/// <summary>
			/// 查询结果状态
			/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private String status;
				internal string status;


			/// <summary>
			/// 0：在途 1：揽件 2：疑难 3：签收 4：退签 5：派件 6：退回
			/// </summary>
[Newtonsoft.Json.JsonProperty("state")]//) private Nullable<long> state;
				internal long? state;


			/// <summary>
			/// 投递的数据
			/// </summary>
[Newtonsoft.Json.JsonProperty("data")]//) private String data;
				internal string data;


			/// <summary>
			/// 每条跟踪信息的时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_time")]//) private Nullable<long> createdTime;
				internal long? createdTime;


			/// <summary>
			/// 物流id
			/// </summary>
[Newtonsoft.Json.JsonProperty("express_id")]//) private Nullable<long> expressId;
				internal long? expressId;

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


				public virtual string Nu
				{
					set
					{
					this.nu = value;
					}
					get
					{
					return this.nu;
					}
				}


				public virtual string Com
				{
					set
					{
					this.com = value;
					}
					get
					{
					return this.com;
					}
				}


				public virtual string Message
				{
					set
					{
					this.message = value;
					}
					get
					{
					return this.message;
					}
				}


				public virtual string EpCondition
				{
					set
					{
					this.epCondition = value;
					}
					get
					{
					return this.epCondition;
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


				public virtual long? State
				{
					set
					{
					this.state = value;
					}
					get
					{
					return this.state;
					}
				}


				public virtual string Data
				{
					set
					{
					this.data = value;
					}
					get
					{
					return this.data;
					}
				}


				public virtual long? CreatedTime
				{
					set
					{
					this.createdTime = value;
					}
					get
					{
					return this.createdTime;
					}
				}


				public virtual long? ExpressId
				{
					set
					{
					this.expressId = value;
					}
					get
					{
					return this.expressId;
					}
				}


		}


	}
}