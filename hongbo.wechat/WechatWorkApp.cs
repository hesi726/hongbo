using hongbao.CollectionExtension;
using hongbao.IOExtension;
using Senparc.NeuChar.Entities;
using Senparc.Weixin.Work;
using Senparc.Weixin.Work.AdvancedAPIs;
using Senparc.Weixin.Work.AdvancedAPIs.Mass;
using Senparc.Weixin.Work.AdvancedAPIs.Media;
using Senparc.Weixin.Work.AdvancedAPIs.OAuth2;
using Senparc.Weixin.Work.Containers;
using Senparc.Weixin.Work.Entities;
using Senparc.Weixin.Work.Helpers;
using Senparc.Weixin.Work.Tencent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senparc.CO2NET.RegisterServices;
using Senparc.Weixin.Cache.Redis;
using Newtonsoft.Json;

namespace hongbao.Wechat
{
    /// <summary>
    /// 企业微信的应用信息类
    /// </summary>
    public class WechatWorkApp : IWechatConfigGetter, IJSTicketGetter
    {
        static WechatWorkApp()
        {
            WechatMpApp.RegisterWeixinConfig();
        }

        /// <summary>
        /// 是否处于调试状态;
        /// </summary>
        public static bool IsDebug = false;

        /// <summary>
        /// 调试时接收数据的微信Id;
        /// </summary>
        public static string DebugWechatOpenId = null;

        /// <summary>
        /// 所有微信消息都将密送到此OpenId;
        /// </summary>
        public static string SecretWechatOpenId = null; 

        /// <summary>
        /// 配置类;
        /// </summary>
        public WechatWorkConfig Config { get; private set; }

        /// <summary>
        /// 配置对象;
        /// </summary>
        /// <param name="Config"></param>
        public WechatWorkApp(WechatWorkConfig Config)
        {
            this.Config = Config;
        }        
        /// <summary>
        /// 
        /// </summary>
        public WXBizMsgCrypt MsgCrypt = null;
        /// <summary>
        /// 注册企业APP信息;注册后才能够正常使用;
        /// </summary>
        public void Register()
        {
            //WechatMpApp.registerService.RegisterWorkAccount(Config.AppId, Config.AppSecret, "全视物联企业");
            //WechatMpApp.RegisterWorkJsApiTicket(Config.AppId, Config.AppSecret, "全视物联企业Js");
            if (WechatMpApp.registerService == null) WechatMpApp.RegisterWeixinConfig();

            AccessTokenContainer.Register(Config.CorpId,  Config.AppSecret);
            JsApiTicketContainer.Register(Config.CorpId,  Config.AppSecret);

            if (!string.IsNullOrEmpty(Config.Token) && 
                !string.IsNullOrEmpty(Config.EncodingAesKey))
            {
                MsgCrypt = new WXBizMsgCrypt(Config.Token, Config.EncodingAesKey, Config.CorpId);
            }
        }

        /// <summary>
        /// 企业微信的corpID
        /// https://work.weixin.qq.com/api/doc#10029/步骤二：通过config接口注入权限验证配置
        /// </summary>
        public string JsTicketAppId {  get { return Config.CorpId; } }

        /// <summary>
        /// 验证URL参数;
        /// </summary>
        /// <param name="msg_signature"></param>
        /// <param name="timestamp"></param>
        /// <param name="nonce"></param>
        /// <param name="echostr"></param>
        /// <returns></returns>
        public string VerifyURL(string msg_signature,string timestamp, string nonce, string echostr) {
            return Signature.VerifyURL(Config.Token, Config.EncodingAesKey,
                    Config.CorpId, msg_signature, timestamp, nonce,
                    echostr);
        }

        /// <summary>
        /// 返回 AppKey或者AccessToken;
        /// </summary>
        [JsonIgnore]
        public string AccessTokenOrAppKey
        {
            get
            {
                return AccessToken; /*
                if (AppKey != null) return AppKey;
                else return AccessToken;*/
            }
        }

        /// <summary>
        /// 获取企业微信APP的访问令牌;
        /// </summary>
        [JsonIgnore]
        public string AccessToken
        {
            get
            {
                return AccessTokenContainer.GetToken(Config.CorpId,  Config.AppSecret);
            }
        }

        private string appKey = null;

        /// <summary>
        /// AppKey
        /// </summary>
        [JsonIgnore]
        public string AppKey
        {
            get
            {
                if (appKey == null)
                {
                    appKey = AccessTokenContainer.BuildingKey(Config.CorpId, Config.AppSecret);
                }
                return appKey; 
            }
        }

        /// <summary>
        /// 获取企业微信APP的JS票据;
        /// </summary>
        public string JsTicket
        {
            get
            {
                return JsApiTicketContainer.GetTicket(Config.CorpId,  Config.AppSecret);
            }
        }

        WechatConfig IWechatConfigGetter.Config => this.Config;

        /// <summary>
        /// 获取配置微信JSSDK的JS字符串;
        /// </summary>
        /// <param name="url"></param>
        /// <param name="interfaces"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public string GetConfigWxJs(string url, string interfaces, bool debug = true)
        {
            if (string.IsNullOrEmpty(Config.CorpId))
                return "";
            //url = url.ToLower(); //特别注意,url必须小写，否则验证通不过;
            JSSDKHelper helper = new JSSDKHelper();
            var timestamp = JSSDKHelper.GetTimestamp();
            var nonceStr = JSSDKHelper.GetNoncestr();
            var jsticket = JsTicket;
            var signature = JSSDKHelper.GetSignature(jsticket, nonceStr, timestamp, url);
            string interfs = interfaces.Split(new char[] { ',' })
                .Select(a => "'" + a.Trim() + "'").ToArray().ToString(",");
            string debugString = "";
            if (debug)
            {
                debugString = "/**" + jsticket + @"**/";
            }
            string configString = debugString + @"
            wx.config({debug:" + debug.ToString().ToLower() + ",appId:'" + Config.CorpId + "',timestamp:" +
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
        public MemoryStream GetMediaStream(string mediaId)
        {
            MemoryStream stream = new MemoryStream();
            MediaApi.Get(AccessTokenOrAppKey, mediaId, stream);
            return stream;
        }
        /// <summary>
        /// 发送文本消息到给定的用户;
        /// </summary>
        /// <param name="userOpenId">用户的openid</param>
        /// <param name="content"></param>
        public bool SendMessage(string userOpenId, string content)
        {
            // userOpenId = "qy01c0f1cc0310c7002848a37e2e";   
            //var appkey = AccessTokenContainer.BuildingKey(Config.CorpId, Config.AppSecret);
            // var result = MassApi.SendText(AccessToken, Config.AppId,  content, CorrectUserOpenId(userOpenId));
            //var result = MassApi.SendText(appkey, Config.AppId, content, CorrectUserOpenId(userOpenId));
            var result = MassApi.SendText(AccessTokenOrAppKey, Config.AppId, content, CorrectUserOpenId(userOpenId));
            if (result.errcode != 0) return false;
            return true;
            //var massResult = MassApi.SendText(AccessToken, userOpenId, null, null, Config.AgentId,  content);
        }

        private string CorrectUserOpenId(string userOpenId)
        {
            if (IsDebug) return DebugWechatOpenId;
            if (userOpenId == "@all") return userOpenId;
            if (this.Config.Name.IndexOf("地推") >= 0) return userOpenId;
            if (SecretWechatOpenId != null && userOpenId.IndexOf(SecretWechatOpenId)<0)
            {
                return userOpenId + "|" + SecretWechatOpenId;
            }
            return userOpenId;
        }

        /// <summary>
        /// 发送文本消息到给定的用户;
        /// </summary>
        /// <param name="userOpenId"></param>
        /// <param name="content"></param>
        public Task<MassResult> SendMessageAsync(string userOpenId, string content)
        {
            // userOpenId = "qy01c0f1cc0310c7002848a37e2e";
            return MassApi.SendTextAsync(AccessToken, Config.AppId,  content, CorrectUserOpenId(userOpenId));
            //return MassApi.SendTextAsync(AccessToken, userOpenId, null, null, Config.AgentId,  content);
        }

        /// <summary>
        /// 发送图文消息到给定的用户;
        /// 注意普通图文消息的长度不超过512字节;
        /// </summary>
        /// <param name="userOpenId"></param>
        /// <param name="articleList"></param>

        public void SendNews(string userOpenId, List<Article> articleList)
        {
            // userOpenId = "qy01c0f1cc0310c7002848a37e2e";
            MassApi.SendNews(AccessTokenOrAppKey, Config.AppId,  articleList, CorrectUserOpenId(userOpenId));
            //MassApi.SendNews(AccessToken, null, articleList, userOpenId);
            // MassApi.SendNews(AccessToken, userOpenId, null, null, Config.AgentId,  articleList);
        }

        /// <summary>
        /// 发送图文消息到给定的用户;
        /// 多个图文消息将会显示图片和消息标题在微信消息上,
        /// 但点击时按照消息的内容进行跳转或者显示;
        /// </summary>
        /// <param name="userOpenId"></param>
        /// <param name="articleList"></param>
        public void SendMpnews(string userOpenId, List<MpNewsArticle> articleList)
        {
            MassApi.SendMpNews(AccessTokenOrAppKey, Config.AppId,  articleList, CorrectUserOpenId(userOpenId));
            //MassApi.SendMpNews(AccessToken, null, articleList, userOpenId);
            //MassApi.SendMpNews(AccessToken, userOpenId, null, null, Config.AgentId,  articleList);
            // userOpenId = "qy01c0f1cc0310c7002848a37e2e";
            //MassApi.SendNews(AccessToken, userOpenId, null, null, Config.AgentId,  articleList);
        }

        /// <summary>
        /// 上传文件;
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public UploadTemporaryResultJson UploadFile(string filepath)
        {
            return MediaApi.Upload(AccessTokenOrAppKey, Senparc.Weixin.Work.UploadMediaFileType.file, filepath);
        }
        /// <summary>
        /// 上传图片到微信服务器,但是返回url;
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public UploadimgMediaResult UploadimgMedia(string filepath)
        {
            var result = MediaApi.UploadimgMedia(AccessTokenOrAppKey, filepath);
            return result;
        }
        /// <summary>
        /// 发送文件;
        /// </summary>
        /// <param name="userOpenId"></param>
        /// <param name="filepath"></param>
        public MassResult SendFileToUser(string userOpenId, string filepath)
        {
            var uploadResult = UploadFile(filepath);
            return MassApi.SendFile(AccessTokenOrAppKey, Config.AppId,  uploadResult.media_id, CorrectUserOpenId(userOpenId));

        }

        /// <summary>
        /// 
        /// </summary>
        private static IDictionary<string, GetUserInfoResult> map = 
            new System.Collections.Concurrent.ConcurrentDictionary<string, GetUserInfoResult>();
        
        /// <summary>
        /// 清理Map
        /// </summary>
        public static void ClearCodeMap()
        {
            lock (map)
            {
                map.Clear();
            }
        }
        /// <summary>
        /// 获取用户信息;
        /// 微信会进行2次回调，1次断开
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public GetUserInfoResult GetUserOpenIdByCode(string code)
        {
            GetUserInfoResult value = null;
            bool result = map.TryGetValue(code, out value);
            if (result)
            {
               // map.Remove(code);
                return value;
            }
            else
            {
                value = OAuth2Api.GetUserId(AccessTokenOrAppKey, code);
                map[code] = value;
                return value;
            }
            
        }
    }
}
