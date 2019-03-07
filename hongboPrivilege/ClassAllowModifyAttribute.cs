using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 在某一个类上标记，用于定义某一个类进行修改时所需要的权限;
    /// 修改操作权限（修改包含有 新建/修改 和 查询 权限 ）
    /// </summary>
    public class ClassAllowModifyAttribute : ClassAllowQueryAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="privilege">
        ///   为空字符串时表示只要登录就可以访问, 为null时表示需要管理员权限; 为字符串时表示权限;
        /// </param>
        /// <param name="usertype">为 Int32.MaxValue 时表示任意用户，否则必须符合给定的用户类型;</param>
        public ClassAllowModifyAttribute(string privilege, int usertype  = Int32.MaxValue)
            : base(privilege, usertype)
        {
        }


        
    }
}
