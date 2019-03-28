using hongbao.Common;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.AdvancedAPIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Wechat
{
    /// <summary>
    /// 企业微信的配置类;
    /// </summary>
    public class WechatWorkConfig : WechatConfig
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public WechatWorkConfig()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="configList"></param>
        public WechatWorkConfig(string prefix, List<INameAndValue> configList)
            : base(prefix, configList)
        {
            CorpId = NameAndValue.GetValueFromConfig(prefix + ".corpId", configList);
        }

        /// <summary>
        /// 企业的Id;
        /// </summary>
        public string CorpId { get; set; }

        /// <summary>
        /// AgentId
        /// </summary>
        public int AgentId
        {   get
            {
                return Convert.ToInt32(this.AppId);
            }
        }

        /// <summary>
        /// 企业应用的AppId，或者简称为 AgentId,
        /// 数字形式的字符串，
        /// </summary>
        public override string AppId { get; set; }

        /// <summary>
        /// 企业应用中用于加密的Key;
        /// </summary>
        public override string AppSecret { get; set; }

        

        /// <summary>
        /// 消息接收的Token,可由企业任意填写，用于生成签名。        
        /// </summary>
        public override string Token { get; set; }

        /// <summary>
        /// EncodingAESKey用于消息体的加密，是AES密钥的Base64编码
        /// 43位长度的字符串;
        /// </summary>
        public override string EncodingAesKey { get; set; }

        /// <summary>
        /// 获取授权的Url;
        /// 注意State将为本配置的Name而不为默认的State；;
        /// 对于企业号来说 ， 获取授权码为 CorpId
        /// </summary>
        /// <returns></returns>
        public override string GetAuthenUrl(string redirectUrl, OAuthScope scope = OAuthScope.snsapi_base)
        {
            return OAuthApi.GetAuthorizeUrl(this.CorpId, redirectUrl, this.Name, scope);
        }        
    }
}
