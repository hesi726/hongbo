using System;
using System.Collections.Generic;

namespace com.youzan.open.sdk.api
{

    using APIParams = com.youzan.open.sdk.model.APIParams;

    /// <summary>
    /// @author ph0ly
    /// @time 2016-11-28
    /// </summary>
    public interface API<TParam>
        where TParam: APIParams
	{

		/// <summary>
		/// 获取API对应的请求方法，GET、POST、PUT、DELETE
		/// @return
		/// </summary>
		string HttpMethod {get;}

		/// <summary>
		/// 获取http请求的url
		/// @return
		/// </summary>
		string HttpUrl {get;}

		/// <summary>
		/// 获取API版本号
		/// @return
		/// </summary>
		string Version {get;}

		/// <summary>
		/// 获取API名称
		/// @return
		/// </summary>
		string Name {get;}

		/// <summary>
		/// 获取API参数
		/// @return
		/// </summary>
		TParam APIParams {get;set;}

		/// <summary>
		/// 获取API携带头部信息
		/// @return
		/// </summary>
		IDictionary<string, string> Headers {get;}


		/// <summary>
		/// 获取API返回模型类
		/// @return
		/// </summary>
		Type ResultModelClass {get;}

		/// <summary>
		/// 获取API参数模型类
		/// @return
		/// </summary>
		Type ParamModelClass {get;}

		/// <summary>
		/// 获取该API是否带附件
		/// @return
		/// </summary>
		bool hasFiles();
	}

}