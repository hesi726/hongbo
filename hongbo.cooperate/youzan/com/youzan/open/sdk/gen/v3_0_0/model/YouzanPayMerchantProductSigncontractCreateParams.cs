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

    public class YouzanPayMerchantProductSigncontractCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 生效时间
		/// </summary>
		private long? beginTime;
		/// <summary>
		/// 结束时间
		/// </summary>
		private long? endTime;
		/// <summary>
		/// 合作方ID
		/// </summary>
		private long? partnerId;
		/// <summary>
		/// 产品ID
		/// </summary>
		private long? prodId;
		/// <summary>
		/// 商户号
		/// </summary>
		private long? userNo;

		public virtual long? BeginTime
		{
			set
			{
				this.beginTime = value;
			}
			get
			{
				return this.beginTime;
			}
		}


		public virtual long? EndTime
		{
			set
			{
				this.endTime = value;
			}
			get
			{
				return this.endTime;
			}
		}


		public virtual long? PartnerId
		{
			set
			{
				this.partnerId = value;
			}
			get
			{
				return this.partnerId;
			}
		}


		public virtual long? ProdId
		{
			set
			{
				this.prodId = value;
			}
			get
			{
				return this.prodId;
			}
		}


		public virtual long? UserNo
		{
			set
			{
				this.userNo = value;
			}
			get
			{
				return this.userNo;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (beginTime != null)
			{
				@params["begin_time"] = beginTime;
			}
			if (endTime != null)
			{
				@params["end_time"] = endTime;
			}
			if (partnerId != null)
			{
				@params["partner_id"] = partnerId;
			}
			if (prodId != null)
			{
				@params["prod_id"] = prodId;
			}
			if (userNo != null)
			{
				@params["user_no"] = userNo;
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