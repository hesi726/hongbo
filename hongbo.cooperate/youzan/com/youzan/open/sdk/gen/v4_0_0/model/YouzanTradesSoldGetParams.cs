using System;
using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v4_0_0.model
{

    //	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    //	using Maps = com.google.common.collect.Maps;

    //	using Multimap = com.google.common.collect.Multimap;

    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanTradesSoldGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 买家id
		/// </summary>
		private long? buyerId;
		/// <summary>
		/// 交易创建结束时间，例:2017-01-01 12:00:00; 开始时间和结束时间的跨度不能大于3个月; 结束时间必须大于开始时间; 开始时间和结束时间必须成对出现
		/// </summary>
		private DateTime endCreated;
		/// <summary>
		/// 交易状态更新的结束时间，例:2017-01-01 12:00:00; 开始时间和结束时间的跨度不能大于3个月; 结束时间必须大于开始时间; 开始时间和结束时间必须成对出现
		/// </summary>
		private DateTime endUpdate;
		/// <summary>
		/// 物流类型搜索
		/// 同城送订单：LOCAL_DELIVERY
		/// 自提订单：SELF_FETCH
		/// 快递配送：EXPRESS
		/// </summary>
		private string expressType;
		/// <summary>
		/// 粉丝id
		/// </summary>
		private long? fansId;
		/// <summary>
		/// 粉丝类型
		/// </summary>
		private long? fansType;
		/// <summary>
		/// 商品id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 门店id
		/// </summary>
		private long? offlineId;
		/// <summary>
		/// 来源
		/// </summary>
		private string orderSource;
		/// <summary>
		/// 页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 收货人昵称
		/// </summary>
		private string receiverName;
		/// <summary>
		/// 收货人手机号
		/// </summary>
		private string receiverPhone;
		/// <summary>
		/// 交易创建的开始时间 例:2017-01-01 12:00:00; 开始时间和结束时间的跨度不能大于3个月; 结束时间必须大于开始时间; 开始时间和结束时间必须成对出现	
		/// </summary>
		private DateTime startCreated;
		/// <summary>
		/// 交易状态更新的开始时间 例:2017-01-01 12:00:00; 开始时间和结束时间的跨度不能大于3个月; 结束时间必须大于开始时间; 开始时间和结束时间必须成对出现
		/// </summary>
		private DateTime startUpdate;
		/// <summary>
		/// 订单状态，一次只能查询一种状态
		/// 待付款：WAIT_BUYER_PAY
		/// 待发货：WAIT_SELLER_SEND_GOODS
		/// 等待买家确认：WAIT_BUYER_CONFIRM_GOODS
		/// 订单完成：TRADE_SUCCESS
		/// 订单关闭：TRADE_CLOSE
		/// 退款中：TRADE_REFUND
		/// </summary>
		private string status;
		/// <summary>
		/// 订单号
		/// </summary>
		private string tid;
		/// <summary>
		/// 订单类型
		/// NORMAL：普通订单
		/// PEERPAY：代付
		/// GIFT：我要送人
		/// FX_CAIGOUDAN：分销采购单
		/// PRESENT：赠品
		/// WISH：心愿单
		/// QRCODE：二维码订单
		/// QRCODE_3RD：线下收银台订单
		/// FX_MERGED：合并付货款
		/// VERIFIED：1分钱实名认证
		/// PINJIAN：品鉴
		/// REBATE：返利
		/// FX_QUANYUANDIAN：全员开店
		/// FX_DEPOSIT：保证金
		/// PF：批发
		/// GROUP：拼团
		/// HOTEL：酒店
		/// TAKE_AWAY：外卖
		/// CATERING_OFFLINE：堂食点餐
		/// CATERING_QRCODE：外卖买单
		/// BEAUTY_APPOINTMENT：美业预约单
		/// BEAUTY_SERVICE：美业服务单
		/// KNOWLEDGE_PAY：知识付费
		/// GIFT_CARD：礼品卡
		/// </summary>
		private string type;

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


		public virtual DateTime EndCreated
		{
			set
			{
				this.endCreated = value;
			}
			get
			{
				return this.endCreated;
			}
		}


		public virtual DateTime EndUpdate
		{
			set
			{
				this.endUpdate = value;
			}
			get
			{
				return this.endUpdate;
			}
		}


		public virtual string ExpressType
		{
			set
			{
				this.expressType = value;
			}
			get
			{
				return this.expressType;
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


		public virtual long? ItemId
		{
			set
			{
				this.itemId = value;
			}
			get
			{
				return this.itemId;
			}
		}


		public virtual long? OfflineId
		{
			set
			{
				this.offlineId = value;
			}
			get
			{
				return this.offlineId;
			}
		}


		public virtual string OrderSource
		{
			set
			{
				this.orderSource = value;
			}
			get
			{
				return this.orderSource;
			}
		}


		public virtual long? PageNo
		{
			set
			{
				this.pageNo = value;
			}
			get
			{
				return this.pageNo;
			}
		}


		public virtual long? PageSize
		{
			set
			{
				this.pageSize = value;
			}
			get
			{
				return this.pageSize;
			}
		}


		public virtual string ReceiverName
		{
			set
			{
				this.receiverName = value;
			}
			get
			{
				return this.receiverName;
			}
		}


		public virtual string ReceiverPhone
		{
			set
			{
				this.receiverPhone = value;
			}
			get
			{
				return this.receiverPhone;
			}
		}


		public virtual DateTime StartCreated
		{
			set
			{
				this.startCreated = value;
			}
			get
			{
				return this.startCreated;
			}
		}


		public virtual DateTime StartUpdate
		{
			set
			{
				this.startUpdate = value;
			}
			get
			{
				return this.startUpdate;
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


		public virtual string Type
		{
			set
			{
				this.type = value;
			}
			get
			{
				return this.type;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (buyerId != null)
			{
				@params["buyer_id"] = buyerId;
			}
			if (endCreated != null)
			{
				@params["end_created"] = endCreated;
			}
			if (endUpdate != null)
			{
				@params["end_update"] = endUpdate;
			}
			if (!string.ReferenceEquals(expressType, null))
			{
				@params["express_type"] = expressType;
			}
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
			}
			if (fansType != null)
			{
				@params["fans_type"] = fansType;
			}
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (offlineId != null)
			{
				@params["offline_id"] = offlineId;
			}
			if (!string.ReferenceEquals(orderSource, null))
			{
				@params["order_source"] = orderSource;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(receiverName, null))
			{
				@params["receiver_name"] = receiverName;
			}
			if (!string.ReferenceEquals(receiverPhone, null))
			{
				@params["receiver_phone"] = receiverPhone;
			}
			if (startCreated != null)
			{
				@params["start_created"] = startCreated;
			}
			if (startUpdate != null)
			{
				@params["start_update"] = startUpdate;
			}
			if (!string.ReferenceEquals(status, null))
			{
				@params["status"] = status;
			}
			if (!string.ReferenceEquals(tid, null))
			{
				@params["tid"] = tid;
			}
			if (!string.ReferenceEquals(type, null))
			{
				@params["type"] = type;
			}
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}