namespace hongbao.AsyncMessage
{    
    /// <summary>
    /// 泛型的异步消息内容类
    /// </summary>
    public class AsyncMessageContentWrapper<TData>

    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public int MessageType { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public TData Data { get; set; }
    }
}
