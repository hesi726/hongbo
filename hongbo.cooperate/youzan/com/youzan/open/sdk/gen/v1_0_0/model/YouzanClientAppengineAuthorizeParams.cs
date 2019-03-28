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

    public class YouzanClientAppengineAuthorizeParams : APIParams, FileParams
	{

		/// <summary>
		/// 应用状态(用于为后面获取token做准备)
		/// </summary>
		private string state;
		/// <summary>
		/// 应用重定向url(用于为后面获取token做准备)
		/// </summary>
		private string redirectUrl;
		/// <summary>
		/// 店铺id
		/// </summary>
		private long? kdtId;
		/// <summary>
		/// 应用id
		/// </summary>
		private string clientId;
		/// <summary>
		/// 应用类型1.平台型2.工具型3.自用型
		/// </summary>
		private long? classify;

		public virtual string State
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


		public virtual long? KdtId
		{
			set
			{
				this.kdtId = value;
			}
			get
			{
				return this.kdtId;
			}
		}


		public virtual string ClientId
		{
			set
			{
				this.clientId = value;
			}
			get
			{
				return this.clientId;
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



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(state, null))
			{
				@params["state"] = state;
			}
			if (!string.ReferenceEquals(redirectUrl, null))
			{
				@params["redirect_url"] = redirectUrl;
			}
			if (kdtId != null)
			{
				@params["kdt_id"] = kdtId;
			}
			if (!string.ReferenceEquals(clientId, null))
			{
				@params["client_id"] = clientId;
			}
			if (classify != null)
			{
				@params["classify"] = classify;
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