using Senparc.NeuChar.Entities;
using Senparc.Weixin.MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hongbao.Wechat
{
    /// <summary>
    /// 工具类;
    /// </summary>
    public static class MpMessageUtil
    {
        /// <summary>
        /// 关注公众号的事件中eventKey的字符串的前缀
        /// </summary>
        public const string QRScentPrefix = "qrscene_" ;

        /// <summary>
        /// 创建文本消息;
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static IResponseMessageBase TextMessage(IRequestMessageBase requestMessage, string content)
        {
            var result = ResponseMessageBase.CreateFromRequestMessage<ResponseMessageText>(requestMessage);
            result.Content = content;
            return result;
        }

        /// <summary>
        /// 创建单个图文消息
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="title">标题</param>
        /// <param name="content">内容</param>
        /// <param name="picUrl">图片</param>
        /// <param name="url">地址</param>
        /// <returns></returns>
        public static IResponseMessageBase SingleNews(
            IRequestMessageBase requestMessage,
            string title, string content,string picUrl, string url  )
        {
            var result = ResponseMessageBase.CreateFromRequestMessage<ResponseMessageNews>(requestMessage);
            result.ArticleCount = 1;
            result.Articles = new List<Article>
               {
                   new Article
                   {
                        Title = title,
                        Description = content,
                        PicUrl = picUrl,
                        Url = url
                   }
               };
            return result;
        }

        /// <summary>
        /// 创建客服响应消息;
        /// https://mp.weixin.qq.com/wiki?t=resource/res_main&amp;id=mp1458557405
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <returns></returns>
        public static IResponseMessageBase CreateCustomerServiceMessage(RequestMessageText requestMessage)
        {
            return ResponseMessageBase.CreateFromRequestMessage<ResponseMessageTransfer_Customer_Service>(requestMessage);
        }
    }
}