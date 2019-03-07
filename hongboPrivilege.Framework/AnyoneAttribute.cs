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
    public class AnyoneAttribute : AbstractAllowAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public static Type AnyoneAttributeType = typeof(AnyoneAttribute);

        /// <summary>
        /// 构造函数
        /// </summary>
        public AnyoneAttribute() : base(AuthenUtil.PRIVILEGE_ANYONE)
        {
        }
    }
}