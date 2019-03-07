using hongbao.privileges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// IAllowAccess 接口
    /// </summary>
    public interface IAllowAccess
    {
        /// <summary>
        /// 给定权限判断对象是否允许操作;
        /// </summary>
        /// <param name="withPrivilegeInstance"></param>
        /// <returns></returns>
        bool AllowAccess(IPrivilegeJudge withPrivilegeInstance);
    }
}
