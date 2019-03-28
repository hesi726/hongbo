using hongbo.BaiduMapWebservice.Response;
using hongbo.CoreMapWebservice;
using hongbo.CoreMapWebservice.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongbo.BaiduMapWebservice.Request
{
    /// <summary>
    /// 地图的请求接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaiduRequest<TResponse> : IRequest<TResponse>
        where TResponse : BaiduResponse
    {       
        ///// <summary>
        ///// 是否需要时间戳;(从 1970-01-01 之后经过的秒数)
        ///// </summary>
        //bool RequiredTimestamp { get; }
    }
}
