using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 权限分类描述
    /// </summary>
    public class PrivilegeDesc
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        public PrivilegeDesc(string name, string desc = null)
        {
            this.Name = name;
            this.Desc = desc;
        }
        /// <summary>
        /// 权限名称;
        /// </summary>
        public virtual string Name { get; set; }


        /// <summary>
        /// 权限说明;
        /// </summary>
        public virtual string Desc { get; set; }
    }
}
