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

    public class YouzanTradeSelffetchcodeApplyParams : APIParams, FileParams
	{

		/// <summary>
		/// 消费者端的到店自提订单提货码
		/// </summary>
		private string code;
		/// <summary>
		/// 核销人（开发者根据自己业务规则传，一般为网点号或手机号）
		/// </summary>
		private string extraInfo;

		public virtual string Code
		{
			set
			{
				this.code = value;
			}
			get
			{
				return this.code;
			}
		}


		public virtual string ExtraInfo
		{
			set
			{
				this.extraInfo = value;
			}
			get
			{
				return this.extraInfo;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(code, null))
			{
				@params["code"] = code;
			}
			if (!string.ReferenceEquals(extraInfo, null))
			{
				@params["extra_info"] = extraInfo;
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