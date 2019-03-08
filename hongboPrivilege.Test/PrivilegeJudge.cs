using hongbao.privileges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hongboPrivilege.Test
{
    /// <summary>
    /// 默认下没有任何权限的类;
    /// </summary>
    public class DefaultPrivilegeJudge : IPrivilegeJudge
    {
        public int? Usertype { get; set; }

        public virtual bool HasAllPrivilege(string[] privileges)
        {
            return false;
        }

        public virtual bool HasAnyPrivilege(string[] privileges)
        {
            return false;
        }

        public virtual bool HasPrivilege(string privilege)
        {
            return false;
        }

        public virtual bool IsAdministrator()
        {
            return false;
        }
    }

    /// <summary>
    /// 管理员：
    /// </summary>
    public class AdminUser : DefaultPrivilegeJudge
    {
        public override bool IsAdministrator()
        {
            return true;
        }
    }


    /// <summary>
    /// 允许进行用户查询的权限判断对象
    /// </summary>
    public class UserWithUserQueryPrivilege : DefaultPrivilegeJudge
    {
        public override bool HasPrivilege(string privilege)
        {
            return (privilege == TestConst.Privilege_UserQuery);
        }
    }

    /// <summary>
    /// 允许进行用户修改的权限判断对象
    /// </summary>
    public class UserWithUserModifyPrivilege : DefaultPrivilegeJudge
    {
        public override bool HasPrivilege(string privilege)
        {
            return (privilege == TestConst.Privilege_UserModify);
        }
    }
}
