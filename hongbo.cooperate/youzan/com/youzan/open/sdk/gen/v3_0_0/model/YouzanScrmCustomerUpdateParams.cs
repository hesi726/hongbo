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

    public class YouzanScrmCustomerUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 用户帐号信息
		/// </summary>
		private string account;
		/// <summary>
		/// 更新客户所需信息
		/// </summary>
		private string customerUpdate;

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


		public virtual string CustomerUpdate
		{
			set
			{
				this.customerUpdate = value;
			}
			get
			{
				return this.customerUpdate;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(account, null))
			{
				@params["account"] = account;
			}
			if (!string.ReferenceEquals(customerUpdate, null))
			{
				@params["customer_update"] = customerUpdate;
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