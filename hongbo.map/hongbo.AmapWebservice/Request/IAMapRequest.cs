using hongbo.AMapWebservice.Response;
using hongbo.CoreMapWebservice.Request;

namespace hongbo.AMapWebservice.Request
{
    /// <summary>
    /// 请求类;
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IAMapRequest<TResponse> : IRequest<TResponse>
        where TResponse: IAMapResponse
    {
    }
}
