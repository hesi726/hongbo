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

    public class YouzanPayQrcodeCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 标签 json格式字符串,例如:[1,2],表示有两个标签
		/// </summary>
		private string labelIds;
		/// <summary>
		/// 收款理由
		/// </summary>
		private string qrName;
		/// <summary>
		/// 价格（单位 分）。qr_type 为 QR_TYPE_FIXED 时，价格可为空。
		/// 
		/// </summary>
		private string qrPrice;
		/// <summary>
		/// 二维码创建类型标记
		/// </summary>
		private string qrSource;
		/// <summary>
		/// 二维码类型.
		/// QR_TYPE_FIXED_BY_PERSON ：无金额二维码，扫码后用户需自己输入金额；
		/// QR_TYPE_NOLIMIT ： 确定金额二维码，可以重复支付;
		/// QR_TYPE_DYNAMIC：确定金额二维码，只能被支付一次
		/// </summary>
		private string qrType;

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


		public virtual string QrName
		{
			set
			{
				this.qrName = value;
			}
			get
			{
				return this.qrName;
			}
		}


		public virtual string QrPrice
		{
			set
			{
				this.qrPrice = value;
			}
			get
			{
				return this.qrPrice;
			}
		}


		public virtual string QrSource
		{
			set
			{
				this.qrSource = value;
			}
			get
			{
				return this.qrSource;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(labelIds, null))
			{
				@params["label_ids"] = labelIds;
			}
			if (!string.ReferenceEquals(qrName, null))
			{
				@params["qr_name"] = qrName;
			}
			if (!string.ReferenceEquals(qrPrice, null))
			{
				@params["qr_price"] = qrPrice;
			}
			if (!string.ReferenceEquals(qrSource, null))
			{
				@params["qr_source"] = qrSource;
			}
			if (!string.ReferenceEquals(qrType, null))
			{
				@params["qr_type"] = qrType;
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