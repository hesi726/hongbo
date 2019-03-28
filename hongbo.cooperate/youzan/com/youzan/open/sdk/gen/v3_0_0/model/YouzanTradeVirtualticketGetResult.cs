namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeVirtualticketGetResult : APIResult
	{



		/// <summary>
		/// 电子卡券二维码码号
		/// </summary>
[Newtonsoft.Json.JsonProperty("code")]//) private String code;
		private string code;


		/// <summary>
		/// 订单号
		/// </summary>
[Newtonsoft.Json.JsonProperty("tid")]//) private String tid;
		private string tid;


		/// <summary>
		/// 核销状态: NOT_VERIFY（未核销）VERIFIED（已核销）
		/// </summary>
[Newtonsoft.Json.JsonProperty("state")]//) private String state;
		private string state;


		/// <summary>
		/// 创建时间
		/// </summary>
[Newtonsoft.Json.JsonProperty("create_time")]//) private String createTime;
		private string createTime;


		/// <summary>
		/// 码券核销信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("tickets")]//) private VirtualTicket[] tickets;
		private VirtualTicket[] tickets;

		public virtual string Code
		{
			set
			{
				this.code = value;
			}
			get
			{
				return this.code;
			}
		}

		public virtual string Tid
		{
			set
			{
				this.tid = value;
			}
			get
			{
				return this.tid;
			}
		}

		public virtual string State
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

		public virtual string CreateTime
		{
			set
			{
				this.createTime = value;
			}
			get
			{
				return this.createTime;
			}
		}

		public virtual VirtualTicket[] Tickets
		{
			set
			{
				this.tickets = value;
			}
			get
			{
				return this.tickets;
			}
		}


		public class VirtualTicket
		{


			/// <summary>
			/// 是否核销
			/// </summary>
[Newtonsoft.Json.JsonProperty("ticket_state")]//) private String ticketState;
				internal string ticketState;


			/// <summary>
			/// 码券号
			/// </summary>
[Newtonsoft.Json.JsonProperty("ticket_code")]//) private String ticketCode;
				internal string ticketCode;


			/// <summary>
			/// 核销时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("verify_time")]//) private String verifyTime;
				internal string verifyTime;

				public virtual string TicketState
				{
					set
					{
					this.ticketState = value;
					}
					get
					{
					return this.ticketState;
					}
				}


				public virtual string TicketCode
				{
					set
					{
					this.ticketCode = value;
					}
					get
					{
					return this.ticketCode;
					}
				}


				public virtual string VerifyTime
				{
					set
					{
					this.verifyTime = value;
					}
					get
					{
					return this.verifyTime;
					}
				}


		}


	}
}