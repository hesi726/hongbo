using System;
using System.Collections.Generic;
using System.Linq;

namespace com.youzan.open.sdk.api
{
    using com.youzan.open.sdk.model;
    using global::youzan.com.youzan.open.sdk.api;

    //////using Maps = com.google.common.collect.Maps;
    using Newtonsoft.Json;
    using YouZanSdkNetCore.Core;
    using APIParams = com.youzan.open.sdk.model.APIParams;
    using global::youzan;

    /// <summary>
    /// @author ph0ly
    /// @time 2016-11-28
    /// </summary>
    public abstract class AbstractAPI<TParam, TResult> : API<TParam>
        where TParam: APIParams
	{
        /// <summary>
        /// 返回调用结果，可能抛出异常;
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        internal TResult Invoke(YouzanConfig config, TParam param)
        {
            YZClient yzClient = new DefaultYZClient(config.Token);
            //var param = this.APIParams;
            var @params = param.toParams();
            List<KeyValuePair<string, string>> files = null;
            if (this.hasFiles())
            {
                files = ((FileParams)this.APIParams).toFileParams().Select(a => a.Value.Data).ToList();
            }
            var result = yzClient.Invoke(this.Name, this.Version, this.HttpMethod, @params, files);
            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.NullValueHandling = NullValueHandling.Ignore;
            var wrapper = JsonConvert.DeserializeObject<TResultWrapper<TResult>>(result, setting);
            if (wrapper.error_response != null)
                throw new Exception(string.Format("错误响应：代码:{0}, 消息{1}", wrapper.error_response.code, wrapper.error_response.msg));
            return wrapper.response;
        }

        /// <summary>
        /// 返回调用结果，可能抛出异常;
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        public TResult Invoke(YouzanConfig config)
        {
            if (this.APIParams == null) throw new Exception("未指定参数 :  APIParams ");
            return this.Invoke(config, this.APIParams);
        }

        public abstract bool hasFiles();
		public abstract Type ParamModelClass {get;}
		public abstract Type ResultModelClass {get;}
		public abstract string Name {get;}
		public abstract string HttpMethod {get;}

		protected internal TParam @params;

		public virtual TParam APIParams
		{
			get
			{
				return this.@params;
			}
			set
			{
				this.@params = value;
			}
		}


		public virtual string HttpUrl
		{
			get
			{
				return "https://open.youzan.com/api";
			}
		}

		public virtual string Version
		{
			get
			{
				return "1.0.0";
			}
		}
        
        /// <summary>
        /// 
        /// </summary>
		public virtual IDictionary<string, string> Headers
		{
			get
			{
                return new Dictionary<string, string>();
			}
		}
	}

}