using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 权限设置接口;
    /// </summary>
    public interface IPrivilegeSet
    {
        /// <summary>
        /// 设置角色权限;
        /// </summary>
        /// <param name="newPrivileges"></param>
        void SetPrivileges(string newPrivileges);
    }
}
