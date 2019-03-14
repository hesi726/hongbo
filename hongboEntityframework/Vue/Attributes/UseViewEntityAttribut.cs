using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// 实体类型对应的列表时的视图类，使用另外一个类进行列表时的数据显示;
    /// 当数据库模型 和  编辑 类分别位于2个不同的项目时，需要使用此属性;
    /// 例如 
    /// MachineOrBoardQueryParameter_Device 对应有 MachineOrBoardQueryResponse   的视图类;
    /// MachineOrBoardQueryParameter_Machine 对应有 MachineOrBoardQueryResponse   的视图类;
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class UseViewEntityAttribute : Attribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        public UseViewEntityAttribute(Type type)
        {
            this.ViewEntityType = type;
        }

        /// <summary>
        /// 视图的实体类
        /// </summary>
        public Type ViewEntityType { get; }
    }
}
