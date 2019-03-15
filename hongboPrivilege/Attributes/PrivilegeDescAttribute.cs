using System;
using System.Collections.Generic;

namespace hongbao.privileges
{
    /// <summary>
    /// 行为描述属性;
    /// 当使用在Controller上时上时,作为权限分组使用;
    /// 当使用在Action上时，作为权限名称使用;
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class PrivilegeDescAttribute : AbstractAllowAttribute
    {
        /// <summary>
        /// PrivilegeDescAttribute的类型
        /// </summary>
        public static Type PrivilegeDescAttributeType = typeof(PrivilegeDescAttribute);

        /// <summary>
        /// 构造函数;
        /// </summary>
        /// <param name="privilege">权限名称</param>
        /// <param name="usertype">为 Int32.MaxValue 时表示任意用户，否则必须符合给定的用户类型</param>
        public PrivilegeDescAttribute(string privilege, int usertype = Int32.MaxValue) : base(privilege, usertype)
        {
        }                    

        /// <summary>
        /// 实体类型名称
        /// </summary>
        public string EntityTypeName
        {
            get; set;
        }

        
    }

    
    
}