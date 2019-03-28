
using Senparc.NeuChar.Entities;
using Senparc.Weixin.Work.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hongbao.Wechat
{
    /// <summary>
    /// 工具类;
    /// </summary>
    public static class QyMessageUtil
    {


        /// <summary>
        /// 创建文本消息;
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static IWorkResponseMessageBase TextMessage(IRequestMessageBase requestMessage, string content)
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
    }
}