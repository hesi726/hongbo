using Senparc.CO2NET;
using Senparc.CO2NET.Cache;
using Senparc.CO2NET.RegisterServices;
using Senparc.CO2NET.Utilities;
using Senparc.Weixin.Entities;
using Senparc.Weixin.Exceptions;
using Senparc.Weixin.MP.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Senparc.Weixin.MP.AdvancedAPIs;
using Senparc.Weixin.MP.Helpers;
using hongbao.CollectionExtension;
using System.IO;
using hongbao.IOExtension;
using Senparc.Weixin.MP;
using System.Web;
using Senparc.Weixin.MP.AdvancedAPIs.User;
using Senparc.Weixin.MP.AdvancedAPIs.OAuth;
using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage;
using Senparc.Weixin;
using Senparc.Weixin.TenPay.V3;
using Senparc.CO2NET.Cache.Redis;
using Senparc.Weixin.Cache.Redis;
using hongbao.Net;
using hongbao.Cache.Redis;
using Newtonsoft.Json;

namespace hongbao.Wechat
{
    /// <summary>
    /// 微信公众号的类;
    /// </summary>
    public class WechatMpApp : IWechatConfigGetter, IJSTicketGetter
    {
        internal static IRegisterService registerService = null;
        /// <summary>
        /// 
        /// </summary>
        static WechatMpApp()
        {
            RegisterWeixinConfig();
        }

        /// <summary>
        /// 注册缓存策略
        /// </summary>
        internal static void RegisterWeixinConfig()
        {
            lock (typeof(WechatMpApp))
            {
                if (registerService == null)
                {
                    //设置全局 Debug 状态
                    var isGLobalDebug = true;
                    //全局设置参数，将被储存到 Senparc.CO2NET.Config.SenparcSetting
                    var senparcSetting = SenparcSetting.BuildFromWebConfig(isGLobalDebug);
                    //CO2NET 全局注册，必须！！
                    IRegisterService register = RegisterService.Start(senparcSetting).UseSenparcGlobal(false, GetExCacheStrategies);
                    // IRegisterService register = RegisterService.Start(senparcSetting).UseSenparcGlobal();

                    BuildRedisCacheStrategy();
                    //设置微信 Debug 状态
                    var isWeixinDebug = true;
                    //全局设置参数，将被储存到 Senparc.Weixin.Config.SenparcWeixinSetting
                    var senparcWeixinSetting = SenparcWeixinSetting.BuildFromWebConfig(isWeixinDebug);
                    //微信全局注册，必须！！
                    registerService.UseSenparcWeixin(senparcWeixinSetting, senparcSetting);
                }
            }
        }

        /// <summary>
        /// 获取扩展缓存策略
        /// </summary>
        /// <returns></returns>
        private static IList<IDomainExtensionCacheStrategy> GetExCacheStrategies()
        {
            var exContainerCacheStrategies = new List<IDomainExtensionCacheStrategy>();

            var redusCacgeStrategy = BuildRedisCacheStrategy();
            if (redusCacgeStrategy != null)
            {
                exContainerCacheStrategies.Add(RedisContainerCacheStrategy.Instance);
            }
            return exContainerCacheStrategies;
        }

        /// <summary>
        /// 构建基于 Redis 的缓存策略;
        /// </summary>
        /// <returns></returns>
        public static BaseCacheStrategy BuildRedisCacheStrategy()
        {
            var redis = System.Configuration.ConfigurationManager.AppSettings["redis_conn"];
            var redisConnectionString = redis;
            if (redis.IndexOf(":") < 0)
            {
                redisConnectionString = redis += ":" + RedisUtil.DEFAULT_PORT;
            }
            if (!string.IsNullOrEmpty(redis))
            {
                Senparc.CO2NET.Cache.Redis.Register.SetConfigurationOption(redisConnectionString);
                //以下会立即将全局缓存设置为 Redis
                Senparc.CO2NET.Cache.Redis.Register.UseKeyValueRedisNow();//键值对缓存策略（推荐）
                CacheStrategyFactory.RegisterObjectCacheStrategy(() => RedisObjectCacheStrategy.Instance);
                return RedisObjectCacheStrategy.Instance;
            }
            return null;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="config"></param>
        public WechatMpApp(WechatConfig config)
        {
            this.Config = config;
        }

        /// <summary>
        /// 配置类;
        /// </summary>
        public WechatConfig Config { get; private set; }

        //public WXBizMsgCrypt MsgCrypt = null;
        private bool hasRegistered = false;
        /// <summary>
        /// 注册企业APP信息;
        /// </summary>
        public void Register()
        {
            //registerService.RegisterMpAccount(Config.AppId, Config.AppSecret, "全视物联");
            //registerService.RegisterMpJsApiTicket(Config.AppId, Config.AppSecret, "全视物联Js");

            if (registerService == null) RegisterWeixinConfig();
            if (hasRegistered) return;
            hasRegistered = true;

            AccessTokenContainer.Register(Config.AppId, Config.AppSecret);
            JsApiTicketContainer.Register(Config.AppId, Config.AppSecret);

            /* 改为在单元测试中注册和修改菜单，方便而且快捷；
            if (Config.MenuDefine != null)  //删除并且注册新的菜单; 
            {
                CommonApi.DeleteMenu(AccessToken); 
                CommonApi.CreateMenu(AccessToken, Config.MenuDefine);
            }
            */

            // if (!string.IsNullOrEmpty(MessageReceiveToken) && !string.IsNullOrEmpty(MessageReceiveEncodingAESKey))
            //{
            //     MsgCrypt = new WXBizMsgCrypt(MessageReceiveToken, MessageReceiveEncodingAESKey, Config.AppId);
            // }
        }

        /// <summary>
        /// 获取 JsTicketAppId,即Appid;
        /// </summary>
        public string JsTicketAppId { get { return this.Config.AppId;  } }

        /// <summary>
        /// Code 到 openId 的映射;
        /// </summary>
        private static IDictionary<string, OAuthAccessTokenResult> map =
            new System.Collections.Concurrent.ConcurrentDictionary<string, OAuthAccessTokenResult>();
       
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
        /// 根据code获取用户信息,用户不关注时也能调用此接口;
        /// https://open.weixin.qq.com/connect/oauth2/authorize?appid=appid&amp;redirect_uri=redirect_url&amp;response_type=code&amp;amp;scope=snsapi_base&amp;state=123#wechat_redirect";
        /// 微信会有2此验证;
        /// 可能抛出异常; 
        /// </summary>
        /// <param name="code"></param>
        public OAuthAccessTokenResult GetOpenIdInfoAccordCode(string code)
        {
            try
            {
                lock (map)
                {
                    OAuthAccessTokenResult value = null;
                    bool result = map.TryGetValue(code, out value);
                    if (result)
                    {
                       // map.Remove(code);  //第2次获取
                        return value;
                    }
                    else
                    {
                        value = OAuthApi.GetAccessToken(Config.AppId, Config.AppSecret, code);
                        map[code] = value;
                        return value;
                    }
                }
            }
            catch (Exception exp)
            {
                //长度为28时，应该是 openid;
                if (code.Length == 28) return new OAuthAccessTokenResult { openid = code }; //可能直接传入了 openid; 
                throw new Exception(exp.Message + string.Format("appId:{0},appSecret:{1}", Config.AppId, Config.AppSecret), exp);
            }
        }



        /// <summary>
        /// 根据code获取用户信息,用户不关注时也能调用此接口;
        /// 但是需要用户进行显示的确认;
        /// https://open.weixin.qq.com/connect/oauth2/authorize?appid=appid&amp;redirect_uri=redirect_url&amp;response_type=code&amp;scope=snsapi_userinfo&amp;state=123#wechat_redirect";
        /// </summary>
        /// <param name="code"></param>
        public OAuthUserInfo GetUserInfoAccordCode(string code)
        {
            var result = this.GetOpenIdInfoAccordCode(code); //   OAuthApi.GetAccessToken(Config.AppId, Config.AppSecret, code);
            return OAuthApi.GetUserInfo(result.access_token, result.openid);
        }

        /// <summary>
        /// 根据标签名称获取标签的Id; 
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public int? GetTagId(string tagName)
        {
            var tagList = UserTagApi.Get(AccessToken);
            if (tagList.errcode != 0 || tagList.tags == null || tagList.tags.Count == 0) return null;
            var tag = tagList.tags.FirstOrDefault(a => a.name == tagName);
            if (tag == null) return null;
            return tag.id;
        }

        /// <summary>
        /// 获取用户最后1个标签;
        /// </summary>
        /// <param name="openId"></param>
        public string GetUserLastTag(string openId)
        {
            var tagList = UserTagApi.Get(AccessToken);
            if (tagList.errcode != 0 || tagList.tags==null || tagList.tags.Count == 0) return null;
            var result = UserTagApi.UserTagList(AccessToken, openId);
            if (result.errcode != 0 || result.tagid_list==null) return null;
            var lastTagId = result.tagid_list.LastOrDefault();
            if (lastTagId == 0) return null; 
            var tag = tagList.tags.Where(a => a.id == lastTagId).FirstOrDefault();
            if (tag == null) return null;
            return tag.name;
        }

        /// <summary>
        /// 根据 code 获取  openid ,如果获取到　openid ，返回 openid;
        /// 如果获取不到，返回错误标记和 给定 Url 的 微信的授权登录验证页面的Url
        /// </summary>
        /// <returns></returns>
        public (bool hasOpenId, string openIdOrUrl) GetWechatOpenIdOrAuthenUrl(
            string code,
            string redirectUrl,
            OAuthScope authType = OAuthScope.snsapi_base)
        {
            if (string.IsNullOrEmpty(code))
            {
                return (false, Config.GetAuthenUrl(redirectUrl, authType)); ;
            }
            else
            {
                var result = this.GetOpenIdInfoAccordCode(code);
                if (result == null)
                {
                    return (false, Config.GetAuthenUrl(redirectUrl, authType)); ;
                }
                else
                {
                    if (result.errcode == Senparc.Weixin.ReturnCode.请求成功)
                    {
                        return (true, result.openid);
                    }
                    else
                    {
                        return (false, Config.GetAuthenUrl(redirectUrl, authType));
                    }
                }
            }
        }

        /// <summary>
        /// 获取用户信息;用户已经关注时才能够调用此接口;
        /// </summary>
        /// <param name="openId"></param>
        public UserInfoJson GetUserInfoAccordOpenId(string openId)
        {
            var result = UserApi.Info(Config.AppId, openId);
            return result;
        }

        /// <summary>
        /// 传入场景Id后，获取场景Id的二维码地址的Url;
        /// 扫描可以关注公众号,且将传递场景Id参数;
        /// </summary>
        /// <param name="sceneId"></param>
        /// <param name="expireSeconds">二维码过期时间,默认5分钟;</param>
        public string GetQrCodeUrl(int sceneId, int expireSeconds = 300)
        {
            var result = QrCodeApi.Create(AccessToken, expireSeconds, sceneId, QrCode_ActionName.QR_SCENE);            
            if (result.errcode == Senparc.Weixin.ReturnCode.请求成功)
            {
                return QrCodeApi.GetShowQrCodeUrl(result.ticket);
            }
            return null;
        }

        /// <summary>
        /// 传入场景Id后，获取场景Id的二维码图片地址的Url;
        /// 用户扫描后将关注公众号,且将传递场景Id参数;
        /// </summary>
        /// <param name="sceneStr">场景字符串</param>
        /// <param name="expireSeconds">二维码过期时间,默认5分钟;</param>
        public string GetQrCodeUrl(string sceneStr, int expireSeconds = 300)
        {            
            var result = QrCodeApi.Create(AccessToken, expireSeconds, 0, QrCode_ActionName.QR_STR_SCENE, sceneStr);
            if (result.errcode == Senparc.Weixin.ReturnCode.请求成功)
            {
                return QrCodeApi.GetShowQrCodeUrl(result.ticket);
            }
            return null;
        }

        /// <summary>
        /// 获取微信APP的访问令牌;
        /// </summary>
        [JsonIgnore]
        public string AccessToken
        {
            get
            {
                return AccessTokenContainer.TryGetAccessToken(Config.AppId, Config.AppSecret);
            }
        }

        /// <summary>
        /// 获取微信公众号APP的JS票据;
        /// </summary>
        [JsonIgnore]
        public string JsTicket
        {
            get
            {
                return JsApiTicketContainer.GetJsApiTicket(Config.AppId);
            }
        }

        /// <summary>
        /// 获取配置微信JSSDK的JS字符串;
        /// </summary>
        /// <param name="url"></param>
        /// <param name="interfaces"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public string GetConfigWxJs(string url, string interfaces, bool debug = true)
        {
            if (string.IsNullOrEmpty(Config.AppId))
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
            wx.config({debug:" + debug.ToString().ToLower() + ",appId:'" + Config.AppId + "',timestamp:" +
                timestamp + ",nonceStr:'" + nonceStr + "',signature:'" + signature + "',jsApiList:[" + interfs + "]});";
            return configString;
        }



        /// <summary>
        /// 获取微信 JSSDK 预支付接口参数，支付的有效时间为 1分钟;
        /// </summary>
        /// <param name="openId">用户的OpenId</param>
        /// <param name="orderNumber">订单号</param>
        /// <param name="orderDesc">订单描述信息;长度为 String(128),但字符串长度为72时也说信息错误;</param>
        /// <param name="clientIp">用户Ip地址;</param>
        /// <param name="money">订单金额;注意,元为单位;</param>
        /// <param name="orderGuid"></param>
        /// <param name="payResultCallbackApi">支付成功时的回调接口,默认下使用配置中的回调接口</param>
        /// <param name="expireMinuts">1分钟失效</param>
        /// <returns></returns>
        public PayInfoForWeixinJsBridge GetPayInfoForWeixinJsBridge(string openId,
            string orderNumber,
            string orderDesc,
            string clientIp,
            decimal money,
            string orderGuid=null,
            string payResultCallbackApi = null,
            int expireMinuts = 1)
        {
            var timeStamp = TenPayV3Util.GetTimestamp();
            var nonceStr = TenPayV3Util.GetNoncestr();
            if (!string.IsNullOrEmpty(orderDesc) && orderDesc.Length > 40)
            {
                orderDesc = orderDesc.Substring(0, 40); 
            }
            if (string.IsNullOrEmpty(payResultCallbackApi))
                payResultCallbackApi = Config.TenPayNotify;
            var expirePayTime = DateTime.Now.AddMinutes(expireMinuts); //..
            var xmlDataInfo = new TenPayV3UnifiedorderRequestData(
                  Config.AppId, 
                  Config.MchId, 
                  orderDesc,
                  orderNumber,
                  (int)(money * 100) ,  //订单金额，以元为单位;传到微信那儿需要以分为单位; 
                  clientIp,
                  Config.TenPayNotify,
                  Senparc.Weixin.TenPay.TenPayV3Type.JSAPI,
                  openId,
                  Config.TenPayKey,
                  nonceStr,
                  timeExpire: expirePayTime,
                  attach: orderGuid );
            //https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_1
            var result = TenPayV3.Unifiedorder(xmlDataInfo);//调用统一订单接口
            //JsSdkUiPackage jsPackage = new JsSdkUiPackage(TenPayV3Info.AppId, timeStamp, nonceStr,);
            if (!result.IsReturnCodeSuccess())
            {
                return new PayInfoForWeixinJsBridge
                    {
                    Error = true, 
                    ErrorCode = result.err_code,
                    ErrorDesc = result.err_code_des,
                    ReturnMsg  = result.return_msg
                };
            }
            var package = string.Format("prepay_id={0}", result.prepay_id);
            return new PayInfoForWeixinJsBridge
            {
                AppId = Config.AppId,
                Noncestr = nonceStr,
                Timestamp = timeStamp,
                Package = package,
                PaySign = TenPayV3.GetJsPaySign(Config.AppId, timeStamp, nonceStr, package, Config.TenPayKey),
                SignType = "MD5",
                ExpirePayDateTime = expirePayTime
            };
        }

        /// <summary>
        /// 订单支付验证,
        /// 返回 XML 字符串, XML字符串将包含 SUCCESS 或者 FAIL
        /// </summary>
        /// <param name="successAction">传入接收到的的 orderNumber, orderGuid, Money 三个参数用来进行验证;
        ///  验证成功返回 null,，此时 XML字符串将包含 SUCCESS；
        ///  验证失败返回失败字符串，此时 XML字符串将包含 FAIL；
        /// </param>
        /// <returns></returns>
        public string VerifyPayResult(Func<string, string, int, string> successAction)
        {
            ResponseHandler resHandler = new ResponseHandler(null);
            string return_code =  resHandler.GetParameter("return_code");  //支付的结果
            string return_msg = resHandler.GetParameter("return_msg");
            resHandler.SetKey(Config.TenPayKey);

            string verifyCode = "SUCCESS", verifyMsg = "OK";
            string resultXml = @"<xml>
<return_code><![CDATA[{0}]]></return_code>
<return_msg><![CDATA[{1}]]></return_msg>
</xml>";
            //验证请求是否从微信发过来（安全）
            if (resHandler.IsTenpaySign() && return_code.ToUpper() == "SUCCESS")
            {
                //正确的订单处理
                //直到这里，才能认为交易真正成功了，可以进行数据库操作，但是别忘了返回规定格式的消息！
                var successFuncResult = successAction(resHandler.GetParameter("out_trade_no"),
                      resHandler.GetParameter("attach"),
                      Int32.Parse(resHandler.GetParameter("total_fee")));
                if (successFuncResult != null)
                {
                    verifyCode = "FAIL";
                    verifyMsg = successFuncResult;
                }
            }
            return string.Format(resultXml, verifyCode, verifyMsg);
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
        /// 发送普通红包到指定用户;
        /// https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon.php?chapter=13_4&index=3
        /// 现金红包需要对于结算周期为 T+1 的商户，需要满足一下2个条件:
        ///       1.入驻满90天，2.连续正常交易30天。其余结算周期的商户无限制
        /// https://pay.weixin.qq.com/index.php/public/product/detail?pid=4
        /// 噗通的是，发放红包需要
        /// </summary>
        /// <param name="userOpenId">用户的Id</param>
        /// <param name="redpacketMoney">红包金额，分为单位;</param>
        /// <param name="orderNo">订单号</param>
        /// <param name="outPaySign"></param>
        /// <param name="senderName">红包发送者名称,例如 全视物联</param>
        /// <param name="actionName">活动名称</param>
        /// <param name="wishstring">红包祝福语</param>
        /// <param name="remark">备注 remark 是 猜越多得越多，快来抢！</param>
        /// <param name="outScene">随机字符串，不长于32位， 由 senparc自动产生 并回传给外部调用方</param>
        /// <param name="outPaySign">签名， 由 senparc产生 并回传给外部调用方</param>
        /// <returns></returns>
        public NormalRedPackResult SendNormalRedPacket(string userOpenId, int redpacketMoney, string orderNo, 
            string senderName,
            string actionName,
            string wishstring,
            string remark,
            out string outScene, 
            out string outPaySign)
        {
            string tenpayCertPath = @"F:\files\weixinpay_cert\1488937502\api_cert\apiclient_cert.p12"; //微信支付的证书地址;
            return RedPackApi.SendNormalRedPack(this.Config.AppId, this.Config.MchId, 
                this.Config.TenPayKey, 
                tenpayCertPath, 
                userOpenId,
                senderName, //"全视物联", 
                NetUtil.GetLocalIp(), 
                redpacketMoney,
                wishstring,
                actionName,
                remark,
                out outScene, 
                out outPaySign, 
                orderNo, 
                Senparc.Weixin.TenPay.RedPack_Scene.PRODUCT_2);
        }

        /// <summary>
        /// 获取微信的图片;
        /// </summary>
        /// <param name="mediaId"></param>
        /// <returns></returns>
        public MemoryStream GetMediaStream(string mediaId)
        {
            MemoryStream stream = new MemoryStream();
            MediaApi.Get(AccessToken, mediaId, stream);
            return stream;
        }

        /// <summary>
        /// 验证接入入口;
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="timestamp"></param>
        /// <param name="nonce"></param>
        /// <param name="echostr"></param>
        /// <returns></returns>
        public string VerifyEntry(string signature, string timestamp, string nonce, string echostr)
        {
            if (CheckSignature.Check(signature, timestamp, nonce, Config.Token))
                return echostr;
            return "error";
        }

        /// <summary>
        /// 获取带有参数的场景关注的二维码的URL;
        /// http://www.cnblogs.com/txw1958/p/weixin-qrcode-with-parameters.html
        /// 说明： 本地不下载图片，因为此图片为临时链接，
        /// 所以，在 APP端下载图片并叠加图片;
        /// </summary>
        /// <param name="sceneId">场景Id</param>
        /// <returns></returns>
        public string GetErcodeWithEntryParameter(int sceneId)
        {
            var result = QrCodeApi.Create(Config.AppId, 300, sceneId, QrCode_ActionName.QR_SCENE);
            var ticket = result.ticket;
            return "https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket=" + HttpUtility.UrlEncode(ticket);
        }

        ///// <summary>
        ///// 发送模板消息
        ///// </summary>
        ///// <param name="openId"></param>
        ///// <param name="templateId"></param>
        ///// <param name="detailUrl"></param>
        ///// <param name="modelDataMap"></param>
        //public void SendModelMessage(string openId, string templateId, List<(string name, string value)> modelDataMap, string detailUrl)
        //{
        //    TemplateApi.SendTemplateMessageAsync(this.Config.AppId, openId, templateId, 

        //    )
        //}

        /// <summary>
        /// 发送模板消息
        /// </summary>
        /// <param name="openId"></param>
        /// <param name="templateId"></param>
        /// <param name="modelData">一个匿名对象，其中的属性作为模板参数,如下所示:
        ///  new
        ///        {
         ///           nickname = new TemplateDataItem("daiwei"),
         ///           date = new TemplateDataItem("2018-06-12"),
         ///           mobile = new TemplateDataItem("13610239726"),
         ///           money = new TemplateDataItem("5.00")
         ///       }</param>
        /// <param name="detailUrl"></param>
        public void SendTemplateMessage(string openId, string templateId, object modelData, string detailUrl)
        {
            //var obj = new ExpandoObject() as IDictionary<string, Object>;
            //foreach (var pair in modelData)
            //{
            //    obj[pair.Key] = new TemplateDataItem(pair.Value);
            //}

            //TemplateApi.SendTemplateMessage(this.AccessToken, openId, )
            TemplateApi.SendTemplateMessage(this.Config.AppId, openId, templateId, detailUrl, modelData);

        }

        /// <summary>
        /// 发送模板消息
        /// </summary>
        /// <param name="openId"></param>
        /// <param name="templateId"></param>
        /// <param name="modelData">一个匿名对象，其中的属性作为模板参数,如下所示:
        ///  new
        ///        {
        ///           nickname = new TemplateDataItem("daiwei"),
        ///           date = new TemplateDataItem("2018-06-12"),
        ///           mobile = new TemplateDataItem("13610239726"),
        ///           money = new TemplateDataItem("5.00")
        ///       }</param>
        /// <param name="detailUrl"></param>
        public Task<SendTemplateMessageResult> SendTemplateMessageAsync(string openId, string templateId, object modelData, string detailUrl)
        {
            //var obj = new ExpandoObject() as IDictionary<string, Object>;
            //foreach (var pair in modelData)
            //{
            //    obj[pair.Key] = new TemplateDataItem(pair.Value);
            //}

            //TemplateApi.SendTemplateMessage(this.AccessToken, openId, )
            return TemplateApi.SendTemplateMessageAsync(this.Config.AppId, openId, templateId, detailUrl, modelData);

        }

        /// <summary>
        /// 长链接转短链接接口   https://mp.weixin.qq.com/wiki?t=resource/res_main&id=mp1443433600
        /// 注意，微信限制1天只能产生 十万次;
        /// </summary>
        /// <returns></returns>
        public string ShortUrl(string url)
        {
            var result = Senparc.Weixin.MP.AdvancedAPIs.UrlApi.ShortUrl(this.AccessToken, "long2short", url);
            return result.short_url;
        }

        // <summary>
        // 发送文本消息到给定的用户;
        // </summary>
        // <param name="userId">用户的openid</param>
        // <param name="content"></param>
        /*public void SendMessage(string userId, string content)
        {
            Senparc.Weixin.MP.MessageHandlers.
            // userId = "qy01c0f1cc0310c7002848a37e2e";
            var massResult = MassApi.SendText(AccessToken, userId, null, null, AgentId, content);

        }*/

        // <summary>
        // 发送文本消息到给定的用户;
        // </summary>
        // <param name="userId"></param>
        // <param name="content"></param>
        /*public Task<MassResult> SendMessageAsync(string userId, string content)
        {
            // userId = "qy01c0f1cc0310c7002848a37e2e";
            return MassApi.SendTextAsync(AccessToken, userId, null, null, AgentId, content);
        }*/

        // <summary>
        // 发送图文消息到给定的用户;
        // 注意普通图文消息的长度不超过512字节;
        // </summary>
        // <param name="userId"></param>
        // <param name="articleList"></param>
        /*public void SendNews(string userId, List<Article> articleList)
        {
            // userId = "qy01c0f1cc0310c7002848a37e2e";
            MassApi.SendNews(AccessToken, userId, null, null, AgentId, articleList);
        }*/

        // <summary>
        // 发送图文消息到给定的用户;
        // 多个图文消息将会显示图片和消息标题在微信消息上,
        // 但点击时按照消息的内容进行跳转或者显示;
        // </summary>
        // <param name="userId"></param>
        // <param name="articleList"></param>
        /*public void SendMpnews(string userId, List<MpNewsArticle> articleList)
        {
            MassApi.SendMpNews(AccessToken, userId, null, null, AgentId, articleList);
            // userId = "qy01c0f1cc0310c7002848a37e2e";
            //MassApi.SendNews(AccessToken, userId, null, null, AgentId, articleList);
        }
        */

        // <summary>
        // 上传文件;
        // </summary>
        // <param name="filepath"></param>
        // <returns></returns>
        /*public UploadTemporaryResultJson UploadFile(string filepath)
        {
            return MediaApi.Upload(AccessToken, Senparc.Weixin.QY.UploadMediaFileType.file, filepath);
        }*/

        // <summary>
        // 上传图片到微信服务器,但是返回url;
        // </summary>
        // <param name="filepath"></param>
        // <returns></returns>
        /*public UploadimgMediaResult UploadimgMedia(string filepath)
        {
            var result = MediaApi.UploadimgMedia(AccessToken, filepath);
            return result;
        }*/

        // <summary>
        // 发送文件;
        // </summary>
        // <param name="userid"></param>
        // <param name="filepath"></param>
        /*public MassResult SendFileToUser(string userid, string filepath)
        {
            var uploadResult = UploadFile(filepath);
            return MassApi.SendFile(AccessToken, userid, null, null, AgentId, uploadResult.media_id);

        }*/

        // <summary>
        // 获取用户信息;
        // </summary>
        // <param name="code"></param>
        // <returns></returns>
        /*public GetUserInfoResult GetUserInfo(string code)
        {
            return OAuth2Api.GetUserId(this.AccessToken, code);
        }*/
    }
}
