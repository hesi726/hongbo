using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 通用的标注类;
    /// </summary>
    public class OwnerAndTypeAttribute : Attribute
    {
        /// <summary>
        /// 此标注类的所有者类型
        /// </summary>
        public virtual void SetOwnerType(Type ownerType) { }

        /// <summary>
        /// 此标注类的所有者属性
        /// </summary>
        public virtual void SetOwnerProperty(PropertyInfo ownerType) { }
    }
}
