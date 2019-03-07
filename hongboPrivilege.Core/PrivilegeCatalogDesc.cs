using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 权限分类分类描述
    /// </summary>
    public class PrivilegeCatalogDesc : PrivilegeDesc
    {
        /// <summary>
        /// 所有权限分类和权限定义
        /// </summary>
        public static List<PrivilegeCatalogDesc> PrivilegeCatalogList = new List<PrivilegeCatalogDesc>();

        /// <summary>
        /// 构造函数
        /// </summary>
        public PrivilegeCatalogDesc(string name, string desc = null): base(name, desc)
        {
            OperationList = new List<PrivilegeDesc>();
            PrivilegeCatalogList.Add(this);
        }

        /// <summary>
        /// 权限分类名称;
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// 权限分类说明;
        /// </summary>
        public override string Desc { get; set; }

        /// <summary>
        /// 本分类下允许的操作
        /// </summary>

        public List<PrivilegeDesc> OperationList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        public void Add(string name, string desc)
        {
            this.OperationList.Add(new PrivilegeDesc(name, desc));
        }
    }

}
