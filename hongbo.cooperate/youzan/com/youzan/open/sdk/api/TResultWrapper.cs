using youzan.com.youzan.push;

namespace youzan.com.youzan.open.sdk.api
{
    /// <summary>
    /// 响应结果的包裹类
    /// </summary>
    public class TResultWrapper<TResult>
    {
        /// <summary>
        /// 正常时的响应结果
        /// </summary>
        public TResult response { get; set; }

        /// <summary>
        /// 错误时的响应结果
        /// </summary>
        public PushMessageResponse error_response { get; set; }
    }
    
}
