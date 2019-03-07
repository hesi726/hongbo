using hongbao.privileges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hongboPrivilege.Test
{
    /// <summary>
    /// Ĭ����û���κ�Ȩ�޵���;
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
    /// ����Ա��
    /// </summary>
    public class AdminUser : DefaultPrivilegeJudge
    {
        public override bool IsAdministrator()
        {
            return true;
        }
    }


    /// <summary>
    /// ��ֹ���в������ࣺ
    /// </summary>
    public class UserWith : DefaultPrivilegeJudge
    {
        public virtual bool HasPrivilege(string privilege)
        {
            return (privilege == TestConst.Privilege_UserQuery);
        }
    }


}
