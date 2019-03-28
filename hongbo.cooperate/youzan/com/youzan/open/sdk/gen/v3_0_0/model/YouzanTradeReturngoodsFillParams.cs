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

    public class YouzanTradeReturngoodsFillParams : APIParams, FileParams
	{

		/// <summary>
		/// 物流公司编号: 查询youzan.logistics.express.get接口获取
		/// </summary>
		private long? logisticsCompanyCode;
		/// <summary>
		/// 物流公司运单号
		/// </summary>
		private string logisticsWaybillNo;
		/// <summary>
		/// 退款ID
		/// </summary>
		private string refundId;
		/// <summary>
		/// 退款版本号
		/// </summary>
		private long? version;

		public virtual long? LogisticsCompanyCode
		{
			set
			{
				this.logisticsCompanyCode = value;
			}
			get
			{
				return this.logisticsCompanyCode;
			}
		}


		public virtual string LogisticsWaybillNo
		{
			set
			{
				this.logisticsWaybillNo = value;
			}
			get
			{
				return this.logisticsWaybillNo;
			}
		}


		public virtual string RefundId
		{
			set
			{
				this.refundId = value;
			}
			get
			{
				return this.refundId;
			}
		}


		public virtual long? Version
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (logisticsCompanyCode != null)
			{
				@params["logistics_company_code"] = logisticsCompanyCode;
			}
			if (!string.ReferenceEquals(logisticsWaybillNo, null))
			{
				@params["logistics_waybill_no"] = logisticsWaybillNo;
			}
			if (!string.ReferenceEquals(refundId, null))
			{
				@params["refund_id"] = refundId;
			}
			if (version != null)
			{
				@params["version"] = version;
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