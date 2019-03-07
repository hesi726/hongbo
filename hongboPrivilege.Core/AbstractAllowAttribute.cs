using hongbao.privileges;
using hongbao.SystemExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 抽象的授权类;
    /// </summary>
    public abstract class AbstractAllowAttribute : Attribute, IAllowAccess
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="privilege">
        ///   为空字符串时表示只要登录就可以访问, 
        ///   为null时表示允许匿名访问; 
        ///   为字符串时表示权限;
        /// </param>
        /// <param name="usertype">用户必须符合给定的用户类型才可以访问,为 Int32.MaxValue 时表示任意用户;</param>
        public AbstractAllowAttribute(string privilege, int usertype = Int32.MaxValue)
        {
            this.Privilege = privilege;
            this.Usertype = usertype;
          
        }

        /// <summary>
        ///   为空字符串时表示只要登录就可以访问, 
        ///   为null时表示允许匿名访问; 
        ///   为字符串时表示权限;
        /// </summary>
        public string Privilege { get;  private set; }

        /// <summary>
        /// 允许访问的人员类型
        /// </summary>
        public int Usertype { get; set; }

        /// <summary>
        /// 判断给定用户是否有给定的权限;
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AllowAccess(IPrivilegeJudge user)
        {
            return this.AllowAccess(user, this.Privilege);
        }

        /// <summary>
        /// 判断给定用户能否进行给定的操作
        /// </summary>
        /// <param name="privilageJudge">给定的用户</param>
        /// <param name="privilege">
        ///   为空字符串时表示只要登录就可以访问, 
        ///   为null时表示允许匿名访问; 
        ///   为字符串时表示权限;
        /// </param>
        /// <returns></returns>
        protected bool AllowAccess(IPrivilegeJudge privilageJudge, 
            string privilege)
        {
            bool allowAnanymous = false, allowAnyone = false, allowOnlyAdmin = false;
            if (privilege == AuthenUtil.PRIVILEGE_ANYONE) allowAnyone = true;
            else if (privilege == AuthenUtil.PRIVILEGE_ANANYMOUS) allowAnanymous = true;
            else if (privilege == AuthenUtil.PRIVILEGE_ADMIN) allowOnlyAdmin = true;

            if (allowAnanymous) return true;
            if (privilageJudge == null) return false;  //不允许匿名访问;
            if (allowAnyone && HasSameUsertype(privilageJudge)) return true;  //允许同类型的任何人访问;
            if (privilageJudge.IsAdministrator()) return true;    // 管理员肯定可以访问
            else if (allowOnlyAdmin) return false; //需要是管理员，但传入不是管理员;

            if (!HasSameUsertype(privilageJudge)) return false; //用户类型不一致,无权限访问

            if (string.IsNullOrEmpty(this.Privilege)) return true; //不需要权限; //只需要用户就可以了;
            if (privilageJudge.HasPrivilege(this.Privilege)) return true;
            return false;
        }

        /// <summary>
        /// 具有相同的用户类型;
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private bool HasSameUsertype(IPrivilegeJudge user)
        {
            return this.Usertype == Int32.MaxValue || 
                ((this.Usertype & (user.Usertype ?? 0)) == 0);
        }

        /// <summary>
        /// 允许匿名访问
        /// </summary>
        public bool AllowAnanymous
        {
            get
            {
                return this.Privilege == AuthenUtil.PRIVILEGE_ANANYMOUS;
            }
        }

    }
}
