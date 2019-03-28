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

    public class YouzanTradesQrGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 交易创建结束时间
		/// </summary>
		private DateTime endCreated;
		/// <summary>
		/// 需要返回的交易对象字段，如tid,qr_url,qr_name等
		/// </summary>
		private string fields;
		/// <summary>
		/// 页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 二维码编号
		/// </summary>
		private string qrId;
		/// <summary>
		/// 网点编号
		/// </summary>
		private string shopId;
		/// <summary>
		/// 网点类型
		/// </summary>
		private string shopType;
		/// <summary>
		/// 交易创建开始时间
		/// </summary>
		private DateTime startCreated;
		/// <summary>
		/// 状态
		/// </summary>
		private string status;

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


		public virtual string QrId
		{
			set
			{
				this.qrId = value;
			}
			get
			{
				return this.qrId;
			}
		}


		public virtual string ShopId
		{
			set
			{
				this.shopId = value;
			}
			get
			{
				return this.shopId;
			}
		}


		public virtual string ShopType
		{
			set
			{
				this.shopType = value;
			}
			get
			{
				return this.shopType;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (endCreated != null)
			{
				@params["end_created"] = endCreated;
			}
			if (!string.ReferenceEquals(fields, null))
			{
				@params["fields"] = fields;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(qrId, null))
			{
				@params["qr_id"] = qrId;
			}
			if (!string.ReferenceEquals(shopId, null))
			{
				@params["shop_id"] = shopId;
			}
			if (!string.ReferenceEquals(shopType, null))
			{
				@params["shop_type"] = shopType;
			}
			if (startCreated != null)
			{
				@params["start_created"] = startCreated;
			}
			if (!string.ReferenceEquals(status, null))
			{
				@params["status"] = status;
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