using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// 某一个编辑类型对应的源实体类，（和 <see cref="UseEditEntityAttribute"/> 为反操作  
    /// 但是对于一个实体类型，其可能无法得知编辑类的存在;
    /// EH_Media 对应有 SaveMediaRequest 的编辑类;
    /// 但是在 EH_Media 的项目中，无法得知 SaveMediaRequest 编辑类的存在;
    /// 因此，为了使 EH_Media 和 SaveMediaRequest 关联起来，需要在 SaveMediaRequest 类中标记 UseEditSourceEntityAttribute 标注;
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class UseEditSourceEntityAttribute : Attribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        public UseEditSourceEntityAttribute(Type type)
        {
            this.SourceEntityType = type;
        }

        /// <summary>
        /// 视图的实体类
        /// </summary>
        public Type SourceEntityType { get; }
    }
}
