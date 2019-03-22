using hongbao.Common;
using hongbao.SystemExtension;
using hongbaoStandardExtension.Wechat;
#if NET472
using System.Web.Mvc;
#else
using Microsoft.AspNetCore.Mvc;
#endif
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.AdvancedAPIs;
using Senparc.Weixin.MP.Entities.Menu;
using Senparc.Weixin.TenPay.V3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace hongbao.Wechat
{
    /// <summary>
    /// 微信配置类;
    /// </summary>
    public class WechatConfig
    {
        /// <summary>
        /// 微信支付的Key;
        /// </summary>
        public string TenPayKey { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public WechatConfig()
        {

        }

        /// <summary>
        /// 配置名称的前缀，将根据前缀从 配置文件 (app.config,web.config)
        ///  或者 List&lt;NameAndValue&gt; 去寻找对应的名称来配置值;
        /// </summary>
        public WechatConfig(string prefix, List<INameAndValue> configList)
        {
            Name = prefix;
            Token = NameAndValue.GetValueFromConfig(  prefix + ".token", configList);
            EncodingAesKey = NameAndValue.GetValueFromConfig(prefix + ".encodingAesKey", configList);
            AppId = NameAndValue.GetValueFromConfig(prefix + ".appId", configList);
            AppSecret = NameAndValue.GetValueFromConfig(prefix + ".appSecret", configList);
            MchId = NameAndValue.GetValueFromConfig(prefix + ".mchId", configList);
            TenPayNotify = NameAndValue.GetValueFromConfig(prefix + ".tenPayNotify", configList);
            var contentAndModify =  AppDomainUtil.GetMapPathContentAndLastModifyTime("/bin/" + prefix + ".menuDefine");
            if (contentAndModify != null)
            {
                MenuDefine = Newtonsoft.Json.JsonConvert.DeserializeObject<ButtonGroup>(contentAndModify.Content);
                MenuDefineModifyDateTime = contentAndModify.LastModifyDatetime;
            }
        }

        private string _name;
        /// <summary>
        /// 名称;将作为 微信验证登录时候的 state
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set
            {
                this._name = value;
                if (string.IsNullOrEmpty(State)) State = value;
            }
        }

        /// <summary>
        /// 令牌(Token)
        /// </summary>
        public virtual string Token { get;  set; }

        /// <summary>
        /// 开发者ID是公众号开发识别码，
        /// 配合开发者密码可调用公众号的接口能力
        /// </summary>
        public virtual string AppId { get;  set; }

        /// <summary>
        /// 开发者密码是校验公众号开发者身份的密码，具有极高的安全性。
        /// 切记勿把密码直接交给第三方开发者或直接存储在代码中。
        /// 如需第三方代开发公众号，请使用授权方式接入
        /// </summary>
        public virtual string AppSecret { get;  set; }

        /// <summary>
        /// 消息加解密密钥
        /// </summary>
        public virtual string EncodingAesKey { get;  set; }


        /// <summary>
        /// 商户Id;
        /// </summary>
        public virtual string MchId { get; set;  }
        /// <summary>
        /// 支付成功时的回调接口;
        /// </summary>
        public string TenPayNotify { get; internal set; }

        /// <summary>
        /// 自定义菜单; 
        /// </summary>
        public    ButtonGroup     MenuDefine { get; internal set;  }

        /// <summary>
        /// 自定义菜单最后修改时间;
        /// </summary>
        public DateTime MenuDefineModifyDateTime { get; private set; }

        /// <summary>
        /// 用在 GetAuthenUrl 方法中作为 State参数的字段;
        /// 如果为null,则使用 Name作为 State字段;
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 产生唯一的订单号;
        /// </summary>
        public string UnionOrderNumber()
        {
            return UnionOrderNumber(MchId);
        }

        /// <summary>
        /// 产生唯一的订单号;
        /// </summary>
        /// <param name="mchId"></param>
        /// <returns></returns>
        public static string UnionOrderNumber(string mchId)
        {
            return string.Format("{0}{1}{2}", mchId/*10位*/, DateTime.Now.ToString("yyyyMMddHHmmss"),
                        TenPayV3Util.BuildRandomStr(6));
        }

#region 获取重定向的Url
        /// <summary>
        /// 获取授权的Url;注意State将为本配置的Name而不为默认的State；;
        /// </summary>
        /// <returns></returns>
        public virtual string GetAuthenUrl(Controller controller, OAuthScope scope = OAuthScope.snsapi_base)
        {
            var urlWithNoQueryParameter = controller.Request.Url.ToString();
            return GetAuthenUrl(urlWithNoQueryParameter, scope);
        }

        /// <summary>
        /// 获取授权的Url;注意State将为本配置的Name而不为默认的State；;
        /// </summary>
        /// <returns></returns>
        public virtual string GetAuthenUrl(string redirectUrl, OAuthScope scope= OAuthScope.snsapi_base)
        {                       
            return OAuthApi.GetAuthorizeUrl(this.AppId, redirectUrl, this.State, scope, "code", true);
        }
#endregion
    }
}