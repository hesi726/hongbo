using System;
using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanTradesSoldGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 购买方式
		/// </summary>
		private string buyWay;
		/// <summary>
		/// 有赞买家账号ID
		/// </summary>
		private long? buyerId;
		/// <summary>
		/// 买家昵称
		/// </summary>
		private string buyerNick;
		/// <summary>
		/// 交易创建结束时间，例:2017-01-01 12:00:00; 开始时间和结束时间的跨度不能大于3个月; 结束时间必须大于开始时间; 开始时间和结束时间必须成对出现
		/// </summary>
		private DateTime endCreated;
		/// <summary>
		/// 交易状态更新的结束时间，例:2017-01-01 12:00:00; 开始时间和结束时间的跨度不能大于3个月; 结束时间必须大于开始时间; 开始时间和结束时间必须成对出现
		/// 如使用更新时间搜索，则无法与其他检索字段一同使用（除了status, store_id）, 包括type,buy_way,fans_id等检索规则，直接跳过
		/// </summary>
		private DateTime endUpdate;
		/// <summary>
		/// 粉丝ID
		/// </summary>
		private long? fansId;
		/// <summary>
		/// 粉丝类型，店铺微信自有粉丝fans_type=1
		/// </summary>
		private long? fansType;
		/// <summary>
		/// 需要返回的交易对象字段，如tid,title,receiver_city等
		/// </summary>
		private string fields;
		/// <summary>
		/// 搜索关键词，可使用以下信息进行搜索
		/// 1.订单号
		/// 2.收货人手机号
		/// 3.收货人昵称
		/// 4.团编号
		/// </summary>
		private string keyword;
		/// <summary>
		/// 页码，从1开始
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数，最大不能超过100，建议使用默认分页
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// .
		/// </summary>
		private long? senderId;
		/// <summary>
		/// 交易创建的开始时间 例:2017-01-01 12:00:00; 开始时间和结束时间的跨度不能大于3个月; 结束时间必须大于开始时间; 开始时间和结束时间必须成对出现
		/// </summary>
		private DateTime startCreated;
		/// <summary>
		/// 交易状态更新的开始时间 例:2017-01-01 12:00:00; 开始时间和结束时间的跨度不能大于3个月; 结束时间必须大于开始时间; 开始时间和结束时间必须成对出现
		/// 如使用更新时间搜索，则无法与其他检索字段一同使用（除了status, store_id）, 包括type,buy_way,fans_id等检索规则，直接跳过
		/// </summary>
		private DateTime startUpdate;
		/// <summary>
		/// 订单状态，一次只能查询一种状态 待付款：WAIT_BUYER_PAY 待发货：WAIT_SELLER_SEND_GOODS 等待买家确认：WAIT_BUYER_CONFIRM_GOODS 订单完成：TRADE_SUCCESS 订单关闭：TRADE_CLOSE 退款中：TRADE_REFUNDING
		/// </summary>
		private string status;
		/// <summary>
		/// 门店id
		/// </summary>
		private long? storeId;
		/// <summary>
		/// 交易类型。取值范围：
		/// ALL => 所有订单
		/// FEEDBACK => 维权订单
		/// SELF_FETCH => 到店自提订单
		/// COD  => 货到付款订单
		/// PEER_PAY => 代付的订单
		/// GIFT => 送礼的订单
		/// GROUP => 拼团订单
		/// MULTISTORE => 多门店订单
		/// STAR => 加星订单
		/// LOCAL_EXPRESS => 同城配送
		/// QRCODE => 收银台订单
		/// </summary>
		private string type;
		/// <summary>
		/// 是否启用has_next的分页方式
		/// </summary>
		private bool? useHasNext;
		/// <summary>
		/// app版本
		/// </summary>
		private string version;
		/// <summary>
		/// 是否返回子订单
		/// </summary>
		private bool? withChilds;
		/// <summary>
		/// 是否返回订单标记
		/// </summary>
		private bool? withSource;

		public virtual string BuyWay
		{
			set
			{
				this.buyWay = value;
			}
			get
			{
				return this.buyWay;
			}
		}


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


		public virtual string BuyerNick
		{
			set
			{
				this.buyerNick = value;
			}
			get
			{
				return this.buyerNick;
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


		public virtual string Fields
		{
			set
			{
				this.fields = value;
			}
			get
			{
				return this.fields;
			}
		}


		public virtual string Keyword
		{
			set
			{
				this.keyword = value;
			}
			get
			{
				return this.keyword;
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


		public virtual long? SenderId
		{
			set
			{
				this.senderId = value;
			}
			get
			{
				return this.senderId;
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


		public virtual long? StoreId
		{
			set
			{
				this.storeId = value;
			}
			get
			{
				return this.storeId;
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


		public virtual bool? UseHasNext
		{
			set
			{
				this.useHasNext = value;
			}
			get
			{
				return this.useHasNext;
			}
		}


		public virtual string Version
		{
			set
			{
				this.version = value;
			}
			get
			{
				return this.version;
			}
		}


		public virtual bool? WithChilds
		{
			set
			{
				this.withChilds = value;
			}
			get
			{
				return this.withChilds;
			}
		}


		public virtual bool? WithSource
		{
			set
			{
				this.withSource = value;
			}
			get
			{
				return this.withSource;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(buyWay, null))
			{
				@params["buy_way"] = buyWay;
			}
			if (buyerId != null)
			{
				@params["buyer_id"] = buyerId;
			}
			if (!string.ReferenceEquals(buyerNick, null))
			{
				@params["buyer_nick"] = buyerNick;
			}
			if (endCreated != null)
			{
				@params["end_created"] = endCreated;
			}
			if (endUpdate != null)
			{
				@params["end_update"] = endUpdate;
			}
			if (fansId != null)
			{
				@params["fans_id"] = fansId;
			}
			if (fansType != null)
			{
				@params["fans_type"] = fansType;
			}
			if (!string.ReferenceEquals(fields, null))
			{
				@params["fields"] = fields;
			}
			if (!string.ReferenceEquals(keyword, null))
			{
				@params["keyword"] = keyword;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (senderId != null)
			{
				@params["sender_id"] = senderId;
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
			if (storeId != null)
			{
				@params["store_id"] = storeId;
			}
			if (!string.ReferenceEquals(type, null))
			{
				@params["type"] = type;
			}
			if (useHasNext != null)
			{
				@params["use_has_next"] = useHasNext;
			}
			if (!string.ReferenceEquals(version, null))
			{
				@params["version"] = version;
			}
			if (withChilds != null)
			{
				@params["with_childs"] = withChilds;
			}
			if (withSource != null)
			{
				@params["with_source"] = withSource;
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