using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 权限接口,
    /// </summary>
    public interface IPrivilegeJudge
    {
        /// <summary>
        /// 能够访问某权限;
        /// </summary>
        /// <param name="privilege"></param>
        /// <returns></returns>
        bool HasPrivilege(string privilege);

        /// <summary>
        /// 具有某个权限;
        /// </summary>
        /// <param name="privileges"></param>
        /// <returns></returns>
        bool HasAnyPrivilege(string[] privileges);

        /// <summary>
        /// 具有全部权限;
        /// </summary>
        /// <param name="privileges"></param>
        /// <returns></returns>
        bool HasAllPrivilege(string[] privileges);

        /// <summary>
        /// 是否是系统管理员;
        /// </summary>
        /// <returns></returns>
        bool IsAdministrator();

        /// <summary>
        /// 如果当前用户的 Usertype 和 指定的 Usertype 不一致时，返回 false;
        /// 为 null 时，表示不判断 Usertype;
        /// </summary>
        int? Usertype { get; }
    }
}
