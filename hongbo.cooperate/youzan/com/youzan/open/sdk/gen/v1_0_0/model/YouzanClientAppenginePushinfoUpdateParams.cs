using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v1_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanClientAppenginePushinfoUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 是否开启推送1.开启0.不开启
		/// </summary>
		private long? pushValid;
		/// <summary>
		/// 推送地址
		/// </summary>
		private string pushUrl;
		/// <summary>
		/// 开发者id
		/// </summary>
		private long? developerId;
		/// <summary>
		/// 应用id
		/// </summary>
		private long? appId;

		public virtual long? PushValid
		{
			set
			{
				this.pushValid = value;
			}
			get
			{
				return this.pushValid;
			}
		}


		public virtual string PushUrl
		{
			set
			{
				this.pushUrl = value;
			}
			get
			{
				return this.pushUrl;
			}
		}


		public virtual long? DeveloperId
		{
			set
			{
				this.developerId = value;
			}
			get
			{
				return this.developerId;
			}
		}


		public virtual long? AppId
		{
			set
			{
				this.appId = value;
			}
			get
			{
				return this.appId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (pushValid != null)
			{
				@params["push_valid"] = pushValid;
			}
			if (!string.ReferenceEquals(pushUrl, null))
			{
				@params["push_url"] = pushUrl;
			}
			if (developerId != null)
			{
				@params["developer_id"] = developerId;
			}
			if (appId != null)
			{
				@params["app_id"] = appId;
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