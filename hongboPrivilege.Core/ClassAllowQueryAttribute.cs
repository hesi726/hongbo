using hongbao.privileges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    
    /// <summary>
    /// 类的查询权限,
    /// 在某一个类上标记，用于定义某一个类/或者枚举成员进行查询时所需要的权限;
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ClassAllowQueryAttribute : AbstractAllowAttribute, IAllowAccess
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="privilege">
        ///   为空字符串时表示只要登录就可以访问, 为null时表示需要管理员权限; 为字符串时表示权限;
        /// </param>
        /// <param name="userType">为 Int32.MaxValue 时表示任意用户，否则必须符合给定的用户类型;</param>
        public ClassAllowQueryAttribute(string privilege, int userType = Int32.MaxValue)
            :base(privilege, userType)
        {
        }
        
       

        
    }
}
