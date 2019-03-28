namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanLogisticsGoodsexpressGetResult : APIResult
	{



		/// <summary>
		/// 物流公司编号
		/// </summary>
[Newtonsoft.Json.JsonProperty("com")]//) private String com;
		private string com;


		/// <summary>
		/// 每条跟踪信息的时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("created_time")]//) private Nullable<long> createdTime;
		private long? createdTime;


		/// <summary>
		/// 物流id
		/// </summary>
[Newtonsoft.Json.JsonProperty("express_id")]//) private Nullable<long> expressId;
		private long? expressId;


		/// <summary>
		/// 店铺Id
		/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
		private long? kdtId;


		/// <summary>
		/// 投递的数据
		/// </summary>
[Newtonsoft.Json.JsonProperty("data")]//) private String data;
		private string data;


		/// <summary>
		/// 物流单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("nu")]//) private String nu;
		private string nu;


		/// <summary>
		/// 条件
		/// </summary>
[Newtonsoft.Json.JsonProperty("ep_condition")]//) private String epCondition;
		private string epCondition;


		/// <summary>
		/// 编号id
		/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
		private long? id;


		/// <summary>
		/// 0：在途 1：揽件 2：疑难 3：签收 4：退签 5：派件 6：退回
		/// </summary>
[Newtonsoft.Json.JsonProperty("state")]//) private Nullable<long> state;
		private long? state;


		/// <summary>
		/// 信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("message")]//) private String message;
		private string message;


		/// <summary>
		/// 订单id
		/// </summary>
[Newtonsoft.Json.JsonProperty("order_id")]//) private Nullable<long> orderId;
		private long? orderId;


		/// <summary>
		/// 查询结果状态:0：物流单暂无结果，1：查询成功，2：接口出现异常
		/// </summary>
[Newtonsoft.Json.JsonProperty("status")]//) private String status;
		private string status;

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

		public virtual long? OrderId
		{
			set
			{
				this.orderId = value;
			}
			get
			{
				return this.orderId;
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



	}
}