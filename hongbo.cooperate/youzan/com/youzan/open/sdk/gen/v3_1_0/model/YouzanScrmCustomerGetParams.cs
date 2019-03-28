using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_1_0.model
{

    //using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    //using Maps = com.google.common.collect.Maps;
    //using Multimap = com.google.common.collect.Multimap;
    using global::youzan.com.youzan.open.sdk.model;
    using APIParams = com.youzan.open.sdk.model.APIParams;
	using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
	using FileParams = com.youzan.open.sdk.model.FileParams;

	public class YouzanScrmCustomerGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 用户帐号信息（{"account_type":"Mobile", "account_id":"1385716120"}）
		/// </summary>
		private string account;

		public virtual string Account
		{
			set
			{
				this.account = value;
			}
			get
			{
				return this.account;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(account, null))
			{
				@params["account"] = account;
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