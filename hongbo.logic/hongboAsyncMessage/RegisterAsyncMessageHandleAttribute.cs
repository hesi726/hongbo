using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hongbao.AsyncMessage
{
    /// <summary>
    /// 注册一个异步消息处理方法，
    /// 此特性只用于处理通知的方法; 
    /// 即只带有一个参数,参数类型为  MessageContentType 实例的 的方法 
    /// 可能为实例方法 或者 静态方法;
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class RegisterAsyncMessageHandleAttribute : Attribute
    {
        /// <summary>
        /// 是否是线程安全，
        /// </summary>
        public RegisterAsyncMessageHandleAttribute(int messageType,
            Type messageContentType, 
            bool threadSafe = false) : base()
        {
            this.MessageType = messageType;
            this.MessageContentType = messageContentType;
            this.ThreadSafe = threadSafe;
        }

        /// <summary>
        /// 是否是线程安全
        /// </summary>
        public bool ThreadSafe { get; }

        /// <summary>
        /// 消息类型;
        /// </summary>
        public int MessageType { get; set;}

        /// <summary>
        /// 消息内容所包含的数据的类型;
        /// </summary>
        public Type MessageContentType { get; set;  }
    }
}