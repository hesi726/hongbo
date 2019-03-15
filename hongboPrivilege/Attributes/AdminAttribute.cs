using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hongbao.privileges
{
    /// <summary>
    /// 任意用户都可以进行操作，也可以进行操作;
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AdminAttribute : AbstractAllowAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public static Type AdminAttributeType = typeof(AdminAttribute);

        /// <summary>
        /// 构造函数
        /// </summary>
        public AdminAttribute() : base(AuthenUtil.PRIVILEGE_ADMIN)
        {
        }
    }
}