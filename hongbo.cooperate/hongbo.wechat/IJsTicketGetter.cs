using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Wechat
{
    /// <summary>
    /// JSSDk票据获取的接口
    /// </summary>
    public interface IJSTicketGetter
    {
        /// <summary>
        /// 获取 JsTicket，产生 JsApi 的配置时，需要 Appid,
        /// 但是对于 公众号，appid 就是 Appid;
        /// 对于企业号， appid 为 CorpId;
        /// https://work.weixin.qq.com/api/doc#10029/步骤二：通过config接口注入权限验证配置
        /// </summary>
        string JsTicketAppId { get;  }

        /// <summary>
        /// 微信配置
        /// </summary>
        string JsTicket { get; }
    }
}
