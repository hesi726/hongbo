
using hongbao.CollectionExtension;
using hongbao.IOExtension;
using Senparc.Weixin.Work.AdvancedAPIs;
using Senparc.Weixin.Work.AdvancedAPIs.App;
using Senparc.Weixin.Work.AdvancedAPIs.Mass;
using Senparc.Weixin.Work.AdvancedAPIs.Media;
using Senparc.Weixin.Work.Containers;
using Senparc.Weixin.Work.Entities;
using Senparc.Weixin.Work.Helpers;
using Senparc.Weixin.Work.Tencent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace hongbao.Wechat
{
    /// <summary>
    /// 微信的辅助类;
    /// </summary>
    public static class AssistantWechat
    {
        /// <summary>
        /// 微信企业Id
        /// </summary>
        internal static string WechatCorpId = null;
        /// <summary>
        /// 
        /// </summary>
        internal static List<WechatWorkApp> AppList = null;
        /// <summary>
        /// 初始化企业的Id;
        /// </summary>
        /// <param name="corpId"></param>
        public static void Initiate(string corpId)
        {
            AppList = new List<WechatWorkApp>();
            WechatCorpId = corpId;
        }

        /// <summary>
        /// 增加企业APP的信息定义;
        /// </summary>
        /// <param name="appName">企业APP的名称,</param>
        /// <param name="appAgentId">企业APP的名称,</param>
        /// <param name="appSecret"></param>
        /// <param name="messageReceiveToken"></param>
        /// <param name="messageReceiveAesKey"></param>
        public static void AddCorpAppInfo(string appName, string appAgentId, string appSecret,
                 string messageReceiveToken 
            , string messageReceiveAesKey)
        {
            var appInfo = 
                new WechatWorkApp(new WechatWorkConfig {
                    Name = appName,
                    CorpId =WechatCorpId,
                    AppId = appAgentId,
                    AppSecret = appSecret,
                    Token = messageReceiveToken,
                    EncodingAesKey = messageReceiveAesKey
                });
            AppList.Add(appInfo);
            if (appName == "test")
                TestApp = appInfo;
            else if (appName == "水机推广")
            {
                //DevicePromoteApp = appInfo;
            }
            else if (appName == "地推水机推广")
            {
                PartnerDevicePromoteApp = appInfo; 
            }
            else if (appName.ToLower().IndexOf("crm") >= 0)
                CrmApp = appInfo;

        }

        /// <summary>
        /// 测试的企业App信息类实例;
        /// </summary>
        public static WechatWorkApp TestApp { get; private set; }
        

        /// <summary>
        /// 给地推公司使用的水机推广的企业App信息类实例;
        /// </summary>
        public static WechatWorkApp PartnerDevicePromoteApp { get; private set; }

        /// <summary>
        /// Crm的企业App信息类实例;
        /// </summary>
        public static WechatWorkApp CrmApp { get; private set; }


        /// <summary>
        /// 根据名称获取企业APP的信息类;
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static WechatWorkApp GetApp(string name)
        {
            return AppList.First(a => a.Config.Name == name);
        }







    }
    /*
    /// <summary>
    /// 企业微信的应用信息类;
    /// </summary>
    public class WechatWorkAppXX
    {
        /// <summary>
        /// 名称;
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// AgentId
        /// </summary>
        public string AgentId { get;  set; }

        /// <summary>
        /// 用于加密的Key;
        /// </summary>
        public string Secret { get;  set; }

        /// <summary>
        /// 企业的Id;
        /// </summary>
        public string CorpId { get;  set; }

        /// <summary>
        /// 消息接收的Token可由企业任意填写，用于生成签名。        
        /// </summary>
        public string MessageReceiveToken { get; set;  }

        /// <summary>
        /// EncodingAESKey用于消息体的加密，是AES密钥的Base64编码
        /// 43位长度的字符串;
        /// </summary>
        public string MessageReceiveEncodingAESKey { get; set; }

        public WXBizMsgCrypt MsgCrypt = null; 
        /// <summary>
        /// 注册企业APP信息;
        /// </summary>
        public void Register()
        {
            AccessTokenContainer.Register(CorpId, Secret);
            JsApiTicketContainer.Register(CorpId, Secret);

            if (!string.IsNullOrEmpty(MessageReceiveToken) && !string.IsNullOrEmpty(MessageReceiveEncodingAESKey))
            {
                MsgCrypt = new WXBizMsgCrypt(MessageReceiveToken, MessageReceiveEncodingAESKey, CorpId);
            }
        }

        /// <summary>
        /// 获取企业微信APP的访问令牌;
        /// </summary>
        public  string AccessToken
        {
            get
            {
                return AccessTokenContainer.GetToken(CorpId, Secret);
            }
        }

        /// <summary>
        /// 获取企业微信APP的JS票据;
        /// </summary>
        public string JSTicket
        {
            get
            {
                return JsApiTicketContainer.GetTicket(CorpId, Secret);
            }
        }

        /// <summary>
        /// 获取配置微信JSSDK的JS字符串;
        /// </summary>
        /// <param name="url"></param>
        /// <param name="interfaces"></param>
        /// <returns></returns>
        public string GetConfigWxJs(string url, string interfaces, bool debug = true)
        {
            if (string.IsNullOrEmpty(CorpId))
                return "";
            //url = url.ToLower(); //特别注意,url必须小写，否则验证通不过;
            JSSDKHelper helper = new JSSDKHelper();
            var timestamp = JSSDKHelper.GetTimestamp();
            var nonceStr = JSSDKHelper.GetNoncestr();
            var jsticket = JSTicket;
            var signature = JSSDKHelper.GetSignature(jsticket, nonceStr, timestamp, url);
            string interfs = interfaces.Split(new char[] { ',' })
                .Select(a => "'" + a.Trim() + "'").ToArray().ToString(",");
            string debugString = "";
            if (debug)
            {
                debugString = "/**" + jsticket + @"** /";
            }
            string configString = debugString + @"
            wx.config({debug:" + debug.ToString().ToLower() + ",appId:'" + CorpId + "',timestamp:" +
                timestamp + ",nonceStr:'" + nonceStr + "',signature:'" + signature + "',jsApiList:[" + interfs + "]});";
            return configString;
        }

        
        /// <summary>
        /// 保存微信的图片到本地
        /// </summary>
        /// <param name="mediaId"></param>
        /// <param name="destPath"></param>
        public void SaveMediaStreamToFile(string mediaId, string destPath)
        {
            using (var stream = GetMediaStream(mediaId))
            {
                FileUtil.writeFileBinaryContent(destPath, stream.ToArray());
            }
        }


        /// <summary>
        /// 获取微信的图片;
        /// </summary>
        /// <param name="mediaId"></param>
        /// <returns></returns>
        public  MemoryStream GetMediaStream(string mediaId)
        {
            MemoryStream stream = new MemoryStream();
            MediaApi.Get(AccessToken, mediaId, stream);
            return stream;
        }
        /// <summary>
        /// 发送文本消息到给定的用户;
        /// </summary>
        /// <param name="userId">用户的openid</param>
        /// <param name="content"></param>
        public void SendMessage(string userId, string content)
        {
           // userId = "qy01c0f1cc0310c7002848a37e2e";
            var massResult = MassApi.SendText(AccessToken, userId, null, null, AgentId, content);

        }
        
        /// <summary>
        /// 发送文本消息到给定的用户;
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="content"></param>
        public Task<MassResult> SendMessageAsync(string userId, string content)
        {
            // userId = "qy01c0f1cc0310c7002848a37e2e";
            return MassApi.SendTextAsync(AccessToken, userId, null, null, AgentId, content);
        }

        /// <summary>
        /// 发送图文消息到给定的用户;
        /// 注意普通图文消息的长度不超过512字节;
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="articleList"></param>
        public void SendNews(string userId, List<Article> articleList)
        {
            // userId = "qy01c0f1cc0310c7002848a37e2e";
            MassApi.SendNews(AccessToken, null, articleList, userId);
           // MassApi.SendNews(AccessToken, userId, null, null, AgentId, articleList);
        }

        /// <summary>
        /// 发送图文消息到给定的用户;
        /// 多个图文消息将会显示图片和消息标题在微信消息上,
        /// 但点击时按照消息的内容进行跳转或者显示;
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="articleList"></param>
        public void SendMpnews(string userId, List<MpNewsArticle> articleList)
        {
            MassApi.SendMpNews(AccessToken, null, articleList, userId);
            //MassApi.SendMpNews(AccessToken, userId, null, null, AgentId, articleList);
            // userId = "qy01c0f1cc0310c7002848a37e2e";
            //MassApi.SendNews(AccessToken, userId, null, null, AgentId, articleList);
        }

        /// <summary>
        /// 上传文件;
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public UploadTemporaryResultJson UploadFile(string filepath)
        {
            return MediaApi.Upload(AccessToken, Senparc.Weixin.QY.UploadMediaFileType.file, filepath);
        }
        /// <summary>
        /// 上传图片到微信服务器,但是返回url;
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public UploadimgMediaResult UploadimgMedia(string filepath)
        {
            var result = MediaApi.UploadimgMedia(AccessToken,  filepath);
            return result;
        }
        /// <summary>
        /// 发送文件;
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="filepath"></param>
        public MassResult SendFileToUser(string userid, string filepath)
        {
            var uploadResult = UploadFile(filepath);
            return MassApi.SendFile(AccessToken, userid, null, null, AgentId, uploadResult.media_id);
            
        }

        /// <summary>
        /// 获取用户信息;
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Senparc.Weixin.QY.AdvancedAPIs.OAuth2.GetUserInfoResult GetUserInfo(string code)
        {
            return OAuth2Api.GetUserId(this.AccessToken, code);            
        }
    }*/
}