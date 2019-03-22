using Senparc.NeuChar.Context;
using Senparc.NeuChar.Entities;
using Senparc.Weixin.Work.Entities;
using Senparc.Weixin.Work.MessageHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbaoStandardExtension.Wechat
{
    /// <summary>
    /// 扩展类;
    /// </summary>
    public static class MessageHandlerExtension
    {
        /// <summary>
        /// 创建文本的响应消息类;
        /// </summary>
        /// <typeparam name="TC"></typeparam>
        /// <param name="messageHandle"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static ResponseMessageText CreateTextResponseMessage<TC>(
            this WorkMessageHandler<TC> messageHandle,
            string content)
            where TC : MessageContext<IWorkRequestMessageBase, IWorkResponseMessageBase>, new()
        {
            var result = messageHandle.CreateResponseMessage<ResponseMessageText>();
            result.Content = content;
            return result;
        }

    }
}
