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

    public class YouzanClientAutosaveParams : APIParams, FileParams
	{

		/// <summary>
		/// 应用状态(用于oauth授权匹配)
		/// </summary>
		private long? state;
		/// <summary>
		/// 备注
		/// </summary>
		private string remark;
		/// <summary>
		/// oauth重定向url
		/// </summary>
		private string redirectUrl;
		/// <summary>
		/// 三方开发者id
		/// </summary>
		private long? developerId;
		/// <summary>
		/// 应用名称
		/// </summary>
		private string clientName;
		/// <summary>
		/// 应用范围
		/// 1. 平台型
		/// 2. 工具型
		/// 3. 自用型
		/// </summary>
		private long? classify;
		/// <summary>
		/// 应用类型
		/// </summary>
		private long? appType;
		/// <summary>
		/// 应用id
		/// </summary>
		private long? appId;

		public virtual long? State
		{
			set
			{
				this.state = value;
			}
			get
			{
				return this.state;
			}
		}


		public virtual string Remark
		{
			set
			{
				this.remark = value;
			}
			get
			{
				return this.remark;
			}
		}


		public virtual string RedirectUrl
		{
			set
			{
				this.redirectUrl = value;
			}
			get
			{
				return this.redirectUrl;
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


		public virtual string ClientName
		{
			set
			{
				this.clientName = value;
			}
			get
			{
				return this.clientName;
			}
		}


		public virtual long? Classify
		{
			set
			{
				this.classify = value;
			}
			get
			{
				return this.classify;
			}
		}


		public virtual long? AppType
		{
			set
			{
				this.appType = value;
			}
			get
			{
				return this.appType;
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
			if (state != null)
			{
				@params["state"] = state;
			}
			if (!string.ReferenceEquals(remark, null))
			{
				@params["remark"] = remark;
			}
			if (!string.ReferenceEquals(redirectUrl, null))
			{
				@params["redirect_url"] = redirectUrl;
			}
			if (developerId != null)
			{
				@params["developer_id"] = developerId;
			}
			if (!string.ReferenceEquals(clientName, null))
			{
				@params["client_name"] = clientName;
			}
			if (classify != null)
			{
				@params["classify"] = classify;
			}
			if (appType != null)
			{
				@params["app_type"] = appType;
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