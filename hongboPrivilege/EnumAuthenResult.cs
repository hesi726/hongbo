using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 授权验证结果枚举类
    /// </summary>
    public enum EnumAuthenResult
    {
        /// <summary>
        /// 授权
        /// </summary>
        Authened,
        /// <summary>
        /// 未登录
        /// </summary>
        Unlogin,
        /// <summary>
        /// 未授权
        /// </summary>
        NotAuthened
    }
}
