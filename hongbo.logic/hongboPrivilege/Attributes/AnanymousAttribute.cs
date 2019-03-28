using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hongbao.privileges
{
    /// <summary>
    /// 匿名都能够访问的一个描述性属性;
    /// 即使用户未登录，也可以进行操作;
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AnanymousAttribute : AbstractAllowAttribute
    {
        /// <summary>
        /// 匿名访问类型;
        /// </summary>
        public static Type AnanymousAttributeType = typeof(AnanymousAttribute);

        /// <summary>
        /// 构造函数
        /// </summary>
        public AnanymousAttribute() : base(AuthenUtil.PRIVILEGE_ANANYMOUS)
        {
        }
    }
}