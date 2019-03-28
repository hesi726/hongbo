using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v1_0_1.model
{
    ////using Maps = com.google.common.collect.Maps;
    using global::youzan.com.youzan.open.sdk.model;

    ////using Multimap = com.google.common.collect.Multimap;

    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanPayAcctransAccountGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 账户类型
		/// </summary>
		private long? acctType;
		/// <summary>
		/// 商户号
		/// </summary>
		private string partnerId;

		public virtual long? AcctType
		{
			set
			{
				this.acctType = value;
			}
			get
			{
				return this.acctType;
			}
		}


		public virtual string PartnerId
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (acctType != null)
			{
				@params["acct_type"] = acctType;
			}
			if (!string.ReferenceEquals(partnerId, null))
			{
				@params["partner_id"] = partnerId;
			}
			return @params;
		}

		public virtual IDictionary<string, ByteWrapper> toFileParams()
		{
            Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}