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

    public class YouzanTradeQrcodeExtCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 外部订单号（不超过30个字符）
		/// </summary>
		private string outId;
		/// <summary>
		/// 外部来源（由有赞分配）
		/// </summary>
		private string outSource;
		/// <summary>
		/// 二维码名称
		/// </summary>
		private string qrName;
		/// <summary>
		/// 分为单位
		/// </summary>
		private long? qrPrice;
		/// <summary>
		/// 网点编号
		/// </summary>
		private string shopId;
		/// <summary>
		/// 网点类型
		/// </summary>
		private string shopType;

		public virtual string OutId
		{
			set
			{
				this.outId = value;
			}
			get
			{
				return this.outId;
			}
		}


		public virtual string OutSource
		{
			set
			{
				this.outSource = value;
			}
			get
			{
				return this.outSource;
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


		public virtual long? QrPrice
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
			if (!string.ReferenceEquals(outId, null))
			{
				@params["out_id"] = outId;
			}
			if (!string.ReferenceEquals(outSource, null))
			{
				@params["out_source"] = outSource;
			}
			if (!string.ReferenceEquals(qrName, null))
			{
				@params["qr_name"] = qrName;
			}
			if (qrPrice != null)
			{
				@params["qr_price"] = qrPrice;
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