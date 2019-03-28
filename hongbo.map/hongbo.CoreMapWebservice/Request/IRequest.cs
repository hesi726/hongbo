using hongbo.CoreMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.CoreMapWebservice.Request
{
    /// <summary>
    /// 请求的信息类;
    /// </summary>
    public interface IRequest<TResponse>
        where TResponse: IResponse
    {
        /// <summary>
        /// 主机名称
        /// </summary>
        string Host { get; }

        /// <summary>
        /// 请求的Route
        /// </summary>
        string Address { get; }

        /// <summary>
        /// 是否需要时间戳参数(从 1970-01-01 之后经过的秒数)
        /// </summary>
        bool RequiredTimestamp { get; }

        /// <summary>
        /// 请求的参数
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetParameters();        
    }
}
