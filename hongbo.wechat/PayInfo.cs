using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Wechat
{
    /// <summary>
    /// 微信支付的JS调用参数
    /// </summary>
    public class PayInfoForWeixinJsBridge
    {
        /// <summary>
        /// 
        /// </summary>
        public string AppId
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Ticket
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Noncestr
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Timestamp
        {
            get; set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string SignType
        {
            get; set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string PaySign
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Package
        {
            get;
            set;
        }

        /// <summary>
        /// 支付过期时间（过了这个时间支付，则无效)
        /// </summary>
        public DateTime ExpirePayDateTime
        {
            get; set;
        }
        /// <summary>
        /// 错误代码
        /// </summary>
        public string ErrorCode { get;  set; }
        /// <summary>
        /// 错误代码描述
        /// </summary>
        public string ErrorDesc { get;  set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Error { get;  set; }
        /// <summary>
        /// https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_1
        /// 返回信息，如非空，为错误原因  签名失败,   参数格式校验错误 ...
        /// 等等等等。。。
        /// </summary>
        public string ReturnMsg { get; set; }
    }
}
