using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Wechat
{
    /// <summary>
    /// 微信配置获取的接口
    /// </summary>
    public interface IWechatConfigGetter
    {
        /// <summary>
        /// 微信配置
        /// </summary>
        WechatConfig Config { get; }
    }
}
