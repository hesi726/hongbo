using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Wechat
{
    /// <summary>
    /// 微信JSSDK的配置类，
    /// 用于给 wx.config 方法调用；
    /// </summary>
    public class JSSdkConfigOption
    {
        /// <summary>
        /// 
        /// </summary>
        public bool debug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string appId { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string nonceStr { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string signature { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string[] jsApiList { get; set;  }
    }
}
