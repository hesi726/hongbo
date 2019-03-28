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

    public class YouzanPayQrcodesGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 是否不返回二维码图片，1即不返回qr_code数据
		/// </summary>
		private string ignoreQrcode;
		/// <summary>
		/// 标签 json格式字符串,例如:[1,2],表示有两个标签
		/// </summary>
		private string labelIds;
		/// <summary>
		/// 当前页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 二维码类型，不指定类型则全部返回
		/// </summary>
		private string qrType;
		/// <summary>
		/// 网点编号
		/// </summary>
		private string shopId;
		/// <summary>
		/// 网点类型
		/// </summary>
		private string shopType;

		public virtual string IgnoreQrcode
		{
			set
			{
				this.ignoreQrcode = value;
			}
			get
			{
				return this.ignoreQrcode;
			}
		}


		public virtual string LabelIds
		{
			set
			{
				this.labelIds = value;
			}
			get
			{
				return this.labelIds;
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


		public virtual string QrType
		{
			set
			{
				this.qrType = value;
			}
			get
			{
				return this.qrType;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(ignoreQrcode, null))
			{
				@params["ignore_qrcode"] = ignoreQrcode;
			}
			if (!string.ReferenceEquals(labelIds, null))
			{
				@params["label_ids"] = labelIds;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(qrType, null))
			{
				@params["qr_type"] = qrType;
			}
			if (!string.ReferenceEquals(shopId, null))
			{
				@params["shop_id"] = shopId;
			}
			if (!string.ReferenceEquals(shopType, null))
			{
				@params["shop_type"] = shopType;
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