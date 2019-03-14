using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// 实体类型对应的编辑时的类，视图实体编辑时对应有不同的编辑类;
    /// 例如 View_Buildinfo 对应有  EH_Building 的编辑类;
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class UseEditEntityAttribute : Attribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        public UseEditEntityAttribute(Type type)
        {
            this.EditEntityType = type;
        }

        /// <summary>
        /// 视图的实体类
        /// </summary>
        public Type EditEntityType { get; }
    }
}
