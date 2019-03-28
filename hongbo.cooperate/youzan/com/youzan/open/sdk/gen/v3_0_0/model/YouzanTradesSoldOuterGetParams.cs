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

    public class YouzanTradesSoldOuterGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 交易创建结束时间
		/// </summary>
		private DateTime endCreated;
		/// <summary>
		/// 交易状态更新的结束时间
		/// </summary>
		private DateTime endUpdate;
		/// <summary>
		/// 需要返回的交易对象字段
		/// </summary>
		private string fields;
		/// <summary>
		/// 三方用户ua
		/// </summary>
		private string outerType;
		/// <summary>
		/// 三方用户user_id
		/// </summary>
		private string outerUserId;
		/// <summary>
		/// 页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 交易创建开始时间
		/// </summary>
		private DateTime startCreated;
		/// <summary>
		/// 交易状态更新的开始时间
		/// </summary>
		private DateTime startUpdate;
		/// <summary>
		/// 交易状态 ，默认查询所有交易状态的数据，除了默认值外每次只能查询一种状态。 可选值： TRADE_NO_CREATE_PAY（没有创建支付交易） WAIT_BUYER_PAY（等待买家付款） WAIT_GROUP（等待成团，即：买家已付款，等待成团） WAIT_SELLER_SEND_GOODS（等待卖家发货，即：买家已付款） WAIT_BUYER_CONFIRM_GOODS（等待买家确认收货，即：卖家已发货） TRADE_BUYER_SIGNED（买家已签收） TRADE_CLOSED（付款以后用户退款成功，交易自动关闭） ALL_WAIT_PAY（包含：WAIT_BUYER_PAY、TRADE_NO_CREATE_PAY） ALL_CLOSED（所有关闭订单）
		/// </summary>
		private string status;
		/// <summary>
		/// 订单类型 ，默认查询所有交易状态的数据，除了默认值外每次只能查询一种状态。 可选值： FIXED （一口价） GIFT （送礼） BULK_PURCHASE（来自分销商的采购） PRESENT （赠品领取） GROUP （拼团订单） COD （货到付款） PEER （代付） QRCODE（扫码商家二维码直接支付的交易）
		/// </summary>
		private string type;
		/// <summary>
		/// 是否启用has_next的分页方式
		/// </summary>
		private bool? useHasNext;

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


		public virtual string OuterType
		{
			set
			{
				this.outerType = value;
			}
			get
			{
				return this.outerType;
			}
		}


		public virtual string OuterUserId
		{
			set
			{
				this.outerUserId = value;
			}
			get
			{
				return this.outerUserId;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (endCreated != null)
			{
				@params["end_created"] = endCreated;
			}
			if (endUpdate != null)
			{
				@params["end_update"] = endUpdate;
			}
			if (!string.ReferenceEquals(fields, null))
			{
				@params["fields"] = fields;
			}
			if (!string.ReferenceEquals(outerType, null))
			{
				@params["outer_type"] = outerType;
			}
			if (!string.ReferenceEquals(outerUserId, null))
			{
				@params["outer_user_id"] = outerUserId;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
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
			if (!string.ReferenceEquals(type, null))
			{
				@params["type"] = type;
			}
			if (useHasNext != null)
			{
				@params["use_has_next"] = useHasNext;
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