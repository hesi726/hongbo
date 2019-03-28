namespace youzan.com.youzan.push
{


    /// <summary>
    /// 接入的响应
    /// https://www.youzanyun.com/docs/guide/3401/3448
    /// </summary>
    public class PushMessageResponse
    {
        /// <summary>
        /// 成功的推送消息的响应
        /// </summary>
        public static PushMessageResponse Success = new PushMessageResponse { code = 0, msg = "success " };
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
    }
}
